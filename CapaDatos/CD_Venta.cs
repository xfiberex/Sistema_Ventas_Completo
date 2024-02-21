using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Venta
    {
        public int ObtenerCorrelativo()
        {
            int IdCorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string consulta = "select count(*) + 1 from VENTA";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    IdCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch
                {
                    IdCorrelativo = 0;
                }
            }

            return IdCorrelativo;
        }

        public bool RestarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string consulta = "update PRODUCTO set Stock = Stock - @cantidad " +
                                      "where idproducto = @idproducto";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string consulta = "update PRODUCTO set Stock = Stock + @cantidad " +
                                      "where idproducto = @idproducto";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.Parameters.AddWithValue("@cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@idproducto", idproducto);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    respuesta = cmd.ExecuteNonQuery() > 0 ? true : false;
                }
                catch
                {
                    respuesta = false;
                }
            }

            return respuesta;
        }

        public bool Registrar(CE_Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_registrarVenta", oconexion);
                    cmd.Parameters.AddWithValue("@IdUsuario", obj.IdOUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("@NumeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@DocumentoCliente", obj.DocumentoCliente);
                    cmd.Parameters.AddWithValue("@NombreCliente", obj.NombreCliente);
                    cmd.Parameters.AddWithValue("@MontoPago", obj.MontoPago);
                    cmd.Parameters.AddWithValue("@MontoCambio", obj.MontoCambio);
                    cmd.Parameters.AddWithValue("@MontoTotal", obj.MontoTotal);
                    cmd.Parameters.AddWithValue("@DetalleVenta", DetalleVenta);
                    cmd.Parameters.Add("@Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("@Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();
                    cmd.ExecuteNonQuery();

                    // Parametros de salida
                    Respuesta = Convert.ToBoolean(cmd.Parameters["@Resultado"].Value);
                    Mensaje = cmd.Parameters["@Mensaje"].Value.ToString();
                }
                catch (Exception ex)
                {
                    Respuesta = false;
                    Mensaje = ex.Message;
                }
            }
            return Respuesta;
        }

        public CE_Venta ObtenerVenta(string numero)
        {
            CE_Venta obj = new CE_Venta();

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string consulta = "select v.IdVenta, u.NombreCompleto, " +
                        "v.DocumentoCliente, v.NombreCliente, " +
                        "v.TipoDocumento, v.NumeroDocumento, " +
                        "v.MontoPago, v.MontoCambio, v.MontoTotal, " +
                        "CONVERT(char(10), v.FechaRegistro, 103)[FechaRegistro] " +
                        "from VENTA v " +
                        "inner join USUARIO u on u.IdUsuario = v.IdUsuario " +
                        "where v.NumeroDocumento = @numero";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new CE_Venta()
                            {
                                IdVenta = Convert.ToInt32(dr["IdVenta"]),
                                IdOUsuario = new CE_Usuario() { NombreCompleto = dr["NombreCompleto"].ToString() },
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoPago = Convert.ToDecimal(dr["MontoPago"]),
                                MontoCambio = Convert.ToDecimal(dr["MontoCambio"]),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"]),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            };
                        }
                    }
                }
                catch
                {
                    obj = new CE_Venta();
                }
            }

            return obj;
        }

        public List<CE_DetalleVenta> ObtenerDetalleVenta(int idcompra)
        {
            List<CE_DetalleVenta> oLista = new List<CE_DetalleVenta>();

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string consulta = "select p.Nombre, p.Descripcion, dv.PrecioVenta, dv.Cantidad, dv.SubTotal " +
                        "from DETALLE_VENTA dv " +
                        "inner join PRODUCTO p on p.IdProducto = dv.IdProducto " +
                        "where dv.IdVenta = @idcompra";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.Parameters.AddWithValue("@idcompra", idcompra);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new CE_DetalleVenta
                            {
                                IdOProducto = new CE_Producto() { Nombre = dr["Nombre"].ToString() },
                                oDescripcion = new CE_Producto() { Descripcion = dr["Descripcion"].ToString() },
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                SubTotal = Convert.ToDecimal(dr["SubTotal"].ToString())
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    oLista = new List<CE_DetalleVenta>();
                }
                return oLista;
            }
        }
    }
}
