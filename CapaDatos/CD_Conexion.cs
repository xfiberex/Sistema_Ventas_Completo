using System.Configuration;

namespace CapaDatos
{
    public class CD_Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadenaConexion"].ToString();
    }
}
