using System.ComponentModel;

namespace LibreriayvariedadesanyDeskPresentacion.VeiwModels
{
    public class ClienteVM
    {
        public int codigoCliente { get; set; }

        [DisplayName("Nombre Cliente")]
        public string nombreCliente { get; set; }

        public string nit { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public int Activo { get; set; }
        public string Habilitado { get; set; }
    }
}