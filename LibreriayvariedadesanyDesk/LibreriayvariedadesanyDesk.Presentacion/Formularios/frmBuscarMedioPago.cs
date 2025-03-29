using LibreriayvariedadesanyDeskPresentacion.VeiwModels;
using LibreriayvariedadesanyDeskServices.Interfaces;
using SVPresentation.Utilidades;
using System.Data;

namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    public partial class frmBuscarMedioPago : Form
    {
        private readonly IMedioPagoServices _medioPagoServices;
        public MedioPagoVM _medioPagoSeleccionado { get; set; } = null!;

        public frmBuscarMedioPago(IMedioPagoServices medioPagoServices)
        {
            InitializeComponent();
            _medioPagoServices = medioPagoServices;
        }

        private async Task MostrarMedioPago(string buscar = "")
        {
            try
            {
                var listaMedioPago = await _medioPagoServices.Lista();
                var listaVM = listaMedioPago
                    .Where(item => (string.IsNullOrEmpty(buscar) || item.descripcion.Contains(buscar, StringComparison.OrdinalIgnoreCase))
                                   && !string.IsNullOrEmpty(item.descripcion))
                    .Select(item => new MedioPagoVM
                    {
                        codigoMedioPago = item.codigoMedioPago,
                        Descripcion = item.descripcion,
                    }).ToList();

                GridDatosMPago.DataSource = listaVM;

                // Configuración de columnas
                GridDatosMPago.Columns["codigoMedioPago"].Visible = false;
                GridDatosMPago.Columns["Descripcion"].Width = 200;
                GridDatosMPago.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al mostrar los medios de pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void frmBuscarMedioPago_Load(object sender, EventArgs e)
        {
            GridDatosMPago.ImplementarConfiguracion();
            await MostrarMedioPago();
        }

        private async void btBuscarMP_Click(object sender, EventArgs e)
        {
            await MostrarMedioPago(tbBuscar.Text.Trim());
        }

        private void GridDatosMPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _medioPagoSeleccionado = (MedioPagoVM)GridDatosMPago.CurrentRow.DataBoundItem;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}