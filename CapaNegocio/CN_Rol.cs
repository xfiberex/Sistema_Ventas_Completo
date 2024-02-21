using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Rol
    {
        private CD_Rol objCD_Rol = new CD_Rol();

        public List<CE_Rol> Listar()
        {
            return objCD_Rol.Listar();
        }
    }
}
