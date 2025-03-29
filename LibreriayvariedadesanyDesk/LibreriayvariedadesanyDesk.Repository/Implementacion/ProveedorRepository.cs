using LibreriayvariedadesanyDesk.Repository.DBConnection;
using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LibreriayvariedadesanyDeskRepository.Implementacion
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly Connection _conexion;

        public ProveedorRepository(Connection conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Proveedor>> Lista(string buscar = "")
        {
            List<Proveedor> lista = new List<Proveedor>();

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_ListarProveedores", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Proveedor
                        {
                            codigoProveedor = Convert.ToInt32(dr["codigoProveedor"]),
                            nombreCompletoProveedor = dr["nombreCompletoProveedor"].ToString(),
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

        public async Task<string> Crear(Proveedor objeto)
        {
            string Respuesta = "";

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_crearProveedor", con);
                cmd.Parameters.AddWithValue("@nombreCompletoProveedor", objeto.nombreCompletoProveedor);
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

        public async Task<string> Editar(Proveedor objeto)
        {
            string Respuesta = "";

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarProveedor", con);
                cmd.Parameters.AddWithValue("@codigoProveedor", objeto.codigoProveedor);
                cmd.Parameters.AddWithValue("@nombreCompletoProveedor", objeto.nombreCompletoProveedor);
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

        public async Task<Proveedor> ObtenerNombrePorNit(string nit)
        {
            Proveedor proveedor = null!;

            using (var con = _conexion.ObtenerSQLConnection())
            {
                await con.OpenAsync();
                using (var cmd = new SqlCommand("sp_ObtenerNombreProveedor", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Se pasa el parámetro como string, sin conversión
                    cmd.Parameters.AddWithValue("@codigoProveedor", nit);

                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        if (await dr.ReadAsync())
                        {
                            proveedor = new Proveedor
                            {
                                // Se asigna codigoProveedor como string, sin conversión a int
                                codigoProveedor = Convert.ToInt32(dr["codigoProveedor"]),
                                nombreCompletoProveedor = dr["nombreCompletoProveedor"].ToString(),
                                nit = dr["nit"].ToString()
                            };
                        }
                    }
                }
            }
            return proveedor;
        }
    }
}