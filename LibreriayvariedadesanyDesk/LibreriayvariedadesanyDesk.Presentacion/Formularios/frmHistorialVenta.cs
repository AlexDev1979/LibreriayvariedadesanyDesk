using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskPresentacion.VeiwModels;
using LibreriayvariedadesanyDeskServices.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using SVPresentation.Utilidades;
using System.Threading.Tasks;

namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    public partial class frmHistorialVenta : Form
    {
        private readonly IVentaServices _ventaServices;
        private readonly IServiceProvider _serviceProvider;

        public frmHistorialVenta(IVentaServices ventaServices, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _ventaServices = ventaServices;
            _serviceProvider = serviceProvider;
        }

        private async Task MostrarVenta()
        {
            var listaVenta = await _ventaServices.lista(
                dtFechaInicio.Value.ToString("dd/MM/yyyy"),
                dtFechaFinal.Value.ToString("dd/MM/yyyy"),
                tbBuscarVenta.Text.Trim()
                );
            var listaVM = listaVenta.Select(item => new VentaVM
            {
                fechaRegistro = item.fechaRegistro,
                numeroVenta = item.numeroVenta,
                usuario = item.UsuarioRegistro.nombreUsuario,
                cliente = item.nombreCliente,
                total = item.precioTotal
            }).ToList();

            gridDatosVentas.DataSource = listaVM;
        }
        private void frmHistorialVenta_Load(object sender, EventArgs e)
        {
            gridDatosVentas.ImplementarConfiguracion("Ver");
            gridDatosVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void btBuscarV_Click(object sender, EventArgs e)
        {
            await MostrarVenta();
        }

        private void gridDatosVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridDatosVentas.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var filaSeleccionada = (VentaVM)gridDatosVentas.CurrentRow.DataBoundItem;
                var _formDetalle = _serviceProvider.GetRequiredService<frmDetalleVenta>();
                _formDetalle._numeroVenta = filaSeleccionada.numeroVenta;
                _formDetalle.ShowDialog();
            }
        }
    }
}