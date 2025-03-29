using LibreriayvariedadesanyDesk.Repository.DBConnection;
using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LibreriayvariedadesanyDeskRepository.Implementacion
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Connection _conexion;

        public UsuarioRepository(Connection conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Usuario>> Lista(string buscar = "")
        {
            List<Usuario> lista = new List<Usuario>();

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaUsuario", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Usuario
                        {
                            codigoUsuario = Convert.ToInt32(dr["codigoUsuario"]),
                            refRol = new Rol
                            {
                                codigoRol = Convert.ToInt32(dr["codigoRol"]),
                                Nombre = dr["NombreRol"].ToString()
                            },
                            nombreCompleto = dr["nombreCompleto"].ToString(),
                            email = dr["email"].ToString(),
                            nombreUsuario = dr["nombreUsuario"].ToString(),
                            Estado = Convert.ToInt32(dr["estado"])
                        });
                    }
                }
            }
            return lista;
        }

        public async Task<string> Crear(Usuario objeto)
        {
            string Respuesta = "";

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_crearUsuario", con);
                cmd.Parameters.AddWithValue("@codigoRol", objeto.refRol.codigoRol);
                cmd.Parameters.AddWithValue("@nombreCompleto", objeto.nombreCompleto);
                cmd.Parameters.AddWithValue("@email", objeto.email);
                cmd.Parameters.AddWithValue("@nombreUsuario", objeto.nombreUsuario);
                cmd.Parameters.AddWithValue("@clave", objeto.clave);
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

        public async Task<string> Editar(Usuario objeto)
        {
            string Respuesta = "";

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarUsuario", con);
                cmd.Parameters.AddWithValue("@codigoUsuario", objeto.codigoUsuario);
                cmd.Parameters.AddWithValue("@codigoRol", objeto.refRol.codigoRol);
                cmd.Parameters.AddWithValue("@nombreCompleto", objeto.nombreCompleto);
                cmd.Parameters.AddWithValue("@email", objeto.email);
                cmd.Parameters.AddWithValue("@nombreUsuario", objeto.nombreUsuario);
                cmd.Parameters.AddWithValue("@Estado", objeto.Estado);
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