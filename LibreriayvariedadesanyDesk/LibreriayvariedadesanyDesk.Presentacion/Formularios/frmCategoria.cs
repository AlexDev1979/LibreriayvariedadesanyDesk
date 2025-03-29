using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskPresentacion.Utilidades.Objetos;
using LibreriayvariedadesanyDeskPresentacion.VeiwModels;
using LibreriayvariedadesanyDeskServices.Interfaces;
using SVPresentation.Utilidades;
using System.Data;

namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    public partial class frmCategoria : Form
    {
        private readonly ICategoriaServices _categoriaServices;
        private readonly IMedidaServices _medidaServices;

        public frmCategoria(ICategoriaServices categoriaServices, IMedidaServices medidaServices)
        {
            InitializeComponent();
            _categoriaServices = categoriaServices;
            _medidaServices = medidaServices;
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

        private async Task MostrarCategoria(string buscar = "")
        {
            var listaCategorias = await _categoriaServices.Lista(buscar);
            var listaVM = listaCategorias.Select(item => new CategoriaVM
            {
                codigoCategoria = item.codigoCategoria,
                nombre = item.nombre,
                codigoMedida = item.refMedida.codigoMedida,
                Medida = item.refMedida.Nombre,
                Activo = item.estado,
                Habilidado = item.estado == 1 ? "SI" : "NO"
            }).ToList();

            GridDatosCategoria.DataSource = listaVM;

            GridDatosCategoria.Columns["codigoCategoria"].Visible = false;
            GridDatosCategoria.Columns["codigoMedida"].Visible = false;
            GridDatosCategoria.Columns["Activo"].Visible = false;
        }

        private async void frmCategoria_Load(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
            GridDatosCategoria.ImplementarConfiguracion("Editar");
            GridDatosCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            await MostrarCategoria();

            OpcionCombo[] itemsHabilitados = new OpcionCombo[]
            {
                new OpcionCombo{ Texto = "SI", Valor = 1},
                new OpcionCombo{ Texto = "NO", Valor = 0},
            };
            var listaMedida = await _medidaServices.Lista();
            var items = listaMedida.Select(item => new OpcionCombo
            {
                Texto = item.Nombre,
                Valor = item.codigoMedida,
            }).ToArray();
            cbNuevo.InsertarItems(items);
            cbMedidaEditar.InsertarItems(items);
            cbHabilitadoE.InsertarItems(itemsHabilitados);
        }

        private async void btBuscar_Click(object sender, EventArgs e)
        {
            await MostrarCategoria(tbBuscar.Text);
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            tbNuevo.Text = "";
            cbNuevo.SelectedIndex = 0;
            tbNuevo.Select();
            MostrarTab(tabNuevo.Name);
        }

        private void btRegresarN_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btGuardarN_Click(object sender, EventArgs e)
        {
            if (tbNuevo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el nombre de la categoria que desea guardar");
                return;
            }
            var item = (OpcionCombo)cbNuevo.SelectedItem!;
            var objeto = new Categoria
            {
                nombre = tbNuevo.Text.Trim(),
                refMedida = new Medida { codigoMedida = item.Valor }
            };
            var respuesta = await _categoriaServices.Crear(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarCategoria();
                MostrarTab(tabLista.Name);
            }
        }

        private void GridDatosCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridDatosCategoria.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var categoriaSeleccionada = (CategoriaVM)GridDatosCategoria.CurrentRow.DataBoundItem;
                tbEditarNombre.Text = categoriaSeleccionada.nombre.ToString();
                cbMedidaEditar.EstablecerValor(categoriaSeleccionada.codigoMedida);
                cbHabilitadoE.EstablecerValor(categoriaSeleccionada.Activo);
                MostrarTab(tabEditar.Name);
                tbEditarNombre.Select();
            }
        }

        private void btREgresarE_Click(object sender, EventArgs e)
        {
            MostrarTab(tabLista.Name);
        }

        private async void btEditar_Click(object sender, EventArgs e)
        {
            if (tbEditarNombre.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el nombre de la categoria que desea guardar");
                return;
            }
            var categoriaSeleccionada = (CategoriaVM)GridDatosCategoria.CurrentRow.DataBoundItem;
            var objeto = new Categoria
            {
                codigoCategoria = categoriaSeleccionada.codigoCategoria,
                nombre = tbEditarNombre.Text.Trim(),
                refMedida = new Medida { codigoMedida = ((OpcionCombo)cbMedidaEditar.SelectedItem!).Valor },
                estado = ((OpcionCombo)cbHabilitadoE.SelectedItem!).Valor,
            };
            var respuesta = await _categoriaServices.Editar(objeto);

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarCategoria();
                MostrarTab(tabLista.Name);
            }
        }
    }
}