using LibreriayvariedadesanyDesk.Repository.DBConnection;
using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using Microsoft.Data.SqlClient;

namespace LibreriayvariedadesanyDeskRepository.Implementacion
{
    public class RolRepository : IRolRepository
    {
        private readonly Connection _conexion;

        public RolRepository(Connection conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Rol>> Lista()
        {
            List<Rol> lista = new List<Rol>();

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaRol", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Rol
                        {
                            codigoRol = Convert.ToInt32(dr["codigoRol"]),
                            Nombre = dr["Nombre"].ToString()!
                        });
                    }
                }
            }
            return lista;
        }
    }
}