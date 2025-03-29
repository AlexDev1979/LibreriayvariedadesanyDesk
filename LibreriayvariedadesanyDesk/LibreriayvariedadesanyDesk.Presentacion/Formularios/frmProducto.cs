using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskPresentacion.Utilidades;
using LibreriayvariedadesanyDeskPresentacion.Utilidades.Objetos;
using LibreriayvariedadesanyDeskPresentacion.VeiwModels;
using LibreriayvariedadesanyDeskServices.Interfaces;
using SVPresentation.Utilidades;
using System.Data;

namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    public partial class frmProducto : Form
    {
        private readonly ICategoriaServices _categoriaServices;
        private readonly IProductoServices _productoServices;

        public frmProducto(ICategoriaServices categoriaServices, IProductoServices productoServices)
        {
            InitializeComponent();
            _categoriaServices = categoriaServices;
            _productoServices = productoServices;
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

        private async Task MostrarProducto(string buscar = "")
        {
            var listaProducto = await _productoServices.Lista(buscar);
            var listaVM = listaProducto.Select(item => new ProductoVM
            {
                codigoProducto = item.codigoProducto,
                codigoCategoria = item.refCategoria.codigoCategoria,
                Codigo = item.Codigo,
                Categoria = item.refCategoria.nombre,
                descripcion = item.descripcion,
                precioCosto = item.precioCosto.ToString("0.00"),
                precioVenta = item.precioVenta.ToString("0.00"),
                Cantidad = item.Cantidad,
                Estado = item.Estado,
                Disponible = item.Estado == 1 ? "SI" : "NO"
            }).ToList();

            GridDatosProducto.DataSource = listaVM;

            GridDatosProducto.Columns["codigoProducto"].Visible = false;
            GridDatosProducto.Columns["codigoCategoria"].Visible = false;
            GridDatosProducto.Columns["Estado"].Visible = false;
            GridDatosProducto.Columns["Descripcion"].Width = 200;
        }

        private async void frmProducto_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            GridDatosProducto.ImplementarConfiguracion("Editar");
            tbPrecioCN.ValidarNumero();
            tbCostoVE.ValidarNumero();
            tbPrecioVN.ValidarNumero();
            tbPrecioVE.ValidarNumero();
            await MostrarProducto();

            OpcionCombo[] itemsHabilitados = new OpcionCombo[]
            {
                new OpcionCombo{ Texto = "SI", Valor = 1},
                new OpcionCombo{ Texto = "NO", Valor = 0},
            };
            var listaCategoria = await _categoriaServices.Lista();
            var items = listaCategoria.Where(item => item.estado == 1).Select(item => new OpcionCombo
            {
                Texto = item.nombre,
                Valor = item.codigoCategoria,
            }).ToArray();
            cbNuevoCategoria.InsertarItems(items);
            cbCategoriaE.InsertarItems(items);
            cbHabilitadoE.InsertarItems(itemsHabilitados);
        }

        private async void btBuscar_Click(object sender, EventArgs e)
        {
            await MostrarProducto(tbBuscar.Text);
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            MostrarTab(tabNuevo.Name);
            cbNuevoCategoria.SelectedIndex = 0;
            tbNuevoCodigo.Text = "";
            tbDescripcion.Text = "";
            tbPrecioCN.Text = "";
            tbPrecioVN.Text = "";
            NBNuevaCantidad.Value = 0;
            cbNuevoCategoria.Select();
        }

        private void btRegresarN_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btGuardarN_Click(object sender, EventArgs e)
        {
            if (tbNuevoCodigo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el codigo del producto");
                return;
            }

            if (tbDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la descripcion del producto");
                return;
            }
            if (tbPrecioCN.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el costo del producto");
                return;
            }
            if (tbPrecioVN.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el precio de venta del producto");
                return;
            }
            if (NBNuevaCantidad.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una cantidad");
                return;
            }
            decimal preciocosto = 0;
            decimal precioventa = 0;

            if (!decimal.TryParse(tbPrecioCN.Text, out preciocosto))
            {
                MessageBox.Show("Precio costo - Formato de moneda incorrecto", "Mensaje de sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbPrecioCN.Select();
                return;
            }
            if (!decimal.TryParse(tbPrecioVN.Text, out precioventa))
            {
                MessageBox.Show("Precio venta - Formato de moneda incorrecto", "Mensaje de sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbPrecioVN.Select();
                return;
            }
            var objeto = new Producto
            {
                refCategoria = new Categoria { codigoCategoria = ((OpcionCombo)cbNuevoCategoria.SelectedItem!).Valor },
                Codigo = tbNuevoCodigo.Text.Trim(),
                descripcion = tbDescripcion.Text.Trim(),
                precioCosto = preciocosto,
                precioVenta = precioventa,
                Cantidad = Convert.ToInt32(NBNuevaCantidad.Value)
            };

            var respuesta = await _productoServices.Crear(objeto);
            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarProducto();
                MostrarTab(tabLista.Name);
            }
        }

        private void GridDatosProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridDatosProducto.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var productoSeleccionado = (ProductoVM)GridDatosProducto.CurrentRow.DataBoundItem;
                cbCategoriaE.EstablecerValor(productoSeleccionado.codigoCategoria);
                cbCodigoE.Text = productoSeleccionado.Codigo;
                tbDescripcionE.Text = productoSeleccionado.descripcion;
                tbCostoVE.Text = productoSeleccionado.precioCosto;
                tbPrecioVE.Text = productoSeleccionado.precioVenta;
                NBNuevaCantidad.Value = productoSeleccionado.Cantidad;
                cbHabilitadoE.EstablecerValor(productoSeleccionado.Estado);
                MostrarTab(tabEditar.Name);
                cbCategoriaE.Select();
            }
        }

        private void btREgresarE_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {
            if (cbCodigoE.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el codigo del producto");
                return;
            }

            if (tbDescripcionE.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la descripcion del producto");
                return;
            }
            if (tbCostoVE.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el costo del producto");
                return;
            }
            if (tbPrecioVE.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el precio de venta del producto");
                return;
            }
            if (NBCantidadE.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar una cantidad");
                return;
            }
            decimal preciocosto = 0;
            decimal precioventa = 0;

            if (!decimal.TryParse(tbCostoVE.Text, out preciocosto))
            {
                MessageBox.Show("Precio costo - Formato de moneda incorrecto", "Mensaje de sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbCostoVE.Select();
                return;
            }
            if (!decimal.TryParse(tbPrecioVE.Text, out precioventa))
            {
                MessageBox.Show("Precio venta - Formato de moneda incorrecto", "Mensaje de sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbPrecioVE.Select();
                return;
            }
            var productoSeleccionado = (ProductoVM)GridDatosProducto.CurrentRow.DataBoundItem;
            var objeto = new Producto
            {
                codigoProducto = productoSeleccionado.codigoProducto,
                refCategoria = new Categoria { codigoCategoria = ((OpcionCombo)cbCategoriaE.SelectedItem!).Valor },
                Codigo = cbCodigoE.Text.Trim(),
                descripcion = tbDescripcionE.Text.Trim(),
                precioCosto = preciocosto,
                precioVenta = precioventa,
                Cantidad = Convert.ToInt32(NBCantidadE.Value),
                Estado = ((OpcionCombo)cbHabilitadoE.SelectedItem!).Valor
            };

            var respuesta = await _productoServices.Editar(objeto);
            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarProducto();
                MostrarTab(tabLista.Name);
            }
        }
    }
}