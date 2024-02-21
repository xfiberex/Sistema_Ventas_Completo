using System.Collections.Generic;

namespace CapaEntidad
{
    public class CE_Compra
    {
        public int IdCompra { get; set; }
        public CE_Usuario IdOUsuario { get; set; }
        public CE_Proveedor IdOProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public List<CE_DetalleCompra> oDetalleCompra { get; set; }
        public string FechaRegistro { get; set; }
    }
}
