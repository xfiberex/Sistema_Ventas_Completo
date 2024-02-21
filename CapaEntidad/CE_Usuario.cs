namespace CapaEntidad
{
    public class CE_Usuario
    {
        public int IdUsuario { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string ConfirmarClave { get; set; }
        public CE_Rol IdORol { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
