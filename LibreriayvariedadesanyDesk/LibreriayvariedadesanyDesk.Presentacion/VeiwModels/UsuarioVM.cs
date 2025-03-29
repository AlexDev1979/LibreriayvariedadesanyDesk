using System.ComponentModel;

namespace LibreriayvariedadesanyDeskPresentacion.VeiwModels
{
    public class UsuarioVM
    {
        public int codigoUsuario { get; set; }
        public int codigoRol { get; set; }
        public string Rol { get; set; }
        [DisplayName("Nombre Completo")]
        public string nombreCompleto { get; set; }
        public string email { get; set; }
        [DisplayName ("Nombre Usuario")]
        public string nombreUsuario { get; set; }
        public int Activo { get; set; }
        public string Habilitado { get; set; }
    }
}
