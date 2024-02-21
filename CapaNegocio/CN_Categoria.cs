using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        // Estas clases sirven como puente entre la BD y el Programa

        private CD_Categoria objCD_Categoria = new CD_Categoria();

        public List<CE_Categoria> Listar()
        {
            return objCD_Categoria.Listar();
        }

        public int Registrar(CE_Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la descripción para la categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objCD_Categoria.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(CE_Categoria obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Descripcion == "")
            {
                Mensaje += "Es necesaria la descripción para la categoria\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objCD_Categoria.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(CE_Categoria obj, out string Mensaje)
        {
            return objCD_Categoria.Eliminar(obj, out Mensaje);
        }
    }
}
