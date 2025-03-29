using System.ComponentModel;

namespace LibreriayvariedadesanyDeskPresentacion.VeiwModels
{
    public class DetalleventaVM
    {
        public int codigoProducto { get; set; }
        public string Producto { get; set; }
        public decimal Precio { get; set; }
        public int CantidadValor { get; set; }
        [DisplayName("Cantidad")]
        public string CantidadTexto { get; set; }
        public decimal Total    { get; set; }
    }
}
