using LibreriayvariedadesanyDesk.Repository.DBConnection;
using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LibreriayvariedadesanyDeskRepository.Implementacion
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly Connection _conexion;

        public ClienteRepository(Connection conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Clientes>> Lista(string buscar = "")
        {
            List<Clientes> lista = new List<Clientes>();

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_ListarClientes", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Clientes
                        {
                            codigoCliente = Convert.ToInt32(dr["codigoCliente"]),
                            nombreCompletoCliente = dr["nombreCompletoCliente"].ToString(),
                            nit = dr["nit"].ToString(),
                            telefono = dr["telefono"].ToString(),
                            direccion = dr["direccion"].ToString(),
                            estado = Convert.ToInt32(dr["estado"]),
                            email = dr["email"].ToString()
                        });
                    }
                }
            }
            return lista;
        }

        public async Task<string> Crear(Clientes objeto)
        {
            string Respuesta = "";

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_crearCliente", con);
                cmd.Parameters.AddWithValue("@nombreCompletoCliente", objeto.nombreCompletoCliente);
                cmd.Parameters.AddWithValue("@nit", objeto.nit);
                cmd.Parameters.AddWithValue("@telefono", objeto.telefono);
                cmd.Parameters.AddWithValue("@direccion", objeto.direccion);
                cmd.Parameters.AddWithValue("@estado", objeto.estado);
                cmd.Parameters.AddWithValue("@email", objeto.email);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 128).Direction = ParameterDirection.Output;
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

        public async Task<string> Editar(Clientes objeto)
        {
            string Respuesta = "";

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarCliente", con);
                cmd.Parameters.AddWithValue("@codigoCliente", objeto.codigoCliente);
                cmd.Parameters.AddWithValue("@nombreCompletoCliente", objeto.nombreCompletoCliente);
                cmd.Parameters.AddWithValue("@nit", objeto.nit);
                cmd.Parameters.AddWithValue("@telefono", objeto.telefono);
                cmd.Parameters.AddWithValue("@direccion", objeto.direccion);
                cmd.Parameters.AddWithValue("@estado", objeto.estado);
                cmd.Parameters.AddWithValue("@email", objeto.email);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 128).Direction = ParameterDirection.Output;
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