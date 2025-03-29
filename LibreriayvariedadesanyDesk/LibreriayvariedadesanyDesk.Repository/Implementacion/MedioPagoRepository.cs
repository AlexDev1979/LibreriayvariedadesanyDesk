using LibreriayvariedadesanyDesk.Repository.DBConnection;
using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using Microsoft.Data.SqlClient;

namespace LibreriayvariedadesanyDeskRepository.Implementacion
{
    public class MedioPagoRepository : IMedioPagoRepository
    {
        private readonly Connection _conexion;

        public MedioPagoRepository(Connection conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<MedioPago>> Lista()
        {
            List<MedioPago> lista = new List<MedioPago>();

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaMedioPago", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new MedioPago
                        {
                            codigoMedioPago = Convert.ToInt32(dr["codigoMedioPago"]),
                            descripcion = dr["descripcion"].ToString()!
                        });
                    }
                }
            }
            return lista;
        }

        public async Task<MedioPago> Obtener(string descripcion)
        {
            MedioPago objeto = new MedioPago();

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_obtenerMedioPago", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@codigoMedioPago", descripcion);
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        objeto = new MedioPago
                        {
                            codigoMedioPago = Convert.ToInt32(dr["codigoMedioPago"]),
                            descripcion = dr["descripcion"].ToString()!
                        };
                    }
                }
            }
            return objeto;
        }
    }
}