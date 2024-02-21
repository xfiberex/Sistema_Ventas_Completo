using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Compra
    {
        public int ObtenerCorrelativo()
        {
            int IdCorrelativo = 0;

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string consulta = "select count(*) + 1 from COMPRA";

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

        public bool Registrar(CE_Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_registrarCompra", oconexion);
                    cmd.Parameters.AddWithValue("@IdUsuario", obj.IdOUsuario.IdUsuario);
                    cmd.Parameters.AddWithValue("@IdProveedor", obj.IdOProveedor.IdProveedor);
                    cmd.Parameters.AddWithValue("@TipoDocumento", obj.TipoDocumento);
                    cmd.Parameters.AddWithValue("@NumeroDocumento", obj.NumeroDocumento);
                    cmd.Parameters.AddWithValue("@MontoTotal", obj.MontoTotal);
                    cmd.Parameters.AddWithValue("@DetalleCompra", DetalleCompra);
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

        public CE_Compra ObtenerCompra(string numero)
        {
            CE_Compra obj = new CE_Compra();

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string consulta = "select c.IdCompra, u.NombreCompleto, pr.Documento, pr.RazonSocial, c.TipoDocumento, " +
                        "c.NumeroDocumento, c.MontoTotal, CONVERT(char(10), c.FechaRegistro, 103)[FechaRegistro] " +
                        "from COMPRA c " +
                        "inner join USUARIO u on u.IdUsuario = c.IdUsuario " +
                        "inner join PROVEEDOR pr on pr.IdProveedor = c.IdProveedor " +
                        "where c.NumeroDocumento = @numero";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new CE_Compra()
                            {
                                IdCompra = Convert.ToInt32(dr["IdCompra"]),
                                IdOUsuario = new CE_Usuario() { NombreCompleto = dr["NombreCompleto"].ToString() },
                                IdOProveedor = new CE_Proveedor() { Documento = dr["Documento"].ToString(), RazonSocial = dr["RazonSocial"].ToString() },
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            };
                        }
                    }
                }
                catch
                {
                    obj = new CE_Compra();
                }
            }

            return obj;
        }

        public List<CE_DetalleCompra> ObtenerDetalleCompra(int idcompra)
        {
            List<CE_DetalleCompra> oLista = new List<CE_DetalleCompra>();

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string consulta = "select p.Nombre, p.Descripcion, dc.PrecioCompra, dc.Cantidad, dc.MontoTotal " +
                        "from DETALLE_COMPRA dc " +
                        "inner join PRODUCTO p on p.IdProducto = dc.IdProducto " +
                        "where dc.IdCompra = @idcompra";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.Parameters.AddWithValue("@idcompra", idcompra);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new CE_DetalleCompra
                            {
                                IdOProducto = new CE_Producto() { Nombre = dr["Nombre"].ToString() },
                                oDescripcion = new CE_Producto() { Descripcion = dr["Descripcion"].ToString() },
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString())
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    oLista = new List<CE_DetalleCompra>();
                }
                return oLista;
            }
        }
    }
}
