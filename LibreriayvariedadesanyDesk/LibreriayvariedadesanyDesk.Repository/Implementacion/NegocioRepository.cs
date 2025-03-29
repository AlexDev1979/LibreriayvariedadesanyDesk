using LibreriayvariedadesanyDesk.Repository.DBConnection;
using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LibreriayvariedadesanyDeskRepository.Implementacion
{
    public class NegocioRepository : INegocioRepository
    {
        private readonly Connection _conexion;

        public NegocioRepository(Connection conexion)
        {
            _conexion = conexion;
        }

        public async Task<Negocio> Obtener()
        {
            Negocio objeto = new Negocio();

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_obtenerNegocio", con);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        objeto = new Negocio()
                        {
                            razonSocial = dr["razonSocial"].ToString(),
                            nit = dr["nit"].ToString(),
                            direccion = dr["direccion"].ToString(),
                            telefono = dr["telefono"].ToString(),
                            email = dr["email"].ToString(),
                            simboloMoneda = dr["simboloMoneda"].ToString(),
                            nombreLogo = dr["nombreLogo"].ToString(),
                            urlLogo = dr["urlLogo"].ToString()
                        };
                    }
                }
            }
            return objeto;
        }

        public async Task Editar(Negocio objeto)
        {
            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarNegocio", con);
                cmd.Parameters.AddWithValue("@razonSocial", objeto.razonSocial);
                cmd.Parameters.AddWithValue("@nit", objeto.nit);
                cmd.Parameters.AddWithValue("@direccion", objeto.direccion);
                cmd.Parameters.AddWithValue("@telefono", objeto.telefono);
                cmd.Parameters.AddWithValue("@email", objeto.email);
                cmd.Parameters.AddWithValue("@simboloMoneda", objeto.simboloMoneda);
                cmd.Parameters.AddWithValue("@nombreLogo", objeto.nombreLogo);
                cmd.Parameters.AddWithValue("@urlLogo", objeto.urlLogo);
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    await cmd.ExecuteNonQueryAsync();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}