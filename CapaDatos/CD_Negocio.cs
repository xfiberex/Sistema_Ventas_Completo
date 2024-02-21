using CapaEntidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Negocio
    {
        public CE_Negocio ObtenerDatos()
        {
            CE_Negocio obj = new CE_Negocio();

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string consulta = "select IdNegocio, Nombre, RUC, Direccion from NEGOCIO where IdNegocio = 1";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new CE_Negocio
                            {
                                IdNegocio = Convert.ToInt32(dr["IdNegocio"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                RNC = dr["RUC"].ToString(),
                                Direccion = dr["Direccion"].ToString(),

                            };
                        }
                    }
                }
                catch (Exception)
                {
                    obj = new CE_Negocio();
                }
                return obj;
            }
        }

        public bool GuardarDatos(CE_Negocio objeto, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string consulta = "update NEGOCIO set Nombre = @Nombre, " +
                                      "RUC = @RUC, " +
                                      "Direccion = @Direccion " +
                                      "where IdNegocio = 1";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@RUC", objeto.RNC);
                    cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudieron guardar los datos";
                        respuesta = false;
                    }
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    respuesta = false;
                }
                return respuesta;
            }
        }

        // Metodos para obtener logos
        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] LogoBytes = new byte[0];

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string consulta = "select Logo from NEGOCIO where IdNegocio = 1";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();


                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            LogoBytes = (byte[])dr["Logo"];
                        }
                    }
                }
                catch
                {
                    obtenido = false;
                    LogoBytes = new byte[0];
                }
                return LogoBytes;
            }
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true;

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string consulta = "update NEGOCIO set Logo = @imagen " +
                                      "where IdNegocio = 1";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.Parameters.AddWithValue("@imagen", imagen);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el logo";
                        respuesta = false;
                    }
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                    respuesta = false;
                }
                return respuesta;
            }
        }
    }
}
