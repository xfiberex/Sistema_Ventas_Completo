using CapaEntidad;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Reporte
    {
        public List<CE_ReporteCompra> Compra(string fechainicio, string fechafin, int idproveedor)
        {
            List<CE_ReporteCompra> lista = new List<CE_ReporteCompra>();

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_reporteCompras", oconexion);
                    cmd.Parameters.AddWithValue("@FechaInicio", fechainicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechafin);
                    cmd.Parameters.AddWithValue("@IdProveedor", idproveedor);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CE_ReporteCompra
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                DocumentoProveedor = dr["DocumentoProveedor"].ToString(),
                                RazonSocial = dr["RazonSocial"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                PrecioCompra = dr["PrecioCompra"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["SubTotal"].ToString()

                            });
                        }
                    }
                }
                catch
                {
                    lista = new List<CE_ReporteCompra>();
                }
                return lista;
            }
        }

        public List<CE_ReporteVenta> Venta(string fechainicio, string fechafin)
        {
            List<CE_ReporteVenta> lista = new List<CE_ReporteVenta>();

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_reporteVentas", oconexion);
                    cmd.Parameters.AddWithValue("@FechaInicio", fechainicio);
                    cmd.Parameters.AddWithValue("@FechaFin", fechafin);
                    cmd.CommandType = CommandType.StoredProcedure;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CE_ReporteVenta
                            {
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = dr["MontoTotal"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                CodigoProducto = dr["CodigoProducto"].ToString(),
                                NombreProducto = dr["NombreProducto"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                Cantidad = dr["Cantidad"].ToString(),
                                SubTotal = dr["SubTotal"].ToString()

                            });
                        }
                    }
                }
                catch
                {
                    lista = new List<CE_ReporteVenta>();
                }
                return lista;
            }
        }
    }
}
