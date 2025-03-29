namespace LibreriayvariedadesanyDesk.Repository.Entities
{
    public class Clientes
    {
        public int codigoCliente { get; set; }
        public string nombreCompletoCliente { get; set; }
        public string nit { get; set; }
        public string? telefono { get; set; }
        public string? direccion { get; set; }
        public string? email { get; set; }
        public int estado { get; set; }
    }
}