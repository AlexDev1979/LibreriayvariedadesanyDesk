namespace LibreriayvariedadesanyDesk.Repository.Entities
{
    public class Producto
    {
        public int codigoProducto { get; set; }
        public Categoria refCategoria { get; set; }
        public string Codigo { get; set; }
        public string descripcion { get; set; }
        public decimal precioCosto { get; set; }
        public decimal precioVenta { get; set; }
        public int Cantidad { get; set; }
        public int Estado { get; set; }
        public string nuevoPrecio { get; set; }
    }
}