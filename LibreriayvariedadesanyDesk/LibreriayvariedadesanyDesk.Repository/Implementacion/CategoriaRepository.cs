using LibreriayvariedadesanyDesk.Repository.DBConnection;
using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LibreriayvariedadesanyDeskRepository.Implementacion
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly Connection _conexion;

        public CategoriaRepository(Connection conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Categoria>> Lista(string buscar = "")
        {
            List<Categoria> lista = new List<Categoria>();

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaCategoria", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Categoria
                        {
                            codigoCategoria = Convert.ToInt32(dr["codigoCategoria"]),
                            nombre = dr["nombre"].ToString(),
                            estado = Convert.ToInt32(dr["estado"]),
                            refMedida = new Medida
                            {
                                codigoMedida = Convert.ToInt32(dr["codigoMedida"]),
                                Nombre = dr["nombreMedida"].ToString()
                            }
                        });
                    }
                }
            }
            return lista;
        }

        public async Task<string> Crear(Categoria objeto)
        {
            string Respuesta = "";

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_crearCategoria", con);
                cmd.Parameters.AddWithValue("@Nombre", objeto.nombre);
                cmd.Parameters.AddWithValue("@codigoMedida", objeto.refMedida.codigoMedida);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    Respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch
                {
                    Respuesta = "Error(rp): no se pudo completar la operacion";
                }
            }
            return Respuesta;
        }

        public async Task<string> Editar(Categoria objeto)
        {
            string Respuesta = "";

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarCategoria", con);
                cmd.Parameters.AddWithValue("@codigoCategoria", objeto.codigoCategoria);
                cmd.Parameters.AddWithValue("@Nombre", objeto.nombre);
                cmd.Parameters.AddWithValue("@codigoMedida", objeto.refMedida.codigoMedida);
                cmd.Parameters.AddWithValue("@Estado", objeto.estado);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    Respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch
                {
                    Respuesta = "Error(rp): no se pudo completar la operacion";
                }
            }
            return Respuesta;
        }
    }
}