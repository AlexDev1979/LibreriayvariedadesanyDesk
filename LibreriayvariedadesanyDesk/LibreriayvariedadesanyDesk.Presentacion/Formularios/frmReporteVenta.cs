using ClosedXML.Excel;
using LibreriayvariedadesanyDeskPresentacion.VeiwModels;
using LibreriayvariedadesanyDeskServices.Interfaces;
using SVPresentation.Utilidades;
using System.Data;

namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    public partial class frmReporteVenta : Form
    {
        private readonly IVentaServices _ventaServices;

        public frmReporteVenta(IVentaServices ventaServices)
        {
            InitializeComponent();
            _ventaServices = ventaServices;
        }

        private void frmReporteVenta_Load(object sender, EventArgs e)
        {
            gridDatosReporte.ImplementarConfiguracion();
        }

        private async void btBuscarV_Click(object sender, EventArgs e)
        {
            var lista = await _ventaServices.Reporte(
                dtFechaInicio.Value.ToString("dd/MM/yyyy"),
                dtFechaFinal.Value.ToString("dd/MM/yyyy")
            );
            var listaVM = lista.Select(item => new ReporteVentaVM
            {
                numeroventa = item.refVenta.numeroVenta,
                nombreUsuario = item.refVenta.UsuarioRegistro.nombreUsuario,
                fechaRegistro = item.refVenta.fechaRegistro,
                Producto = item.refProducto.descripcion,
                precioCosto = item.refProducto.precioCosto,
                precioventa = item.precioVenta,
                cantidad = item.cantidad,
                precioTotal = item.precioTotal,
            }).ToList();
            gridDatosReporte.DataSource = listaVM;
        }

        private void btExcel_Click(object sender, EventArgs e)
        {
            if (gridDatosReporte.Rows.Count == 0)
            {
                MessageBox.Show("No existen registros para mostrar");
                return;
            }

            DataTable dataTable = new DataTable();
            List<ReporteVentaVM> detalle = (List<ReporteVentaVM>)gridDatosReporte.DataSource;

            // Definir manualmente las columnas necesarias
            dataTable.Columns.Add("Numero Venta", typeof(string));
            dataTable.Columns.Add("Nombre Usuario", typeof(string));
            dataTable.Columns.Add("Fecha Registro", typeof(string));
            dataTable.Columns.Add("Producto", typeof(string));
            dataTable.Columns.Add("Precio Costo", typeof(decimal));
            dataTable.Columns.Add("Precio Venta", typeof(decimal));
            dataTable.Columns.Add("Cantidad", typeof(int));
            dataTable.Columns.Add("Precio Total", typeof(decimal));


            foreach (var item in detalle)
            {
                dataTable.Rows.Add(
                    item.numeroventa,
                    item.nombreUsuario,
                    item.fechaRegistro,
                    item.Producto,
                    item.precioCosto,
                    item.precioventa,
                    item.cantidad,
                    item.precioTotal
                );
            }

            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.FileName = $"ReporteVentas_{DateTime.Now:ddMMyyyyHHmmss}.xlsx";
                saveFile.Filter = "Excel files|*.xlsx";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dataTable, "Reporte");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte generado con éxito", "Mensaje", MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar el reporte", "Mensaje", MessageBoxButtons.OK, 
                            MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}