using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        // Estas clases sirven como puente entre la BD y el Programa

        private CD_Cliente objCD_Cliente = new CD_Cliente();

        public List<CE_Cliente> Listar()
        {
            return objCD_Cliente.Listar();
        }

        public int Registrar(CE_Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del Cliente\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesaria el correo del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objCD_Cliente.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(CE_Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del Cliente\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesario el nombre completo del Cliente\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesaria el correo del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objCD_Cliente.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(CE_Cliente obj, out string Mensaje)
        {
            return objCD_Cliente.Eliminar(obj, out Mensaje);
        }
    }
}
