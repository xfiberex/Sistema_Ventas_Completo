namespace CapaPresentacion.Formularios
{
    partial class Form_DetalleCompra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle46 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle44 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle45 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rJ_Label3 = new Custom_Controls_Plus.RJ_Label();
            this.btnBuscarDocumento = new Custom_Controls_Plus.RJ_Button();
            this.btnLimpiarBusquedaDocumento = new Custom_Controls_Plus.RJ_Button();
            this.txtBusquedaDocumento = new ControlsLibrary.RJ_TextBox();
            this.rJ_Label5 = new Custom_Controls_Plus.RJ_Label();
            this.rJ_Label4 = new Custom_Controls_Plus.RJ_Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuarioCompra = new ControlsLibrary.RJ_TextBox();
            this.txtTipoDocumentoCompra = new ControlsLibrary.RJ_TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaCompra = new ControlsLibrary.RJ_TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtnumerodocumento = new ControlsLibrary.RJ_TextBox();
            this.txtRazonSocialProv = new ControlsLibrary.RJ_TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumeroDocProveedor = new ControlsLibrary.RJ_TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvListadoDetalleCompra = new Custom_Controls_Plus.RJDataGridView();
            this.txtMontoTotalCompra = new ControlsLibrary.RJ_TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPDFDetalleCompra = new Custom_Controls_Plus.RJ_Button();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetalleCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // rJ_Label3
            // 
            this.rJ_Label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rJ_Label3.BackColor = System.Drawing.Color.Transparent;
            this.rJ_Label3.BackgroundColor = System.Drawing.Color.Transparent;
            this.rJ_Label3.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label3.BorderRadius = 8;
            this.rJ_Label3.BorderSize = 1;
            this.rJ_Label3.ForeColor = System.Drawing.Color.White;
            this.rJ_Label3.Location = new System.Drawing.Point(163, 12);
            this.rJ_Label3.Name = "rJ_Label3";
            this.rJ_Label3.Size = new System.Drawing.Size(910, 768);
            this.rJ_Label3.TabIndex = 32;
            this.rJ_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Label3.TextColor = System.Drawing.Color.White;
            // 
            // btnBuscarDocumento
            // 
            this.btnBuscarDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarDocumento.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarDocumento.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBuscarDocumento.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscarDocumento.BorderRadius = 5;
            this.btnBuscarDocumento.BorderSize = 1;
            this.btnBuscarDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarDocumento.FlatAppearance.BorderSize = 0;
            this.btnBuscarDocumento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarDocumento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarDocumento.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarDocumento.Image = global::CapaPresentacion.Properties.Resources.SearchBlack;
            this.btnBuscarDocumento.Location = new System.Drawing.Point(962, 36);
            this.btnBuscarDocumento.Name = "btnBuscarDocumento";
            this.btnBuscarDocumento.Padding = new System.Windows.Forms.Padding(5);
            this.btnBuscarDocumento.Size = new System.Drawing.Size(40, 31);
            this.btnBuscarDocumento.TabIndex = 62;
            this.btnBuscarDocumento.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarDocumento.UseVisualStyleBackColor = false;
            this.btnBuscarDocumento.Click += new System.EventHandler(this.btnBuscarDocumento_Click);
            // 
            // btnLimpiarBusquedaDocumento
            // 
            this.btnLimpiarBusquedaDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarBusquedaDocumento.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBusquedaDocumento.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBusquedaDocumento.BorderColor = System.Drawing.Color.DimGray;
            this.btnLimpiarBusquedaDocumento.BorderRadius = 5;
            this.btnLimpiarBusquedaDocumento.BorderSize = 1;
            this.btnLimpiarBusquedaDocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBusquedaDocumento.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBusquedaDocumento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusquedaDocumento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnLimpiarBusquedaDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusquedaDocumento.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusquedaDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusquedaDocumento.Image = global::CapaPresentacion.Properties.Resources.BroomBlack;
            this.btnLimpiarBusquedaDocumento.Location = new System.Drawing.Point(1008, 36);
            this.btnLimpiarBusquedaDocumento.Name = "btnLimpiarBusquedaDocumento";
            this.btnLimpiarBusquedaDocumento.Padding = new System.Windows.Forms.Padding(5);
            this.btnLimpiarBusquedaDocumento.Size = new System.Drawing.Size(40, 31);
            this.btnLimpiarBusquedaDocumento.TabIndex = 61;
            this.btnLimpiarBusquedaDocumento.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusquedaDocumento.UseVisualStyleBackColor = false;
            this.btnLimpiarBusquedaDocumento.Click += new System.EventHandler(this.btnLimpiarBusquedaDocumento_Click);
            // 
            // txtBusquedaDocumento
            // 
            this.txtBusquedaDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusquedaDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtBusquedaDocumento.BorderColor = System.Drawing.Color.DimGray;
            this.txtBusquedaDocumento.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtBusquedaDocumento.BorderRadius = 5;
            this.txtBusquedaDocumento.BorderSize = 1;
            this.txtBusquedaDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusquedaDocumento.Location = new System.Drawing.Point(799, 36);
            this.txtBusquedaDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaDocumento.Multiline = false;
            this.txtBusquedaDocumento.Name = "txtBusquedaDocumento";
            this.txtBusquedaDocumento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusquedaDocumento.PasswordChar = false;
            this.txtBusquedaDocumento.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtBusquedaDocumento.PlaceholderText = "Ingrese el numero...";
            this.txtBusquedaDocumento.ReadOnly = false;
            this.txtBusquedaDocumento.Size = new System.Drawing.Size(156, 31);
            this.txtBusquedaDocumento.TabIndex = 60;
            this.txtBusquedaDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBusquedaDocumento.UnderlinedStyle = false;
            this.txtBusquedaDocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusquedaDocumento_KeyDown);
            // 
            // rJ_Label5
            // 
            this.rJ_Label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rJ_Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label5.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label5.BorderRadius = 5;
            this.rJ_Label5.BorderSize = 1;
            this.rJ_Label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Label5.ForeColor = System.Drawing.Color.Black;
            this.rJ_Label5.Location = new System.Drawing.Point(596, 29);
            this.rJ_Label5.Name = "rJ_Label5";
            this.rJ_Label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label5.Size = new System.Drawing.Size(462, 43);
            this.rJ_Label5.TabIndex = 59;
            this.rJ_Label5.Text = "Numero de Documento:";
            this.rJ_Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label5.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Label4
            // 
            this.rJ_Label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rJ_Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label4.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label4.BorderRadius = 5;
            this.rJ_Label4.BorderSize = 1;
            this.rJ_Label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Label4.ForeColor = System.Drawing.Color.Black;
            this.rJ_Label4.Location = new System.Drawing.Point(178, 29);
            this.rJ_Label4.Name = "rJ_Label4";
            this.rJ_Label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label4.Size = new System.Drawing.Size(412, 43);
            this.rJ_Label4.TabIndex = 63;
            this.rJ_Label4.Text = "Detalle de Compra";
            this.rJ_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Label4.TextColor = System.Drawing.Color.Black;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUsuarioCompra);
            this.groupBox1.Controls.Add(this.txtTipoDocumentoCompra);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFechaCompra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(178, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 104);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Compra";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 31);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsuarioCompra
            // 
            this.txtUsuarioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtUsuarioCompra.BorderColor = System.Drawing.Color.DimGray;
            this.txtUsuarioCompra.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtUsuarioCompra.BorderRadius = 5;
            this.txtUsuarioCompra.BorderSize = 1;
            this.txtUsuarioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuarioCompra.Location = new System.Drawing.Point(331, 56);
            this.txtUsuarioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarioCompra.Multiline = false;
            this.txtUsuarioCompra.Name = "txtUsuarioCompra";
            this.txtUsuarioCompra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuarioCompra.PasswordChar = false;
            this.txtUsuarioCompra.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtUsuarioCompra.PlaceholderText = "";
            this.txtUsuarioCompra.ReadOnly = true;
            this.txtUsuarioCompra.Size = new System.Drawing.Size(227, 31);
            this.txtUsuarioCompra.TabIndex = 5;
            this.txtUsuarioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuarioCompra.UnderlinedStyle = false;
            // 
            // txtTipoDocumentoCompra
            // 
            this.txtTipoDocumentoCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtTipoDocumentoCompra.BorderColor = System.Drawing.Color.DimGray;
            this.txtTipoDocumentoCompra.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtTipoDocumentoCompra.BorderRadius = 5;
            this.txtTipoDocumentoCompra.BorderSize = 1;
            this.txtTipoDocumentoCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoDocumentoCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoDocumentoCompra.Location = new System.Drawing.Point(175, 56);
            this.txtTipoDocumentoCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoDocumentoCompra.Multiline = false;
            this.txtTipoDocumentoCompra.Name = "txtTipoDocumentoCompra";
            this.txtTipoDocumentoCompra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTipoDocumentoCompra.PasswordChar = false;
            this.txtTipoDocumentoCompra.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTipoDocumentoCompra.PlaceholderText = "";
            this.txtTipoDocumentoCompra.ReadOnly = true;
            this.txtTipoDocumentoCompra.Size = new System.Drawing.Size(148, 31);
            this.txtTipoDocumentoCompra.TabIndex = 4;
            this.txtTipoDocumentoCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTipoDocumentoCompra.UnderlinedStyle = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de documento:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFechaCompra
            // 
            this.txtFechaCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtFechaCompra.BorderColor = System.Drawing.Color.DimGray;
            this.txtFechaCompra.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtFechaCompra.BorderRadius = 5;
            this.txtFechaCompra.BorderSize = 1;
            this.txtFechaCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFechaCompra.Location = new System.Drawing.Point(19, 56);
            this.txtFechaCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaCompra.Multiline = false;
            this.txtFechaCompra.Name = "txtFechaCompra";
            this.txtFechaCompra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFechaCompra.PasswordChar = false;
            this.txtFechaCompra.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtFechaCompra.PlaceholderText = "";
            this.txtFechaCompra.ReadOnly = true;
            this.txtFechaCompra.Size = new System.Drawing.Size(148, 31);
            this.txtFechaCompra.TabIndex = 1;
            this.txtFechaCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaCompra.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtnumerodocumento);
            this.groupBox2.Controls.Add(this.txtRazonSocialProv);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNumeroDocProveedor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(178, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 108);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de Proveedor";
            // 
            // txtnumerodocumento
            // 
            this.txtnumerodocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtnumerodocumento.BorderColor = System.Drawing.Color.DimGray;
            this.txtnumerodocumento.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtnumerodocumento.BorderRadius = 5;
            this.txtnumerodocumento.BorderSize = 1;
            this.txtnumerodocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumerodocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtnumerodocumento.Location = new System.Drawing.Point(476, 56);
            this.txtnumerodocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtnumerodocumento.Multiline = false;
            this.txtnumerodocumento.Name = "txtnumerodocumento";
            this.txtnumerodocumento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtnumerodocumento.PasswordChar = false;
            this.txtnumerodocumento.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtnumerodocumento.PlaceholderText = "";
            this.txtnumerodocumento.ReadOnly = true;
            this.txtnumerodocumento.Size = new System.Drawing.Size(173, 31);
            this.txtnumerodocumento.TabIndex = 5;
            this.txtnumerodocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtnumerodocumento.UnderlinedStyle = false;
            // 
            // txtRazonSocialProv
            // 
            this.txtRazonSocialProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtRazonSocialProv.BorderColor = System.Drawing.Color.DimGray;
            this.txtRazonSocialProv.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtRazonSocialProv.BorderRadius = 5;
            this.txtRazonSocialProv.BorderSize = 1;
            this.txtRazonSocialProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocialProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRazonSocialProv.Location = new System.Drawing.Point(262, 56);
            this.txtRazonSocialProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocialProv.Multiline = false;
            this.txtRazonSocialProv.Name = "txtRazonSocialProv";
            this.txtRazonSocialProv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRazonSocialProv.PasswordChar = false;
            this.txtRazonSocialProv.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtRazonSocialProv.PlaceholderText = "";
            this.txtRazonSocialProv.ReadOnly = true;
            this.txtRazonSocialProv.Size = new System.Drawing.Size(206, 31);
            this.txtRazonSocialProv.TabIndex = 4;
            this.txtRazonSocialProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRazonSocialProv.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Razón Social:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumeroDocProveedor
            // 
            this.txtNumeroDocProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtNumeroDocProveedor.BorderColor = System.Drawing.Color.DimGray;
            this.txtNumeroDocProveedor.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtNumeroDocProveedor.BorderRadius = 5;
            this.txtNumeroDocProveedor.BorderSize = 1;
            this.txtNumeroDocProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroDocProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumeroDocProveedor.Location = new System.Drawing.Point(19, 56);
            this.txtNumeroDocProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumeroDocProveedor.Multiline = false;
            this.txtNumeroDocProveedor.Name = "txtNumeroDocProveedor";
            this.txtNumeroDocProveedor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNumeroDocProveedor.PasswordChar = false;
            this.txtNumeroDocProveedor.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtNumeroDocProveedor.PlaceholderText = "";
            this.txtNumeroDocProveedor.ReadOnly = true;
            this.txtNumeroDocProveedor.Size = new System.Drawing.Size(235, 31);
            this.txtNumeroDocProveedor.TabIndex = 1;
            this.txtNumeroDocProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumeroDocProveedor.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Numero de documento:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvListadoDetalleCompra
            // 
            this.dgvListadoDetalleCompra.AllowUserToAddRows = false;
            this.dgvListadoDetalleCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvListadoDetalleCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoDetalleCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoDetalleCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoDetalleCompra.BorderColor = System.Drawing.Color.DimGray;
            this.dgvListadoDetalleCompra.BorderRadius = 5;
            this.dgvListadoDetalleCompra.BorderSize = 1;
            this.dgvListadoDetalleCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvListadoDetalleCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListadoDetalleCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDetalleCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Descripcion,
            this.PrecioCompra,
            this.Cantidad,
            this.SubTotal});
            this.dgvListadoDetalleCompra.Location = new System.Drawing.Point(178, 299);
            this.dgvListadoDetalleCompra.MultiSelect = false;
            this.dgvListadoDetalleCompra.Name = "dgvListadoDetalleCompra";
            this.dgvListadoDetalleCompra.ReadOnly = true;
            dataGridViewCellStyle46.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle46.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoDetalleCompra.RowsDefaultCellStyle = dataGridViewCellStyle46;
            this.dgvListadoDetalleCompra.Size = new System.Drawing.Size(880, 428);
            this.dgvListadoDetalleCompra.TabIndex = 66;
            // 
            // txtMontoTotalCompra
            // 
            this.txtMontoTotalCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMontoTotalCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtMontoTotalCompra.BorderColor = System.Drawing.Color.DimGray;
            this.txtMontoTotalCompra.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtMontoTotalCompra.BorderRadius = 5;
            this.txtMontoTotalCompra.BorderSize = 1;
            this.txtMontoTotalCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotalCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMontoTotalCompra.Location = new System.Drawing.Point(288, 737);
            this.txtMontoTotalCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoTotalCompra.Multiline = false;
            this.txtMontoTotalCompra.Name = "txtMontoTotalCompra";
            this.txtMontoTotalCompra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMontoTotalCompra.PasswordChar = false;
            this.txtMontoTotalCompra.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtMontoTotalCompra.PlaceholderText = "";
            this.txtMontoTotalCompra.ReadOnly = true;
            this.txtMontoTotalCompra.Size = new System.Drawing.Size(99, 31);
            this.txtMontoTotalCompra.TabIndex = 67;
            this.txtMontoTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMontoTotalCompra.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 737);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 68;
            this.label4.Text = "Monto Total:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPDFDetalleCompra
            // 
            this.btnPDFDetalleCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPDFDetalleCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnPDFDetalleCompra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnPDFDetalleCompra.BorderColor = System.Drawing.Color.DimGray;
            this.btnPDFDetalleCompra.BorderRadius = 5;
            this.btnPDFDetalleCompra.BorderSize = 1;
            this.btnPDFDetalleCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDFDetalleCompra.FlatAppearance.BorderSize = 0;
            this.btnPDFDetalleCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnPDFDetalleCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(127)))));
            this.btnPDFDetalleCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDFDetalleCompra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDFDetalleCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnPDFDetalleCompra.Location = new System.Drawing.Point(895, 737);
            this.btnPDFDetalleCompra.Name = "btnPDFDetalleCompra";
            this.btnPDFDetalleCompra.Size = new System.Drawing.Size(163, 31);
            this.btnPDFDetalleCompra.TabIndex = 69;
            this.btnPDFDetalleCompra.Text = "Descargar en PDF";
            this.btnPDFDetalleCompra.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnPDFDetalleCompra.UseVisualStyleBackColor = false;
            this.btnPDFDetalleCompra.Click += new System.EventHandler(this.btnPDFDetalleCompra_Click);
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 150F;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioCompra.DefaultCellStyle = dataGridViewCellStyle40;
            this.PrecioCompra.FillWeight = 80F;
            this.PrecioCompra.HeaderText = "Precio de Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle44;
            this.Cantidad.FillWeight = 50F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            dataGridViewCellStyle45.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle45;
            this.SubTotal.FillWeight = 50F;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(484, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 30);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nro. Documento:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_DetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1303, 786);
            this.Controls.Add(this.btnPDFDetalleCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMontoTotalCompra);
            this.Controls.Add(this.dgvListadoDetalleCompra);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rJ_Label4);
            this.Controls.Add(this.btnBuscarDocumento);
            this.Controls.Add(this.btnLimpiarBusquedaDocumento);
            this.Controls.Add(this.txtBusquedaDocumento);
            this.Controls.Add(this.rJ_Label5);
            this.Controls.Add(this.rJ_Label3);
            this.Name = "Form_DetalleCompra";
            this.Text = "Form_DetalleCompra";
            this.Load += new System.EventHandler(this.Form_DetalleCompra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetalleCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls_Plus.RJ_Label rJ_Label3;
        private Custom_Controls_Plus.RJ_Button btnBuscarDocumento;
        private Custom_Controls_Plus.RJ_Button btnLimpiarBusquedaDocumento;
        private ControlsLibrary.RJ_TextBox txtBusquedaDocumento;
        private Custom_Controls_Plus.RJ_Label rJ_Label5;
        private Custom_Controls_Plus.RJ_Label rJ_Label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private ControlsLibrary.RJ_TextBox txtFechaCompra;
        private System.Windows.Forms.Label label1;
        private ControlsLibrary.RJ_TextBox txtTipoDocumentoCompra;
        private System.Windows.Forms.Label label3;
        private ControlsLibrary.RJ_TextBox txtUsuarioCompra;
        private System.Windows.Forms.GroupBox groupBox2;
        private ControlsLibrary.RJ_TextBox txtRazonSocialProv;
        private System.Windows.Forms.Label label5;
        private ControlsLibrary.RJ_TextBox txtNumeroDocProveedor;
        private System.Windows.Forms.Label label6;
        private ControlsLibrary.RJ_TextBox txtnumerodocumento;
        private Custom_Controls_Plus.RJDataGridView dgvListadoDetalleCompra;
        private ControlsLibrary.RJ_TextBox txtMontoTotalCompra;
        private System.Windows.Forms.Label label4;
        private Custom_Controls_Plus.RJ_Button btnPDFDetalleCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.Label label7;
    }
}