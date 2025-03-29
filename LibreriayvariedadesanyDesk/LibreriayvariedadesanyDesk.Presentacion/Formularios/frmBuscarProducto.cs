using LibreriayvariedadesanyDeskPresentacion.VeiwModels;
using LibreriayvariedadesanyDeskServices.Interfaces;
using SVPresentation.Utilidades;
using System.Data;

namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    public partial class frmBuscarProducto : Form
    {
        private readonly IProductoServices _productoServices;
        public ProductoVM _productoSeleccionado { get; set; } = null!;

        public frmBuscarProducto(IProductoServices productoServices)
        {
            InitializeComponent();
            _productoServices = productoServices;
        }

        private async Task MostrarProducto(string buscar = "")
        {
            var listaProducto = await _productoServices.Lista(buscar);
            var listaVM = listaProducto.
            Where(item => item.Estado == 1 && item.Cantidad > 0).
            Select(item => new ProductoVM
            {
                codigoProducto = item.codigoProducto,
                codigoCategoria = item.refCategoria.codigoCategoria,
                Codigo = item.Codigo,
                Categoria = item.refCategoria.nombre,
                descripcion = item.descripcion,
                precioCosto = item.precioCosto.ToString("0.00"),
                precioVenta = item.precioVenta.ToString("0.00"),
                Cantidad = item.Cantidad,
                //Estado = item.Estado,
                //Disponible = item.Estado == 1 ? "SI" : "NO"
            }).ToList();

            GridDatosProducto.DataSource = listaVM;

            GridDatosProducto.Columns["codigoProducto"].Visible = false;
            GridDatosProducto.Columns["codigoCategoria"].Visible = false;
            GridDatosProducto.Columns["Estado"].Visible = false;
            GridDatosProducto.Columns["Descripcion"].Width = 200;
        }

        private async void frmBuscarProducto_Load(object sender, EventArgs e)
        {
            GridDatosProducto.ImplementarConfiguracion();
            await MostrarProducto();
        }

        private async void btBuscar_Click(object sender, EventArgs e)
        {
            await MostrarProducto(tbBuscar.Text.Trim());
        }

        private void GridDatosProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _productoSeleccionado = (ProductoVM)GridDatosProducto.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}