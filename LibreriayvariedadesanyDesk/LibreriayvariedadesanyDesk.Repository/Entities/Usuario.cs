namespace LibreriayvariedadesanyDesk.Repository.Entities
{
    public class Usuario
    {
        public int codigoUsuario { get; set; }
        public Rol refRol { get; set; }
        public string nombreCompleto { get; set; }
        public string email { get; set; }
        public string nombreUsuario { get; set; }
        public string clave { get; set; }
        public int resetearClave { get; set; }
        public int Estado { get; set; }
    }
}