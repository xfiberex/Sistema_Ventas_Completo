using CapaDatos;
using CapaEntidad;
using System.Collections.Generic;

namespace CapaNegocio
{
    public class CN_Reporte
    {
        private CD_Reporte objCD_Reporte = new CD_Reporte();

        public List<CE_ReporteCompra> Compra(string fechainicio, string fechafin, int idproveedor)
        {
            return objCD_Reporte.Compra(fechainicio, fechafin, idproveedor);
        }

        public List<CE_ReporteVenta> Venta(string fechainicio, string fechafin)
        {
            return objCD_Reporte.Venta(fechainicio, fechafin);
        }
    }
}
