using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        // Estas clases sirven como puente entre la BD y el Programa

        private CD_Proveedor objCD_Proveedor = new CD_Proveedor();

        public List<CE_Proveedor> Listar()
        {
            return objCD_Proveedor.Listar();
        }

        public int Registrar(CE_Proveedor obj, out string Mensaje)
        {
            Mensaje = "";

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.RazonSocial == "")
            {
                Mensaje += "Es necesaria la razon social del Proveedor\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el telefono del Proveedor\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Proveedor\n";
            }

            if (Mensaje != "")
            {
                return 0;
            }
            else
            {
                return objCD_Proveedor.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(CE_Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.RazonSocial == "")
            {
                Mensaje += "Es necesaria la razon social del Proveedor\n";
            }

            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el telefono del Proveedor\n";
            }

            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario el telefono del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objCD_Proveedor.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(CE_Proveedor obj, out string Mensaje)
        {
            return objCD_Proveedor.Eliminar(obj, out Mensaje);
        }
    }
}
