using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Producto
    {
        // Estas clases sirven como puente entre la BD y el Programa

        private CD_Producto objCD_Producto = new CD_Producto();

        public List<CE_Producto> Listar()
        {
            return objCD_Producto.Listar();
        }

        public int Registrar(CE_Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la descripción del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objCD_Producto.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(CE_Producto obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Codigo == "")
            {
                Mensaje += "Es necesario el codigo del Producto\n";
            }

            if (obj.Nombre == "")
            {
                Mensaje += "Es necesario el nombre Producto\n";
            }

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la descripción del Producto\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objCD_Producto.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(CE_Producto obj, out string Mensaje)
        {
            return objCD_Producto.Eliminar(obj, out Mensaje);
        }
    }
}
