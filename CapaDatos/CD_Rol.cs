using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Rol
    {
        public List<CE_Rol> Listar()
        {
            List<CE_Rol> lista = new List<CE_Rol>();

            using (SqlConnection oconexion = new SqlConnection(CD_Conexion.cadena))
            {
                try
                {
                    string consulta = "select IdRol, Descripcion from ROL";

                    SqlCommand cmd = new SqlCommand(consulta, oconexion);
                    cmd.CommandType = CommandType.Text;
                    oconexion.Open();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new CE_Rol
                            {
                                IdRol = Convert.ToInt32(dr["IdRol"]),
                                Descripcion = dr["Descripcion"].ToString(),
                            });
                        }
                    }
                }
                catch (Exception)
                {
                    lista = new List<CE_Rol>();
                }
                return lista;
            }
        }
    }
}
