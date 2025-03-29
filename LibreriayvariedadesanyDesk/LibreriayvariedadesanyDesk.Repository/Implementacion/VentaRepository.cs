using LibreriayvariedadesanyDesk.Repository.DBConnection;
using LibreriayvariedadesanyDesk.Repository.Entities;
using LibreriayvariedadesanyDeskRepository.Interfaces;
using Microsoft.Data.SqlClient;
using System.Data;

namespace LibreriayvariedadesanyDeskRepository.Implementacion
{
    public class VentaRepository : IVentaRepository
    {
        private readonly Connection _conexion;

        public VentaRepository(Connection conexion)
        {
            _conexion = conexion;
        }

        public async Task<string> Registrar(string ventaXml)
        {
            if (string.IsNullOrEmpty(ventaXml))
            {
                throw new ArgumentException("El parámetro ventaXml no puede ser nulo o vacío.", nameof(ventaXml));
            }

            string Respuesta = "";

            try
            {
                using (var con = _conexion.ObtenerSQLConnection())
                {
                    await con.OpenAsync();
                    using (var cmd = new SqlCommand("sp_registraVenta", con))
                    {
                        cmd.Parameters.AddWithValue("@ventaXml", ventaXml);
                        cmd.Parameters.Add("@numeroVenta", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        await cmd.ExecuteNonQueryAsync();
                        Respuesta = Convert.ToString(cmd.Parameters["@numeroVenta"].Value) ?? "Error: No se pudo obtener el número de venta.";
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Log the SQL exception details (e.g., using a logging framework)
                Respuesta = $"Error(rp): SQL error - {sqlEx.Message}";
            }
            catch (Exception ex)
            {
                // Log the general exception details
                Respuesta = $"Error(rp): no se pudo completar la operación - {ex.Message}";
            }

            return Respuesta;
        }

        public async Task<Venta> Obtener(string numeroVenta)
        {
            if (string.IsNullOrEmpty(numeroVenta))
            {
                throw new ArgumentException("El parámetro numeroVenta no puede ser nulo o vacío.", nameof(numeroVenta));
            }

            Venta objeto = new Venta();

            try
            {
                using (var con = _conexion.ObtenerSQLConnection())
                {
                    await con.OpenAsync();
                    using (var cmd = new SqlCommand("sp_obtenerVenta", con))
                    {
                        cmd.Parameters.AddWithValue("@numeroVenta", numeroVenta);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        using (var dr = await cmd.ExecuteReaderAsync())
                        {
                            if (!await dr.ReadAsync())
                            {
                                return null; // O devuelve un objeto Venta con valores predeterminados
                            }

                            objeto = new Venta()
                            {
                                codigoFacturaCompra = Convert.ToInt32(dr["codigoVenta"]),
                                numeroVenta = dr["numeroVenta"].ToString(),
                                UsuarioRegistro = new Usuario
                                {
                                    nombreUsuario = dr["nombreUsuario"].ToString()
                                },
                                Nit = dr["Nit"].ToString(),
                                nombreCliente = dr["nombreCliente"].ToString(),
                                precioTotal = Convert.ToDecimal(dr["precioTotal"]),
                                PagoCon = Convert.ToDecimal(dr["PagoCon"]),
                                cambio = Convert.ToDecimal(dr["cambio"]),
                                fechaRegistro = dr["fechaRegistro"].ToString(),
                                refMedioPago = new MedioPago
                                {
                                    codigoMedioPago = Convert.ToInt32(dr["codigoMedioPago"]),
                                    descripcion = dr["descripcionMedioPago"].ToString()
                                },
                            };
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception($"Error SQL: {sqlEx.Message}", sqlEx);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error general: {ex.Message}", ex);
            }

            return objeto;
        }

        public async Task<List<DetalleVenta>> ObtenerDetalle(string numeroVenta)
        {
            if (string.IsNullOrEmpty(numeroVenta))
            {
                throw new ArgumentException("El parámetro numeroVenta no puede ser nulo o vacío.", nameof(numeroVenta));
            }

            List<DetalleVenta> lista = new List<DetalleVenta>();

            try
            {
                using (var con = _conexion.ObtenerSQLConnection())
                {
                    await con.OpenAsync();
                    using (var cmd = new SqlCommand("sp_obtenerDetalleVenta", con))
                    {
                        cmd.Parameters.AddWithValue("@numeroVenta", numeroVenta);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;

                        using (var dr = await cmd.ExecuteReaderAsync())
                        {
                            while (await dr.ReadAsync())
                            {
                                lista.Add(new DetalleVenta
                                {
                                    refProducto = new Producto
                                    {
                                        descripcion = dr["descripcion"].ToString()!,
                                        refCategoria = new Categoria
                                        {
                                            refMedida = new Medida
                                            {
                                                Abreviatura = dr["abreviatura"].ToString()!,
                                                Valor = Convert.ToInt32(dr["Valor"])
                                            }
                                        }
                                    },
                                    cantidad = Convert.ToInt32(dr["cantidad"]),
                                    precioVenta = Convert.ToDecimal(dr["precioventa"]),
                                    precioTotal = Convert.ToDecimal(dr["precioTotal"])
                                });
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                // Log the SQL exception details
                throw new Exception($"Error(rp): SQL error - {sqlEx.Message}", sqlEx);
            }
            catch (Exception ex)
            {
                // Log the general exception details
                throw new Exception($"Error(rp): no se pudo completar la operación - {ex.Message}", ex);
            }

            return lista;
        }
    }
}