namespace CapaEntidad
{
    public class CE_DetalleCompra
    {
        public int IdDetalleCompra { get; set; }
        public CE_Producto IdOProducto { get; set; }
        public CE_Producto oDescripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
