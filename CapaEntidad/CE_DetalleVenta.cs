namespace CapaEntidad
{
    public class CE_DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public CE_Producto IdOProducto { get; set; }
        public CE_Producto oDescripcion { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
