using System.Collections.Generic;

namespace CapaEntidad
{
    public class CE_Venta
    {
        public int IdVenta { get; set; }
        public CE_Usuario IdOUsuario { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public List<CE_DetalleVenta> oDetalleVenta { get; set; }
        public string FechaRegistro { get; set; }
    }
}