using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Negocio
    {
        // Estas clases sirven como puente entre la BD y el Programa
        // Verifica los datos

        private CD_Negocio objCD_Negocio = new CD_Negocio();

        public CE_Negocio ObtenerDatos()
        {
            return objCD_Negocio.ObtenerDatos();
        }

        public bool GuardarDatos(CE_Negocio obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            // Comprobaciones de datos
            if (string.IsNullOrEmpty(obj.Nombre))
                Mensaje += "  • Es necesario el nombre\n";

            if (string.IsNullOrEmpty(obj.RNC))
                Mensaje += "  • Es necesario el RUC\n";

            if (string.IsNullOrEmpty(obj.Direccion))
                Mensaje += "  • Es necesario la dirección\n";

            if (Mensaje != string.Empty)
                return false;
            else
                return objCD_Negocio.GuardarDatos(obj, out Mensaje);
        }

        public byte[] ObtenerLogo(out bool obtenido)
        {
            return objCD_Negocio.ObtenerLogo(out obtenido);
        }

        public bool ActualizarLogo(byte[] imagen, out string mensaje)
        {
            return objCD_Negocio.ActualizarLogo(imagen, out mensaje);
        }
    }
}
