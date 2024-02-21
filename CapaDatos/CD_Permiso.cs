using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Permiso
    {
        public List<CE_Permiso> Listar(int idusuario)
        {
            List<CE_Permiso> lista = new List<CE_Permiso>();

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string consulta = "select p.IdRol, p.NombreMenu from PERMISO p " +
                                      "inner join ROL r on r.IdRol = p.IdRol " +
                                      "inner join USUARIO u on u.IdRol = r.IdRol " +
                                      "where u.IdUsuario = @idusuario";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.Parameters.AddWithValue("@idusuario", idusuario);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CE_Permiso
                            {
                                IdORol = new CE_Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                NombreMenu = dr["NombreMenu"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<CE_Permiso>();
                }
                return lista;
            }
        }
    }
}
