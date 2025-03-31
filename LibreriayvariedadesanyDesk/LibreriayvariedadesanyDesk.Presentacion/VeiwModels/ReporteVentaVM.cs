using System.ComponentModel;

namespace LibreriayvariedadesanyDeskPresentacion.VeiwModels
{
    public class ReporteVentaVM
    {
        [DisplayName("Numero Venta")]
        public string numeroventa { get; set; }

        [DisplayName("Nombre Usuario")]
        public string nombreUsuario { get; set; }

        [DisplayName("Fecha Registro")]
        public string fechaRegistro { get; set; }

        public string Producto { get; set; }

        [DisplayName("Precio Costo")]
        public decimal precioCosto { get; set; }

        [DisplayName("Precio Venta")]
        public decimal precioventa { get; set; }

        public int cantidad { get; set; }

        [DisplayName("Precio Total")]
        public decimal precioTotal { get; set; }

    }
}