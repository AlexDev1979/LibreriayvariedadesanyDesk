

using System.ComponentModel;

namespace LibreriayvariedadesanyDeskPresentacion.VeiwModels
{
    public class DetalleFacturaCompraVM
    {
        public int codigoProducto { get; set; }
        public string Producto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int CantidadValor { get; set; }
        [DisplayName("Cantidad")]
        public string CantidadTexto { get; set; }
        public decimal TotalCompra { get; set; }
    }
}
