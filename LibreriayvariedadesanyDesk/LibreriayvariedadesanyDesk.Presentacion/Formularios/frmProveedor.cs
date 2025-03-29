using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskPresentacion.Utilidades.Objetos;
using LibreriayvariedadesanyDeskPresentacion.VeiwModels;
using LibreriayvariedadesanyDeskServices.Interfaces;
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
    public partial class frmProveedor : Form
    {
        private readonly IProveedorServices _proveedorServices;

        public frmProveedor(IProveedorServices proveedorServices)
        {
            InitializeComponent();
            _proveedorServices = proveedorServices;
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
        private async Task MostrarProveedor(string buscar = "")
        {
            var listaProveedor = await _proveedorServices.Lista(buscar);
            var listaVM = listaProveedor.Select(item => new ProveedorVM
            {
                codigoProveedor = item.codigoProveedor,
                nombreProveedor = item.nombreCompletoProveedor,
                nit = item.nit,
                telefono = item.telefono,
                direccion = item.direccion,
                email = item.email,
                Activo = item.estado,
                Habilitado = item.estado == 1 ? "SI" : "NO"
            }).ToList();

            GridDatosProveedor.DataSource = listaVM;

            GridDatosProveedor.Columns["codigoProveedor"].Visible = false;
            GridDatosProveedor.Columns["Activo"].Visible = false;
        }

        private async void frmProveedor_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            GridDatosProveedor.ImplementarConfiguracion("Editar");
            GridDatosProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            await MostrarProveedor();

            OpcionCombo[] itemsHabilitados = new OpcionCombo[]
            {
                new OpcionCombo{ Texto = "SI", Valor = 1},
                new OpcionCombo{ Texto = "NO", Valor = 0},
            };
            cbHabilitadoE.InsertarItems(itemsHabilitados);
        }

        private async void btBuscarP_Click(object sender, EventArgs e)
        {
            await MostrarProveedor(tbBuscar.Text);
        }

        private void btnuevoP_Click(object sender, EventArgs e)
        {
            tbNProveedor.Text = "";
            tbNit.Text = "";
            tbEmail.Text = "";
            tbTelefono.Text = "";
            tbDireccion.Text = "";
            MostrarTab(tabNuevo.Name);
        }

        private void btRegresarN_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btGuardarN_Click(object sender, EventArgs e)
        {
            if (tbNProveedor.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }

            var objeto = new Proveedor
            {
                nombreCompletoProveedor = tbNProveedor.Text.Trim(),
                nit = tbNit.Text.Trim(),
                telefono = tbTelefono.Text.Trim(),
                direccion = tbDireccion.Text.Trim(),
                email = tbEmail.Text.Trim()
            };
            try
            {
                var respuesta = await _proveedorServices.Crear(objeto);
                if (respuesta != "")
                {
                    var mensaje = MessageBox.Show("El cliente fue creado exitosamente");
                    await MostrarProveedor();
                    MostrarTab(tabLista.Name);
                }
                else
                {
                    MessageBox.Show(respuesta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void GridDatosProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridDatosProveedor.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var proveedorSeleccionado = (ProveedorVM)GridDatosProveedor.CurrentRow.DataBoundItem;
                tbProveedorE.Text = proveedorSeleccionado.nombreProveedor.ToString();
                tbNitE.Text = proveedorSeleccionado.nit.ToString();
                tbTelefonoE.Text = proveedorSeleccionado.telefono.ToString();
                tbDireccionE.Text = proveedorSeleccionado.direccion.ToString();
                tbEmailE.Text = proveedorSeleccionado.email.ToString();
                cbHabilitadoE.EstablecerValor(proveedorSeleccionado.Activo);
                MostrarTab(tabEditar.Name);
            }
        }

        private void btREgresarE_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {
            if (tbProveedorE.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }
            if (tbEmailE.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un email");
                return;
            }
            var proveedorSeleccionado = (ProveedorVM)GridDatosProveedor.CurrentRow.DataBoundItem;
            var objeto = new Proveedor
            {
                codigoProveedor = proveedorSeleccionado.codigoProveedor,
                nombreCompletoProveedor = tbProveedorE.Text.Trim(),
                nit = tbNitE.Text.Trim(),
                telefono = tbTelefonoE.Text.Trim(),
                direccion = tbDireccionE.Text.Trim(),
                email = tbEmailE.Text.Trim(),
                estado = ((OpcionCombo)cbHabilitadoE.SelectedItem!).Valor
            };
            try
            {
                var respuesta = await _proveedorServices.Editar(objeto);
                if (respuesta != "")
                {
                    MessageBox.Show(respuesta);

                }
                else
                {
                    await MostrarProveedor();
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
