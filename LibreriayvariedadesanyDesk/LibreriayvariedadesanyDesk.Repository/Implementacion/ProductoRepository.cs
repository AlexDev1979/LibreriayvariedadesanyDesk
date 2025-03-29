using LibreriayvariedadesanyDesk.Repository.DBConnection;
using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LibreriayvariedadesanyDeskRepository.Implementacion
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly Connection _conexion;

        public ProductoRepository(Connection conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Producto>> Lista(string buscar = "")
        {
            List<Producto> lista = new List<Producto>();

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_listaProducto", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Buscar", buscar);
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        lista.Add(new Producto
                        {
                            codigoProducto = Convert.ToInt32(dr["codigoProducto"]),
                            refCategoria = new Categoria
                            {
                                codigoCategoria = Convert.ToInt32(dr["codigoCategoria"]),
                                nombre = dr["NombreCategoria"].ToString()
                            },
                            Codigo = dr["Codigo"].ToString(),
                            descripcion = dr["descripcion"].ToString(),
                            precioCosto = Convert.ToDecimal(dr["precioCosto"]),
                            precioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            Estado = Convert.ToInt32(dr["Estado"])
                        });
                    }
                }
            }
            return lista;
        }

        public async Task<string> Crear(Producto objeto)
        {
            string Respuesta = "";

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_crearProducto", con);
                cmd.Parameters.AddWithValue("@codigoCategoria", objeto.refCategoria.codigoCategoria);
                cmd.Parameters.AddWithValue("@Codigo", objeto.Codigo);
                cmd.Parameters.AddWithValue("@descripcion", objeto.descripcion);
                cmd.Parameters.AddWithValue("@precioCosto", objeto.precioCosto);
                cmd.Parameters.AddWithValue("@PrecioVenta", objeto.precioVenta);
                cmd.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
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

        public async Task<string> Editar(Producto objeto)
        {
            string Respuesta = "";

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_editarProducto", con);
                cmd.Parameters.AddWithValue("@codigoProducto", objeto.codigoProducto);
                cmd.Parameters.AddWithValue("@codigoCategoria", objeto.refCategoria.codigoCategoria);
                cmd.Parameters.AddWithValue("@Codigo", objeto.Codigo);
                cmd.Parameters.AddWithValue("@descripcion", objeto.descripcion);
                cmd.Parameters.AddWithValue("@precioCosto", objeto.precioCosto);
                cmd.Parameters.AddWithValue("@PrecioVenta", objeto.precioVenta);
                cmd.Parameters.AddWithValue("@Cantidad", objeto.Cantidad);
                cmd.Parameters.AddWithValue("@Estado", objeto.Estado);
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

        public async Task<Producto> Obtener(string codigo)
        {
            Producto objeto = new Producto();

            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_obtenerProducto", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        objeto = new Producto
                        {
                            codigoProducto = Convert.ToInt32(dr["codigoProducto"]),
                            refCategoria = new Categoria
                            {
                                nombre = dr["NombreCategoria"].ToString(),
                                refMedida = new LibreriayvariedadesanyDesk.Repository.Entities.Medida
                                {
                                    Equivalente = dr["equivalente"].ToString(),
                                    Valor = Convert.ToInt32(dr["Valor"])
                                }
                            },
                            Codigo = dr["Codigo"].ToString(),
                            descripcion = dr["descripcion"].ToString(),
                            precioVenta = Convert.ToDecimal(dr["PrecioVenta"]),
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                        };
                    }
                }
            }
            return objeto;
        }

        public async Task<Producto> ActualizarPrecioVenta(int codigoProducto, decimal nuevoPrecio)
        {
            Producto objeto = new Producto();
            using (var con = _conexion.ObtenerSQLConnection())
            {
                con.Open();
                var cmd = new SqlCommand("sp_ActualizarPrecioVenta", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
                cmd.Parameters.AddWithValue("@NuevoPrecio", nuevoPrecio);
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        objeto = new Producto
                        {
                            codigoProducto = Convert.ToInt32(dr["codigoProducto"]),
                            nuevoPrecio = dr["nuevoPrecio"].ToString(),
                        };
                    }
                }
            }
            return objeto;
        }
    }
}