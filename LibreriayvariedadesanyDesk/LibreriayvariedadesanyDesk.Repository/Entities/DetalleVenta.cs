namespace LibreriayvariedadesanyDesk.Repository.Entities
{
    public class DetalleVenta
    {
        public int codigoDetalleVenta { get; set; }
        public int codigoVenta { get; set; }
        public Venta refVenta { get; set; }
        public Producto refProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precioVenta { get; set; }
        public decimal precioTotal { get; set; }
    }
}