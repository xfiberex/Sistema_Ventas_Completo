using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Compra
    {
        // Estas clases sirven como puente entre la BD y el Programa
        // Verifica los datos

        private CD_Compra objCD_Compra = new CD_Compra();

        public int ObtenerCorrelativo()
        {
            return objCD_Compra.ObtenerCorrelativo();
        }

        public bool Registrar(CE_Compra obj, DataTable DetalleCompra, out string Mensaje)
        {
            return objCD_Compra.Registrar(obj, DetalleCompra, out Mensaje);
        }

        public CE_Compra ObtenerCompra(string numero)
        {
            CE_Compra oCompra = objCD_Compra.ObtenerCompra(numero);

            if (oCompra.IdCompra != 0)
            {
                List<CE_DetalleCompra> oDetalleCompra = objCD_Compra.ObtenerDetalleCompra(oCompra.IdCompra);
                oCompra.oDetalleCompra = oDetalleCompra;
            }

            return oCompra;
        }
    }
}
