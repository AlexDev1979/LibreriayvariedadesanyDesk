using System.ComponentModel;

namespace LibreriayvariedadesanyDeskPresentacion.VeiwModels
{
    public class ProductoVM
    {
        public int codigoProducto { get; set; }
        public int codigoCategoria { get; set; }
        public string Categoria { get; set; }
        public string Codigo { get; set; }
        public string descripcion { get; set; }

        [DisplayName("Precio Costo")]
        public string precioCosto { get; set; }

        [DisplayName("Precio Venta  ")]
        public string precioVenta { get; set; }

        public int Cantidad { get; set; }
        public int Estado { get; set; }
        public string Disponible { get; set; }
    }
}