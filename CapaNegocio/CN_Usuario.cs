using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        // Estas clases sirven como puente entre la BD y el Programa
        // Verifica los datos

        private CD_Usuario objCD_Usuario = new CD_Usuario();

        public List<CE_Usuario> Listar()
        {
            return objCD_Usuario.Listar();
        }

        public int Registrar(CE_Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            // Comprobaciones de datos
            if (string.IsNullOrEmpty(obj.Documento))
                Mensaje += "  • Es necesario el documento\n";

            if (string.IsNullOrEmpty(obj.NombreCompleto))
                Mensaje += "  • Es necesario el nombre completo\n";

            if (string.IsNullOrEmpty(obj.Correo))
                Mensaje += "  • Es necesario el correo\n";

            if (string.IsNullOrEmpty(obj.Clave))
                Mensaje += "  • Es necesaria la clave\n";

            if (string.IsNullOrEmpty(obj.ConfirmarClave))
                Mensaje += "  • Es necesaria la confirmación de la clave\n";

            if (!string.IsNullOrEmpty(obj.Clave) && !string.IsNullOrEmpty(obj.ConfirmarClave) && obj.Clave != obj.ConfirmarClave)
                Mensaje += "  • Las contraseñas no coinciden\n";

            if (Mensaje != string.Empty)
                return 0;
            else
                return objCD_Usuario.Registrar(obj, out Mensaje);
        }

        public bool Editar(CE_Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            // Comprobaciones de datos
            if (string.IsNullOrEmpty(obj.Documento))
                Mensaje += "Es necesario el documento del usuario\n";

            if (string.IsNullOrEmpty(obj.NombreCompleto))
                Mensaje += "Es necesario el nombre completo del usuario\n";

            if (string.IsNullOrEmpty(obj.Correo))
                Mensaje += "Es necesario el correo del usuario\n";

            if (string.IsNullOrEmpty(obj.Clave))
                Mensaje += "  • Es necesaria la clave\n";

            if (string.IsNullOrEmpty(obj.ConfirmarClave))
                Mensaje += "  • Es necesaria la confirmación de la clave\n";

            if (!string.IsNullOrEmpty(obj.Clave) && !string.IsNullOrEmpty(obj.ConfirmarClave) && obj.Clave != obj.ConfirmarClave)
                Mensaje += "  • Las contraseñas no coinciden\n";

            if (Mensaje != string.Empty)
                return false;
            else
                return objCD_Usuario.Editar(obj, out Mensaje);
        }

        public bool Eliminar(CE_Usuario obj, out string Mensaje)
        {
            return objCD_Usuario.Eliminar(obj, out Mensaje);
        }
    }
}
