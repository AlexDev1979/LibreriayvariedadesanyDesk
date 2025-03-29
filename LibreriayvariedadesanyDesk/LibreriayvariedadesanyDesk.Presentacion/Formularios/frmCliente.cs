using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskPresentacion.Utilidades.Objetos;
using LibreriayvariedadesanyDeskPresentacion.VeiwModels;
using LibreriayvariedadesanyDeskServices.Interfaces;
using SVPresentation.Utilidades;
using System.Data;

namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    public partial class frmCliente : Form
    {
        private readonly IClienteServices _clienteServices;

        public frmCliente(IClienteServices clienteServices)
        {
            InitializeComponent();
            _clienteServices = clienteServices;
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

        private async Task MostrarCliente(string buscar = "")
        {
            var listaCliente = await _clienteServices.Lista(buscar);
            var listaVM = listaCliente.Select(item => new ClienteVM
            {
                codigoCliente = item.codigoCliente,
                nombreCliente = item.nombreCompletoCliente,
                nit = item.nit,
                telefono = item.telefono,
                direccion = item.direccion,
                email = item.email,
                Activo = item.estado,
                Habilitado = item.estado == 1 ? "SI" : "NO"
            }).ToList();

            GridDatosCliente.DataSource = listaVM;

            GridDatosCliente.Columns["codigoCliente"].Visible = false;
            GridDatosCliente.Columns["Activo"].Visible = false;
        }

        private async void frmCliente_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            GridDatosCliente.ImplementarConfiguracion("Editar");
            GridDatosCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            await MostrarCliente();

            OpcionCombo[] itemsHabilitados = new OpcionCombo[]
            {
                new OpcionCombo{ Texto = "SI", Valor = 1},
                new OpcionCombo{ Texto = "NO", Valor = 0},
            };
            cbHabilitadoE.InsertarItems(itemsHabilitados);
        }

        private async void btBuscarC_Click(object sender, EventArgs e)
        {
            await MostrarCliente(tbBuscar.Text);
        }

        private void btnuevoC_Click(object sender, EventArgs e)
        {
            tbNCliente.Text = "";
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
            if (tbNCliente.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }
            if (tbEmail.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un email");
                return;
            }

            var objeto = new Clientes
            {
                nombreCompletoCliente = tbNCliente.Text.Trim(),
                nit = tbNit.Text.Trim(),
                telefono = tbTelefono.Text.Trim(),
                direccion = tbDireccion.Text.Trim(),
                email = tbEmail.Text.Trim()
            };
            try
            {
                var respuesta = await _clienteServices.Crear(objeto);
                if (respuesta != "")
                {
                    var mensaje = MessageBox.Show("El cliente fue creado exitosamente");
                    await MostrarCliente();
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

        private void GridDatosCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridDatosCliente.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var clienteSeleccionado = (ClienteVM)GridDatosCliente.CurrentRow.DataBoundItem;
                tbNClienteE.Text = clienteSeleccionado.nombreCliente.ToString();
                tbNitE.Text = clienteSeleccionado.nit.ToString();
                tbTelefonoE.Text = clienteSeleccionado.telefono.ToString();
                tbDireccionE.Text = clienteSeleccionado.direccion.ToString();
                tbEmailE.Text = clienteSeleccionado.email.ToString();
                cbHabilitadoE.EstablecerValor(clienteSeleccionado.Activo);
                MostrarTab(tabEditar.Name);
            }
        }

        private void btREgresarE_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {
            if (tbNClienteE.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
                return;
            }
            var clienteSeleccionado = (ClienteVM)GridDatosCliente.CurrentRow.DataBoundItem;
            var objeto = new Clientes
            {
                codigoCliente = clienteSeleccionado.codigoCliente,
                nombreCompletoCliente = tbNClienteE.Text.Trim(),
                nit = tbNitE.Text.Trim(),
                telefono = tbTelefonoE.Text.Trim(),
                direccion = tbDireccionE.Text.Trim(),
                email = tbEmailE.Text.Trim(),
                estado = ((OpcionCombo)cbHabilitadoE.SelectedItem!).Valor
            };
            try
            {
                var respuesta = await _clienteServices.Editar(objeto);
                if (respuesta != "")
                {
                    MessageBox.Show(respuesta);
                }
                else
                {
                    await MostrarCliente();
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