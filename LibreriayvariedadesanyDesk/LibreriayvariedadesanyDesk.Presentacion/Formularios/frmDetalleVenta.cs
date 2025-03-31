using LibreriayvariedadesanyDeskPresentacion.VeiwModels;
using LibreriayvariedadesanyDeskServices.Interfaces;
using SVPresentation.Utilidades;
using System.Diagnostics;

namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    public partial class frmDetalleVenta : Form
    {
        private readonly IVentaServices _ventaServices;
        private readonly INegocioServices _negocioServices;
        public string _numeroVenta { get; set; } = null!;

        public frmDetalleVenta(IVentaServices ventaServices, INegocioServices negocioServices)
        {
            InitializeComponent();
            _ventaServices = ventaServices;
            _negocioServices = negocioServices;
        }

        private async void btverPDF_Click(object sender, EventArgs e)
        {
            var oNegocio = await _negocioServices.Obtener();
            var oVenta = await _ventaServices.Obtener(_numeroVenta);
            var oDetalleVenta = await _ventaServices.ObtenerDetalle(_numeroVenta);
            oVenta.refdetalleVentas = oDetalleVenta;

            MemoryStream imagenLogo;
            using (var httpClient = new HttpClient())
            {
                var ImagenBytes = await httpClient.GetByteArrayAsync(oNegocio.urlLogo);
                imagenLogo = new MemoryStream(ImagenBytes);
            }

            var arrayPDF = GeneradorUtil.GeneratePDFVenta(oNegocio, oVenta, imagenLogo);

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar PDF";
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.AddExtension = true;
                saveFileDialog.FileName = $"{_numeroVenta}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    await File.WriteAllBytesAsync(saveFileDialog.FileName, arrayPDF);

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = saveFileDialog.FileName,
                        UseShellExecute = true
                    });
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void frmDetalleVenta_Load(object sender, EventArgs e)
        {
            GridDatosDetalleV.ImplementarConfiguracion();
            GridDatosDetalleV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var detalleVenta = await _ventaServices.ObtenerDetalle(_numeroVenta);

            var listaVM = detalleVenta.Select(item => new DetalleventaVM
            {
                Producto = item.refProducto.descripcion,
                Precio = item.precioVenta,
                CantidadTexto = string.Concat(item.cantidad, "", item.refProducto.refCategoria.refMedida.Equivalente),
                Total = item.precioTotal
            }).ToList();

            lbNumeroVenta.Text = _numeroVenta;

            GridDatosDetalleV.DataSource = listaVM;

            GridDatosDetalleV.Columns["codigoProducto"].Visible = false;
            GridDatosDetalleV.Columns["CantidadValor"].Visible = false;
        }
    }
}