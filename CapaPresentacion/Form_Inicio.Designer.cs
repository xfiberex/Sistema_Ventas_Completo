using DocumentFormat.OpenXml.Presentation;
using System.Drawing;

namespace CapaPresentacion
{
    partial class Form_Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Inicio));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuUsuario = new FontAwesome.Sharp.IconMenuItem();
            this.menuMantenedor = new FontAwesome.Sharp.IconMenuItem();
            this.sub_menuCategoria = new FontAwesome.Sharp.IconMenuItem();
            this.sub_menuProducto = new FontAwesome.Sharp.IconMenuItem();
            this.sub_menuNegocio = new FontAwesome.Sharp.IconMenuItem();
            this.menuVentas = new FontAwesome.Sharp.IconMenuItem();
            this.sub_menuRegistrar = new FontAwesome.Sharp.IconMenuItem();
            this.sub_menuDetalleVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menuCompras = new FontAwesome.Sharp.IconMenuItem();
            this.sub_menuRegistraCompra = new FontAwesome.Sharp.IconMenuItem();
            this.sub_menuDetalleCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuClientes = new FontAwesome.Sharp.IconMenuItem();
            this.menuProveedores = new FontAwesome.Sharp.IconMenuItem();
            this.menuReportes = new FontAwesome.Sharp.IconMenuItem();
            this.sub_menuReporteCompra = new FontAwesome.Sharp.IconMenuItem();
            this.menuAcerca = new FontAwesome.Sharp.IconMenuItem();
            this.menuTitulo = new System.Windows.Forms.MenuStrip();
            this.lblUsuario = new Custom_Controls_Plus.RJ_Label();
            this.pnlContenedor = new Custom_Controls_Plus.RJ_Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tmTransition = new System.Windows.Forms.Timer(this.components);
            this.btnCerrarSección = new Custom_Controls_Plus.RJ_Button();
            this.sub_menuReporteVenta = new FontAwesome.Sharp.IconMenuItem();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUsuario,
            this.menuMantenedor,
            this.menuVentas,
            this.menuCompras,
            this.menuClientes,
            this.menuProveedores,
            this.menuReportes,
            this.menuAcerca});
            this.menu.Location = new System.Drawing.Point(0, 63);
            this.menu.Name = "menu";
            this.menu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu.Size = new System.Drawing.Size(1303, 48);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuUsuario
            // 
            this.menuUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuUsuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.menuUsuario.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuUsuario.IconSize = 30;
            this.menuUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.menuUsuario.Size = new System.Drawing.Size(115, 44);
            this.menuUsuario.Text = "Usuarios";
            this.menuUsuario.Click += new System.EventHandler(this.menuUsuario_Click);
            // 
            // menuMantenedor
            // 
            this.menuMantenedor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_menuCategoria,
            this.sub_menuProducto,
            this.sub_menuNegocio});
            this.menuMantenedor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuMantenedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuMantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.menuMantenedor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuMantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuMantenedor.IconSize = 30;
            this.menuMantenedor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuMantenedor.Name = "menuMantenedor";
            this.menuMantenedor.Size = new System.Drawing.Size(125, 44);
            this.menuMantenedor.Text = "Mantenedor";
            // 
            // sub_menuCategoria
            // 
            this.sub_menuCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.sub_menuCategoria.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_menuCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuCategoria.IconChar = FontAwesome.Sharp.IconChar.BoxesAlt;
            this.sub_menuCategoria.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sub_menuCategoria.IconSize = 25;
            this.sub_menuCategoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sub_menuCategoria.Name = "sub_menuCategoria";
            this.sub_menuCategoria.Size = new System.Drawing.Size(144, 32);
            this.sub_menuCategoria.Text = "Categoria";
            this.sub_menuCategoria.Click += new System.EventHandler(this.sub_menuCategoria_Click);
            // 
            // sub_menuProducto
            // 
            this.sub_menuProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.sub_menuProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_menuProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuProducto.IconChar = FontAwesome.Sharp.IconChar.BoxesPacking;
            this.sub_menuProducto.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sub_menuProducto.IconSize = 25;
            this.sub_menuProducto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sub_menuProducto.Name = "sub_menuProducto";
            this.sub_menuProducto.Size = new System.Drawing.Size(144, 32);
            this.sub_menuProducto.Text = "Producto";
            this.sub_menuProducto.Click += new System.EventHandler(this.sub_menuProducto_Click);
            // 
            // sub_menuNegocio
            // 
            this.sub_menuNegocio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.sub_menuNegocio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub_menuNegocio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuNegocio.IconChar = FontAwesome.Sharp.IconChar.Shop;
            this.sub_menuNegocio.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuNegocio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sub_menuNegocio.IconSize = 25;
            this.sub_menuNegocio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sub_menuNegocio.Name = "sub_menuNegocio";
            this.sub_menuNegocio.Size = new System.Drawing.Size(144, 32);
            this.sub_menuNegocio.Text = "Negocio";
            this.sub_menuNegocio.Click += new System.EventHandler(this.sub_menuNegocio_Click);
            // 
            // menuVentas
            // 
            this.menuVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.menuVentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_menuRegistrar,
            this.sub_menuDetalleVenta});
            this.menuVentas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuVentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuVentas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.menuVentas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuVentas.IconSize = 30;
            this.menuVentas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVentas.Name = "menuVentas";
            this.menuVentas.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.menuVentas.Size = new System.Drawing.Size(103, 44);
            this.menuVentas.Text = "Ventas";
            // 
            // sub_menuRegistrar
            // 
            this.sub_menuRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.sub_menuRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuRegistrar.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.sub_menuRegistrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sub_menuRegistrar.IconSize = 25;
            this.sub_menuRegistrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sub_menuRegistrar.Name = "sub_menuRegistrar";
            this.sub_menuRegistrar.Size = new System.Drawing.Size(140, 32);
            this.sub_menuRegistrar.Text = "Registrar";
            this.sub_menuRegistrar.Click += new System.EventHandler(this.sub_menuRegistrarVenta_Click);
            // 
            // sub_menuDetalleVenta
            // 
            this.sub_menuDetalleVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.sub_menuDetalleVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuDetalleVenta.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.sub_menuDetalleVenta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuDetalleVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sub_menuDetalleVenta.IconSize = 25;
            this.sub_menuDetalleVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sub_menuDetalleVenta.Name = "sub_menuDetalleVenta";
            this.sub_menuDetalleVenta.Size = new System.Drawing.Size(140, 32);
            this.sub_menuDetalleVenta.Text = "Detalles";
            this.sub_menuDetalleVenta.Click += new System.EventHandler(this.sub_menuDetalleVenta_Click);
            // 
            // menuCompras
            // 
            this.menuCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_menuRegistraCompra,
            this.sub_menuDetalleCompra});
            this.menuCompras.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCompras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuCompras.IconChar = FontAwesome.Sharp.IconChar.DollyFlatbed;
            this.menuCompras.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuCompras.IconSize = 30;
            this.menuCompras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCompras.Name = "menuCompras";
            this.menuCompras.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.menuCompras.Size = new System.Drawing.Size(116, 44);
            this.menuCompras.Text = "Compras";
            // 
            // sub_menuRegistraCompra
            // 
            this.sub_menuRegistraCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.sub_menuRegistraCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuRegistraCompra.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            this.sub_menuRegistraCompra.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuRegistraCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sub_menuRegistraCompra.IconSize = 25;
            this.sub_menuRegistraCompra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sub_menuRegistraCompra.Name = "sub_menuRegistraCompra";
            this.sub_menuRegistraCompra.Size = new System.Drawing.Size(189, 32);
            this.sub_menuRegistraCompra.Text = "Registrar";
            this.sub_menuRegistraCompra.Click += new System.EventHandler(this.sub_menuRegistraCompra_Click);
            // 
            // sub_menuDetalleCompra
            // 
            this.sub_menuDetalleCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.sub_menuDetalleCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuDetalleCompra.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.sub_menuDetalleCompra.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuDetalleCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sub_menuDetalleCompra.IconSize = 25;
            this.sub_menuDetalleCompra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sub_menuDetalleCompra.Name = "sub_menuDetalleCompra";
            this.sub_menuDetalleCompra.Size = new System.Drawing.Size(189, 32);
            this.sub_menuDetalleCompra.Text = "Detalles";
            this.sub_menuDetalleCompra.Click += new System.EventHandler(this.sub_menuDetalleCompra_Click);
            // 
            // menuClientes
            // 
            this.menuClientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuClientes.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.menuClientes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClientes.IconSize = 30;
            this.menuClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.menuClientes.Size = new System.Drawing.Size(111, 44);
            this.menuClientes.Text = "Clientes";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuProveedores
            // 
            this.menuProveedores.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProveedores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuProveedores.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.menuProveedores.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuProveedores.IconSize = 30;
            this.menuProveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.menuProveedores.Size = new System.Drawing.Size(138, 44);
            this.menuProveedores.Text = "Proveedores";
            this.menuProveedores.Click += new System.EventHandler(this.menuProveedores_Click);
            // 
            // menuReportes
            // 
            this.menuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sub_menuReporteCompra,
            this.sub_menuReporteVenta});
            this.menuReportes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuReportes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuReportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.menuReportes.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuReportes.IconSize = 30;
            this.menuReportes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuReportes.Name = "menuReportes";
            this.menuReportes.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.menuReportes.Size = new System.Drawing.Size(116, 44);
            this.menuReportes.Text = "Reportes";
            // 
            // sub_menuReporteCompra
            // 
            this.sub_menuReporteCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.sub_menuReporteCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuReporteCompra.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.sub_menuReporteCompra.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuReporteCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sub_menuReporteCompra.IconSize = 25;
            this.sub_menuReporteCompra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sub_menuReporteCompra.Name = "sub_menuReporteCompra";
            this.sub_menuReporteCompra.Size = new System.Drawing.Size(210, 32);
            this.sub_menuReporteCompra.Text = "Reporte de Compras";
            this.sub_menuReporteCompra.Click += new System.EventHandler(this.sub_menuReporteCompra_Click);
            // 
            // menuAcerca
            // 
            this.menuAcerca.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuAcerca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuAcerca.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.menuAcerca.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.menuAcerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAcerca.IconSize = 30;
            this.menuAcerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuAcerca.Name = "menuAcerca";
            this.menuAcerca.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.menuAcerca.Size = new System.Drawing.Size(121, 44);
            this.menuAcerca.Text = "Acerca de";
            this.menuAcerca.Click += new System.EventHandler(this.menuAcerca_Click);
            // 
            // menuTitulo
            // 
            this.menuTitulo.AutoSize = false;
            this.menuTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.menuTitulo.Location = new System.Drawing.Point(0, 0);
            this.menuTitulo.Name = "menuTitulo";
            this.menuTitulo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuTitulo.Size = new System.Drawing.Size(1303, 63);
            this.menuTitulo.TabIndex = 1;
            this.menuTitulo.Text = "menuStrip2";
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lblUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.lblUsuario.BorderColor = System.Drawing.Color.DimGray;
            this.lblUsuario.BorderRadius = 0;
            this.lblUsuario.BorderSize = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.lblUsuario.Location = new System.Drawing.Point(66, 9);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Padding = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.lblUsuario.Size = new System.Drawing.Size(904, 48);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "BIENVENIDO! USER123";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsuario.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            // 
            // pnlContenedor
            // 
            this.pnlContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.pnlContenedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.pnlContenedor.BorderColor = System.Drawing.Color.DimGray;
            this.pnlContenedor.BorderRadius = 8;
            this.pnlContenedor.BorderSize = 1;
            this.pnlContenedor.Location = new System.Drawing.Point(12, 114);
            this.pnlContenedor.Name = "pnlContenedor";
            this.pnlContenedor.Size = new System.Drawing.Size(1279, 660);
            this.pnlContenedor.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Stocks_Growth;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCerrarSección
            // 
            this.btnCerrarSección.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnCerrarSección.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.btnCerrarSección.BorderColor = System.Drawing.Color.White;
            this.btnCerrarSección.BorderRadius = 0;
            this.btnCerrarSección.BorderSize = 0;
            this.btnCerrarSección.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarSección.FlatAppearance.BorderSize = 0;
            this.btnCerrarSección.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSección.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSección.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnCerrarSección.Image = global::CapaPresentacion.Properties.Resources.Logout;
            this.btnCerrarSección.Location = new System.Drawing.Point(1240, 12);
            this.btnCerrarSección.Name = "btnCerrarSección";
            this.btnCerrarSección.Size = new System.Drawing.Size(51, 40);
            this.btnCerrarSección.TabIndex = 16;
            this.btnCerrarSección.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnCerrarSección.UseVisualStyleBackColor = false;
            this.btnCerrarSección.Click += new System.EventHandler(this.btnCerrarSección_Click);
            // 
            // sub_menuReporteVenta
            // 
            this.sub_menuReporteVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.sub_menuReporteVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuReporteVenta.IconChar = FontAwesome.Sharp.IconChar.FileText;
            this.sub_menuReporteVenta.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(163)))), ((int)(((byte)(102)))));
            this.sub_menuReporteVenta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sub_menuReporteVenta.IconSize = 25;
            this.sub_menuReporteVenta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.sub_menuReporteVenta.Name = "sub_menuReporteVenta";
            this.sub_menuReporteVenta.Size = new System.Drawing.Size(210, 32);
            this.sub_menuReporteVenta.Text = "Reporte de Ventas";
            this.sub_menuReporteVenta.Click += new System.EventHandler(this.sub_menuReporteVenta_Click);
            // 
            // Form_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1303, 786);
            this.Controls.Add(this.btnCerrarSección);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pnlContenedor);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.menuTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1319, 825);
            this.MinimumSize = new System.Drawing.Size(1319, 825);
            this.Name = "Form_Inicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Ventas | 1.0.0.0";
            this.Load += new System.EventHandler(this.Form_Inicio_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.MenuStrip menuTitulo;
        private Custom_Controls_Plus.RJ_Label lblUsuario;
        private FontAwesome.Sharp.IconMenuItem menuClientes;
        private FontAwesome.Sharp.IconMenuItem menuUsuario;
        private FontAwesome.Sharp.IconMenuItem menuVentas;
        private FontAwesome.Sharp.IconMenuItem menuCompras;
        private FontAwesome.Sharp.IconMenuItem menuAcerca;
        private FontAwesome.Sharp.IconMenuItem menuProveedores;
        private FontAwesome.Sharp.IconMenuItem menuReportes;
        private Custom_Controls_Plus.RJ_Panel pnlContenedor;
        private FontAwesome.Sharp.IconMenuItem sub_menuRegistrar;
        private FontAwesome.Sharp.IconMenuItem sub_menuDetalleVenta;
        private FontAwesome.Sharp.IconMenuItem sub_menuRegistraCompra;
        private FontAwesome.Sharp.IconMenuItem sub_menuDetalleCompra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmTransition;
        private FontAwesome.Sharp.IconMenuItem menuMantenedor;
        private FontAwesome.Sharp.IconMenuItem sub_menuCategoria;
        private FontAwesome.Sharp.IconMenuItem sub_menuProducto;
        private FontAwesome.Sharp.IconMenuItem sub_menuNegocio;
        private FontAwesome.Sharp.IconMenuItem sub_menuReporteCompra;
        private Custom_Controls_Plus.RJ_Button btnCerrarSección;
        private FontAwesome.Sharp.IconMenuItem sub_menuReporteVenta;
    }
}

