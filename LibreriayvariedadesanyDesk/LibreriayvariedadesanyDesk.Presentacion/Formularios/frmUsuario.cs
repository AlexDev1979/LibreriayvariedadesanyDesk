using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskPresentacion.Utilidades.Objetos;
using LibreriayvariedadesanyDeskPresentacion.VeiwModels;
using LibreriayvariedadesanyDeskServices.Interfaces;
using LibreriayvariedadesanyDeskServices.Implementacion;
using SVPresentation.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    public partial class frmUsuario : Form
    {
        private readonly IRolservices _rolServices;
        private readonly IUsuarioServices _usuarioServices;
        private readonly ICorreoServices _correoServices;
        public frmUsuario(IRolservices rolservices, IUsuarioServices usuarioServices, ICorreoServices correoServices)
        {
            InitializeComponent();
            _rolServices = rolservices;
            _usuarioServices = usuarioServices;
            _correoServices = correoServices;
        }
        public void MostrarTab(string tabName)
        {
            var tabsMenu = new TabPage[] { tabLista, tabNuevo, tabEditar };

            foreach (var tab in tabsMenu)
            {
                if (tab.Name != tabName)
                {
                    tab.Parent = null;
                }
                else
                {
                    tab.Parent = tabControlMain;
                }
            }
        }
        private async Task MostrarUsuario(string buscar = "")
        {
            var listaUsuario = await _usuarioServices.Lista(buscar);
            var listaVM = listaUsuario.Select(item => new UsuarioVM
            {
                codigoUsuario = item.codigoUsuario,
                codigoRol = item.refRol.codigoRol,
                Rol = item.refRol.Nombre,
                nombreCompleto = item.nombreCompleto,
                email = item.email,
                nombreUsuario = item.nombreUsuario,
                Activo = item.Estado,
                Habilitado = item.Estado == 1 ? "SI" : "NO"
            }).ToList();

            GridDatosUsuario.DataSource = listaVM;

            GridDatosUsuario.Columns["codigoUsuario"].Visible = false;
            GridDatosUsuario.Columns["codigoRol"].Visible = false;
            GridDatosUsuario.Columns["Activo"].Visible = false;
        }
        private async void Usuario_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            GridDatosUsuario.ImplementarConfiguracion("Editar");
            GridDatosUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            await MostrarUsuario();

            OpcionCombo[] itemsHabilitados = new OpcionCombo[]
            {
                new OpcionCombo{ Texto = "SI", Valor = 1},
                new OpcionCombo{ Texto = "NO", Valor = 0},
            };
            var listaRol = await _rolServices.Lista();
            var items = listaRol.Select(item => new OpcionCombo
            {
                Texto = item.Nombre,
                Valor = item.codigoRol,
            }).ToArray();
            cbNuevoRol.InsertarItems(items);
            cbRolEditar.InsertarItems(items);
            cbHabilitadoE.InsertarItems(itemsHabilitados);
        }

        private async void btBuscarU_Click(object sender, EventArgs e)
        {
            await MostrarUsuario(tbBuscar.Text);
        }

        private void btnuevoU_Click(object sender, EventArgs e)
        {
            cbNuevoRol.SelectedIndex = 0;
            tbNuevoNombre.Text = "";
            tbEmail.Text = "";
            tbNombreUsuario.Text = "";
            MostrarTab(tabNuevo.Name);
            cbNuevoRol.Select();
        }

        private void btRegresarN_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btGuardarN_Click(object sender, EventArgs e)
        {
            if (tbNuevoNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }
            if (tbEmail.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un email");
                return;
            }
            if (tbNombreUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre de usuario");
                return;
            }
            var claveGenerada = GeneradorUtil.GenerateCode();
            var claveSha256 = GeneradorUtil.ConvertToSha256(claveGenerada);

            var objeto = new Usuario
            {
                refRol = new Rol { codigoRol = ((OpcionCombo)cbNuevoRol.SelectedItem!).Valor },
                nombreCompleto = tbNuevoNombre.Text.Trim(),
                email = tbEmail.Text.Trim(),
                nombreUsuario = tbNombreUsuario.Text.Trim(),
                clave = claveSha256
            };
            try
            {
                var respuesta = await _usuarioServices.Crear(objeto);
                if (respuesta != "")
                {
                    var mensaje = $"Bienvenido al sistema Administracion total<br>Su contraseña temporal es:{claveGenerada}</br>" +
                                              $"<br>El sistema le pedira el cambio de la misma automaticamente</br>";
                    await _correoServices.Enviar(objeto.email, "Su cuenta ha sido creada exitosamente", mensaje);
                    MessageBox.Show(respuesta);
                }
                else
                {

                    await MostrarUsuario();
                    MostrarTab(tabLista.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void GridDatosUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridDatosUsuario.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var usuarioSeleccionado = (UsuarioVM)GridDatosUsuario.CurrentRow.DataBoundItem;
                cbRolEditar.EstablecerValor(usuarioSeleccionado.codigoRol);
                tbNombreEdit.Text = usuarioSeleccionado.nombreCompleto.ToString();
                tbEmailEdit.Text = usuarioSeleccionado.email.ToString();
                tbUsuarioEdit.Text = usuarioSeleccionado.nombreUsuario.ToString();
                cbHabilitadoE.EstablecerValor(usuarioSeleccionado.Activo);
                MostrarTab(tabEditar.Name);
                cbRolEditar.Select();
            }
        }

        private void btREgresarE_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {
            if (tbNombreEdit.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }
            if (tbEmailEdit.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un email");
                return;
            }
            if (tbUsuarioEdit.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre de usuario");
                return;
            }
            var usuarioSeleccionado = (UsuarioVM)GridDatosUsuario.CurrentRow.DataBoundItem;
            var objeto = new Usuario
            {
                codigoUsuario = usuarioSeleccionado.codigoUsuario,
                refRol = new Rol { codigoRol = ((OpcionCombo)cbRolEditar.SelectedItem!).Valor },
                nombreCompleto = tbNombreEdit.Text.Trim(),
                email = tbEmailEdit.Text.Trim(),
                nombreUsuario = tbUsuarioEdit.Text.Trim(),
                Estado = ((OpcionCombo)cbHabilitadoE.SelectedItem!).Valor
            };
            try
            {
                var respuesta = await _usuarioServices.Editar(objeto);
                if (respuesta != "")
                {
                    MessageBox.Show(respuesta);
                }
                else
                {
                    await MostrarUsuario();
                    MostrarTab(tabLista.Name);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
