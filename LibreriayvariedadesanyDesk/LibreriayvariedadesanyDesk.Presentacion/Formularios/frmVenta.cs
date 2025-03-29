using LibreriayvariedadesanyDeskPresentacion.Utilidades;
using LibreriayvariedadesanyDeskPresentacion.VeiwModels;
using LibreriayvariedadesanyDeskServices.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using SVPresentation.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LibreriayvariedadesanyDeskPresentacion.Formularios
{
    public partial class frmVenta : Form
    {
        private readonly IProductoServices _ProductoServices;
        private readonly IVentaServices _ventaServices;
        private readonly INegocioServices _negocioServices;
        private readonly IServiceProvider _serviceProvider;
        private readonly IMedioPagoServices _medioPagoServices;
        private BindingList<DetalleventaVM> _detalleVentas = new BindingList<DetalleventaVM>();
        public String codMedioPago = "";
        public frmVenta(IProductoServices productoServices, IVentaServices ventaServices, INegocioServices negocioServices, IServiceProvider serviceProvider, IMedioPagoServices medioPagoServices)
        {
            InitializeComponent();
            _ProductoServices = productoServices;
            _ventaServices = ventaServices;
            _serviceProvider = serviceProvider;
            _negocioServices = negocioServices;
            _medioPagoServices = medioPagoServices;
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            GridDventas.ImplementarConfiguracion("Eliminar");
            GridDventas.DataSource = _detalleVentas;
            GridDventas.Columns["codigoProducto"].Visible = false;
            GridDventas.Columns["cantidadValor"].Visible = false;
            GridDventas.Columns["producto"].FillWeight = 350;
            GridDventas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            tbPagocon.ValidarNumero();
        }
        private async Task AgregarProducto(string codigoProducto)
        {
            try
            {
                var producto = await _ProductoServices.Obtener(codigoProducto);
                if (producto.codigoProducto == 0)
                {
                    tbCodigoProducto.BackColor = Color.FromArgb(255, 227, 227);
                    return;
                }

                tbCodigoProducto.BackColor = SystemColors.Window;

                StringBuilder sb = new StringBuilder();
                sb.AppendLine(producto.descripcion);
                sb.AppendLine("Categoria:" + producto.refCategoria.nombre);
                sb.AppendLine("Precio:" + producto.precioVenta.ToString("0.00"));
                sb.AppendLine();
                sb.AppendLine("Ingresar la cantidad (" + producto.refCategoria.refMedida.Equivalente + ");");

                string stringCantidad = Interaction.InputBox(sb.ToString(), "Producto", "1");

                if (string.IsNullOrEmpty(stringCantidad)) return;

                if (!int.TryParse(stringCantidad, out int cantidad))
                {
                    MessageBox.Show("El valor ingresado no es un número válido");
                    return;
                }

                if (cantidad > producto.Cantidad)
                {
                    MessageBox.Show("La cantidad ingresada excede el stock");
                    return;
                }

                var encontrado = _detalleVentas.FirstOrDefault(x => x.codigoProducto == producto.codigoProducto);

                if (encontrado == null)
                {
                    decimal Total = (cantidad * producto.precioVenta) / producto.refCategoria.refMedida.Valor;

                    _detalleVentas.Add(new DetalleventaVM
                    {
                        codigoProducto = producto.codigoProducto,
                        Producto = producto.descripcion,
                        Precio = producto.precioVenta,
                        CantidadValor = cantidad,
                        CantidadTexto = string.Concat(cantidad, " ", producto.refCategoria.refMedida.Equivalente),
                        Total = Convert.ToDecimal(Total.ToString("0.00")),
                    });
                }
                else
                {
                    int index = _detalleVentas.IndexOf(encontrado);
                    int cantidadTotal = encontrado.CantidadValor + cantidad;
                    decimal Total = (cantidadTotal * producto.precioVenta) / producto.refCategoria.refMedida.Valor;

                    encontrado.CantidadValor = cantidadTotal;
                    encontrado.CantidadTexto = string.Concat(cantidadTotal, "  ", producto.refCategoria.refMedida.Equivalente);
                    encontrado.Total = Convert.ToDecimal(Total.ToString("0.00"));
                    _detalleVentas[index] = encontrado;
                }

                decimal total = _detalleVentas.Sum(x => x.Total);

                lbtotal.Text = total.ToString("0.00");
                tbCodigoProducto.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private async Task AgregarMedioPago(string codigoMedioPago)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(codigoMedioPago))
                {
                    MessageBox.Show("El código del medio de pago no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var MedioPago = await _medioPagoServices.Obtener(codigoMedioPago);

                if (MedioPago == null)
                {
                    MessageBox.Show("No se encontró el medio de pago.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMedioPago.BackColor = Color.FromArgb(255, 227, 227);
                    return;
                }

                if (string.IsNullOrEmpty(MedioPago.descripcion))
                {
                    MessageBox.Show("El medio de pago no tiene una descripción válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbMedioPago.BackColor = Color.FromArgb(255, 227, 227);
                    return;
                }

                tbMedioPago.BackColor = SystemColors.Window;

                // Mostrar la descripción en el TextBox (si deseas que se muestre en otro lado, cámbialo)
                tbMedioPago.Text = MedioPago.descripcion;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar el medio de pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void tbCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                await AgregarProducto(tbCodigoProducto.Text.Trim());
            }
        }

        private async void btBuscar_Click(object sender, EventArgs e)
        {
            var frmbuscarProducto = _serviceProvider.GetRequiredService<frmBuscarProducto>();
            var resultado = frmbuscarProducto.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                var productoSeleccionado = frmbuscarProducto._productoSeleccionado;
                tbCodigoProducto.Text = productoSeleccionado.Codigo;
                await AgregarProducto(productoSeleccionado.Codigo);
            }
        }

        private void GridDventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridDventas.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var filaSeleccionada = (DetalleventaVM)GridDventas.CurrentRow.DataBoundItem;

                var index = _detalleVentas.IndexOf(filaSeleccionada);
                _detalleVentas.RemoveAt(index);

                decimal total = _detalleVentas.Sum(x => x.Total);

                lbtotal.Text = total.ToString("0.00");
            }
        }

        private async void btRegistrarNV_Click(object sender, EventArgs e)
        {
            if (_detalleVentas.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(tbMedioPago.Text.Trim()))
                {
                    MessageBox.Show("El medio de pago no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int codigoMedioPago = Convert.ToInt32(codMedioPago);   //codMedio pago variabl que trae el codigo

                //medioPagoSeleccionado.codigoMedioPago.ToString()

                // if (!int.TryParse(tbMedioPago.Text.Trim(), out codigoMedioPago))
                if (codigoMedioPago == 0)

                {
                    MessageBox.Show("El medio de pago debe ser un número válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calcular el total de la venta
                decimal temtotal = _detalleVentas.Sum(x => x.Total);
                var precioTotal = Convert.ToDecimal(temtotal.ToString("0.00"));
                var pagoCon = string.IsNullOrEmpty(tbPagocon.Text.Trim()) ? precioTotal : Convert.ToDecimal(tbPagocon.Text.Trim());
                var cambio = string.IsNullOrEmpty(tbCambio.Text.Trim()) ? 0 : Convert.ToDecimal(tbCambio.Text.Trim());
                //var medioPago = await _medioPagoServices.Obtener(tbMedioPago.Text.Trim());
                //if (medioPago == null)
                //{
                //    MessageBox.Show("El medio de pago seleccionado no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}


                // Crear el elemento XML para la venta
                XElement venta = new XElement("venta",
                    new XElement("codigoUsuarioRegistro", 2), // Cambiar según corresponda
                    new XElement("Nit", tbNit.Text.Trim()),
                    new XElement("nombreCliente", tbCliente.Text.Trim()),
                    new XElement("precioTotal", precioTotal),
                    new XElement("PagoCon", pagoCon),
                    new XElement("cambio", cambio),
                    new XElement("codigoMedioPago", codigoMedioPago)// Asegúrate de que este valor no sea nulo


                );

                XElement detalleVenta = new XElement("detalleVenta");

                foreach (DetalleventaVM item in _detalleVentas)
                {
                    detalleVenta.Add(new XElement("Item",
                        new XElement("codigoProducto", item.codigoProducto),
                        new XElement("Cantidad", item.CantidadValor),
                        new XElement("precioVenta", item.Precio),
                        new XElement("precioTotal", item.Total)
                    ));
                }

                venta.Add(detalleVenta);

                // Registrar la venta
                var numeroVenta = await _ventaServices.Registrar(venta.ToString());

                if (string.IsNullOrEmpty(numeroVenta))
                {
                    MessageBox.Show("No se pudo generar la venta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Limpiar formulario y preparar para nueva venta
                tbCodigoProducto.Text = "";
                tbNit.Text = "";
                tbCliente.Text = "";
                _detalleVentas.Clear();
                lbtotal.Text = "0";
                tbPagocon.Text = "";
                tbCambio.Text = "";
                tbCodigoProducto.Select();

                // Preguntar si desea guardar el documento PDF
                DialogResult resultado = MessageBox.Show(
                    $"Número venta: {numeroVenta}, ¿Desea visualizar y guardar el documento?",
                    "Venta registrada correctamente",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (resultado == DialogResult.Yes)
                {
                    var oNegocio = await _negocioServices.Obtener();
                    var oVenta = await _ventaServices.Obtener(numeroVenta);
                    var oDetalleVenta = await _ventaServices.ObtenerDetalle(numeroVenta);
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
                        saveFileDialog.FileName = $"{numeroVenta}";

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la venta: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbPagocon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.Enter)
                return;

            if (decimal.TryParse(tbPagocon.Text.Trim(), out decimal pagoCon))
            {
                decimal Total = _detalleVentas.Sum(x => x.Total);

                if (pagoCon < Total)
                {
                    tbPagocon.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagoCon - Total;
                    tbCambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private async void btBuscarMP_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el formulario de búsqueda de medio de pago
                var frmbuscarMedioPago = _serviceProvider.GetRequiredService<frmBuscarMedioPago>();

                // Mostrar el formulario de búsqueda
                var resultado = frmbuscarMedioPago.ShowDialog();

                // Validar la selección del medio de pago
                if (resultado == DialogResult.OK && frmbuscarMedioPago._medioPagoSeleccionado != null)
                {
                    var medioPagoSeleccionado = frmbuscarMedioPago._medioPagoSeleccionado;

                    codMedioPago = medioPagoSeleccionado.codigoMedioPago.ToString();
                    // Actualizar el TextBox con el código del medio de pago
                    tbMedioPago.Text = codMedioPago;

                    // Agregar el medio de pago seleccionado
                    await AgregarMedioPago(medioPagoSeleccionado.codigoMedioPago.ToString()).ConfigureAwait(false);
                }
                else if (resultado == DialogResult.OK && frmbuscarMedioPago._medioPagoSeleccionado == null)
                {
                    MessageBox.Show("No se seleccionó ningún medio de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Manejar errores y mostrar un mensaje al usuario
                MessageBox.Show($"Ocurrió un error al buscar el medio de pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
