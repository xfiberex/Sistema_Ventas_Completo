using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;
using System.Data;

namespace CapaNegocio
{
    public class CN_Venta
    {
        private CD_Venta objCD_Venta = new CD_Venta();

        public bool RestarStock(int idproducto, int cantidad)
        {
            return objCD_Venta.RestarStock(idproducto, cantidad);
        }

        public bool SumarStock(int idproducto, int cantidad)
        {
            return objCD_Venta.SumarStock(idproducto, cantidad);
        }

        public int ObtenerCorrelativo()
        {
            return objCD_Venta.ObtenerCorrelativo();
        }

        public bool Registrar(CE_Venta obj, DataTable DetalleVenta, out string Mensaje)
        {
            return objCD_Venta.Registrar(obj, DetalleVenta, out Mensaje);
        }

        public CE_Venta ObtenerVenta(string numero)
        {
            CE_Venta oVenta = objCD_Venta.ObtenerVenta(numero);

            if (oVenta.IdVenta != 0)
            {
                List<CE_DetalleVenta> oDetalleVenta = objCD_Venta.ObtenerDetalleVenta(oVenta.IdVenta);
                oVenta.oDetalleVenta = oDetalleVenta;
            }

            return oVenta;
        }
    }
}
