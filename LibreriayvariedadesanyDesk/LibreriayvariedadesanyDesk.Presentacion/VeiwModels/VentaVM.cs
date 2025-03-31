using System.ComponentModel;

namespace LibreriayvariedadesanyDeskPresentacion.VeiwModels
{
    internal class VentaVM
    {
        [DisplayName ("FechaInicio")]
        public string fechaRegistro { get; set; }
        public string numeroVenta { get; set; }
        public string usuario { get; set; }
        public string cliente { get; set; }
        public decimal total { get; set; }
    }
}