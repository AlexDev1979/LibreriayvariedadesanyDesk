using LibreriayvariedadesanyDesk.Repository.DBConnection;
using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using Microsoft.Data.SqlClient;

namespace LibreriayvariedadesanyDeskRepository.Implementacion
{
    public class MedidaRepository : IMedidaRepository
    {
        private readonly Connection _conexion;

        public MedidaRepository(Connection conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Medida>> Lista()
        {
            List<Medida> lista = new List<Medida>();

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_UnidadMedida", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Medida
                        {
                            codigoMedida = Convert.ToInt32(dr["codigoMedida"]),
                            Nombre = dr["Nombre"].ToString(),
                            Abreviatura = dr["Abreviatura"].ToString(),
                            Equivalente = dr["Equivalente"].ToString(),
                            Valor = Convert.ToInt32(dr["valor"])
                        });
                    }
                }
            }
            return lista;
        }
    }
}