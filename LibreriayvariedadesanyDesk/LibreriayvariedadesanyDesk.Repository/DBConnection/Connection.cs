using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace LibreriayvariedadesanyDesk.Repository.DBConnection
{
    public class Connection
    {
        private readonly IConfiguration _configuracion;
        private readonly string _cadenaSql;

        public Connection(IConfiguration configuracion)
        {
            _configuracion = configuracion;
            _cadenaSql = _configuracion.GetConnectionString("CadenaSql")!;
        }
        public SqlConnection ObtenerSQLConnection()
        {
            return new SqlConnection(_cadenaSql);
        }
    }
}