using System.ComponentModel;

namespace LibreriayvariedadesanyDeskPresentacion.VeiwModels
{
    public class ProveedorVM
    {
        public int codigoProveedor { get; set; }
        [DisplayName("Nombre Proveedor")]
        public string? nombreProveedor { get; set; }
        public string? nit { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public int Activo { get; set; }
        public string Habilitado { get; set; }
    }
}
