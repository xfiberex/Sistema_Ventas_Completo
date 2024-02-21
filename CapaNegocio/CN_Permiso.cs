using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private CD_Permiso objCD_Permiso = new CD_Permiso();

        public List<CE_Permiso> Listar(int IdUsuario)
        {
            return objCD_Permiso.Listar(IdUsuario);
        }
    }
}
