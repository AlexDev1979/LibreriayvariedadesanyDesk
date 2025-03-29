namespace LibreriayvariedadesanyDesk.Repository.Entities
{
    public class Venta
    {
        public int codigoFacturaCompra { get; set; }
        public string numeroVenta { get; set; }
        public string Nit { get; set; }
        public Usuario UsuarioRegistro { get; set; }
        public string nombreCliente { get; set; }
        public decimal precioTotal { get; set; }
        public decimal PagoCon { get; set; }
        public decimal cambio { get; set; }
        public string fechaRegistro { get; set; }
        public int estado { get; set; }
        public MedioPago refMedioPago { get; set; }
        public List<DetalleVenta> refdetalleVentas { get; set; }
    }
}