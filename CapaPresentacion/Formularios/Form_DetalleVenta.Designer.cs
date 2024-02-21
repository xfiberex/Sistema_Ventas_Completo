namespace CapaPresentacion.Formularios
{
    partial class Form_DetalleVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPDFDetalleVenta = new Custom_Controls_Plus.RJ_Button();
            this.txtMontoTotalVenta = new ControlsLibrary.RJ_TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListadoDetalleVenta = new Custom_Controls_Plus.RJDataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtnumerodocumento = new ControlsLibrary.RJ_TextBox();
            this.txtNombreCliente = new ControlsLibrary.RJ_TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNDocClienteVenta = new ControlsLibrary.RJ_TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuarioVenta = new ControlsLibrary.RJ_TextBox();
            this.txtTipoDocumentoVenta = new ControlsLibrary.RJ_TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaVenta = new ControlsLibrary.RJ_TextBox();
            this.rJ_Label4 = new Custom_Controls_Plus.RJ_Label();
            this.btnBuscarDocumento = new Custom_Controls_Plus.RJ_Button();
            this.btnLimpiarBusquedaDocumento = new Custom_Controls_Plus.RJ_Button();
            this.txtBusquedaDocumento = new ControlsLibrary.RJ_TextBox();
            this.rJ_Label5 = new Custom_Controls_Plus.RJ_Label();
            this.rJ_Label3 = new Custom_Controls_Plus.RJ_Label();
            this.txtMontoPago = new ControlsLibrary.RJ_TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMontoCambio = new ControlsLibrary.RJ_TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetalleVenta)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPDFDetalleVenta
            // 
            this.btnPDFDetalleVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPDFDetalleVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnPDFDetalleVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnPDFDetalleVenta.BorderColor = System.Drawing.Color.DimGray;
            this.btnPDFDetalleVenta.BorderRadius = 5;
            this.btnPDFDetalleVenta.BorderSize = 1;
            this.btnPDFDetalleVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDFDetalleVenta.FlatAppearance.BorderSize = 0;
            this.btnPDFDetalleVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnPDFDetalleVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(127)))));
            this.btnPDFDetalleVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDFDetalleVenta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDFDetalleVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnPDFDetalleVenta.Location = new System.Drawing.Point(928, 734);
            this.btnPDFDetalleVenta.Name = "btnPDFDetalleVenta";
            this.btnPDFDetalleVenta.Size = new System.Drawing.Size(163, 31);
            this.btnPDFDetalleVenta.TabIndex = 81;
            this.btnPDFDetalleVenta.Text = "Descargar en PDF";
            this.btnPDFDetalleVenta.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnPDFDetalleVenta.UseVisualStyleBackColor = false;
            this.btnPDFDetalleVenta.Click += new System.EventHandler(this.btnPDFDetalleVenta_Click);
            // 
            // txtMontoTotalVenta
            // 
            this.txtMontoTotalVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMontoTotalVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtMontoTotalVenta.BorderColor = System.Drawing.Color.DimGray;
            this.txtMontoTotalVenta.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtMontoTotalVenta.BorderRadius = 5;
            this.txtMontoTotalVenta.BorderSize = 1;
            this.txtMontoTotalVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoTotalVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMontoTotalVenta.Location = new System.Drawing.Point(321, 734);
            this.txtMontoTotalVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoTotalVenta.Multiline = false;
            this.txtMontoTotalVenta.Name = "txtMontoTotalVenta";
            this.txtMontoTotalVenta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMontoTotalVenta.PasswordChar = false;
            this.txtMontoTotalVenta.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtMontoTotalVenta.PlaceholderText = "";
            this.txtMontoTotalVenta.ReadOnly = true;
            this.txtMontoTotalVenta.Size = new System.Drawing.Size(99, 31);
            this.txtMontoTotalVenta.TabIndex = 79;
            this.txtMontoTotalVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMontoTotalVenta.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 734);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 31);
            this.label4.TabIndex = 80;
            this.label4.Text = "Monto Total:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvListadoDetalleVenta
            // 
            this.dgvListadoDetalleVenta.AllowUserToAddRows = false;
            this.dgvListadoDetalleVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvListadoDetalleVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoDetalleVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoDetalleVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoDetalleVenta.BorderColor = System.Drawing.Color.DimGray;
            this.dgvListadoDetalleVenta.BorderRadius = 5;
            this.dgvListadoDetalleVenta.BorderSize = 1;
            this.dgvListadoDetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvListadoDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListadoDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Descripcion,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            this.dgvListadoDetalleVenta.Location = new System.Drawing.Point(211, 296);
            this.dgvListadoDetalleVenta.MultiSelect = false;
            this.dgvListadoDetalleVenta.Name = "dgvListadoDetalleVenta";
            this.dgvListadoDetalleVenta.ReadOnly = true;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoDetalleVenta.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListadoDetalleVenta.Size = new System.Drawing.Size(880, 428);
            this.dgvListadoDetalleVenta.TabIndex = 78;
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
            // PrecioVenta
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioVenta.DefaultCellStyle = dataGridViewCellStyle7;
            this.PrecioVenta.FillWeight = 80F;
            this.PrecioVenta.HeaderText = "Precio de Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle8;
            this.Cantidad.FillWeight = 50F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle9;
            this.SubTotal.FillWeight = 50F;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtnumerodocumento);
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNDocClienteVenta);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(211, 182);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(880, 108);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información de Cliente";
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
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtNombreCliente.BorderColor = System.Drawing.Color.DimGray;
            this.txtNombreCliente.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtNombreCliente.BorderRadius = 5;
            this.txtNombreCliente.BorderSize = 1;
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreCliente.Location = new System.Drawing.Point(262, 56);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Multiline = false;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreCliente.PasswordChar = false;
            this.txtNombreCliente.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtNombreCliente.PlaceholderText = "";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(206, 31);
            this.txtNombreCliente.TabIndex = 4;
            this.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombreCliente.UnderlinedStyle = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre cliente:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNDocClienteVenta
            // 
            this.txtNDocClienteVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtNDocClienteVenta.BorderColor = System.Drawing.Color.DimGray;
            this.txtNDocClienteVenta.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtNDocClienteVenta.BorderRadius = 5;
            this.txtNDocClienteVenta.BorderSize = 1;
            this.txtNDocClienteVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNDocClienteVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNDocClienteVenta.Location = new System.Drawing.Point(19, 56);
            this.txtNDocClienteVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtNDocClienteVenta.Multiline = false;
            this.txtNDocClienteVenta.Name = "txtNDocClienteVenta";
            this.txtNDocClienteVenta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNDocClienteVenta.PasswordChar = false;
            this.txtNDocClienteVenta.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtNDocClienteVenta.PlaceholderText = "";
            this.txtNDocClienteVenta.ReadOnly = true;
            this.txtNDocClienteVenta.Size = new System.Drawing.Size(235, 31);
            this.txtNDocClienteVenta.TabIndex = 1;
            this.txtNDocClienteVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNDocClienteVenta.UnderlinedStyle = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Documento del cliente:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtUsuarioVenta);
            this.groupBox1.Controls.Add(this.txtTipoDocumentoVenta);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFechaVenta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(211, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(880, 104);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Venta";
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
            // txtUsuarioVenta
            // 
            this.txtUsuarioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtUsuarioVenta.BorderColor = System.Drawing.Color.DimGray;
            this.txtUsuarioVenta.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtUsuarioVenta.BorderRadius = 5;
            this.txtUsuarioVenta.BorderSize = 1;
            this.txtUsuarioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsuarioVenta.Location = new System.Drawing.Point(331, 56);
            this.txtUsuarioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuarioVenta.Multiline = false;
            this.txtUsuarioVenta.Name = "txtUsuarioVenta";
            this.txtUsuarioVenta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsuarioVenta.PasswordChar = false;
            this.txtUsuarioVenta.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtUsuarioVenta.PlaceholderText = "";
            this.txtUsuarioVenta.ReadOnly = true;
            this.txtUsuarioVenta.Size = new System.Drawing.Size(227, 31);
            this.txtUsuarioVenta.TabIndex = 5;
            this.txtUsuarioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUsuarioVenta.UnderlinedStyle = false;
            // 
            // txtTipoDocumentoVenta
            // 
            this.txtTipoDocumentoVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtTipoDocumentoVenta.BorderColor = System.Drawing.Color.DimGray;
            this.txtTipoDocumentoVenta.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtTipoDocumentoVenta.BorderRadius = 5;
            this.txtTipoDocumentoVenta.BorderSize = 1;
            this.txtTipoDocumentoVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoDocumentoVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTipoDocumentoVenta.Location = new System.Drawing.Point(175, 56);
            this.txtTipoDocumentoVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipoDocumentoVenta.Multiline = false;
            this.txtTipoDocumentoVenta.Name = "txtTipoDocumentoVenta";
            this.txtTipoDocumentoVenta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTipoDocumentoVenta.PasswordChar = false;
            this.txtTipoDocumentoVenta.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTipoDocumentoVenta.PlaceholderText = "";
            this.txtTipoDocumentoVenta.ReadOnly = true;
            this.txtTipoDocumentoVenta.Size = new System.Drawing.Size(148, 31);
            this.txtTipoDocumentoVenta.TabIndex = 4;
            this.txtTipoDocumentoVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTipoDocumentoVenta.UnderlinedStyle = false;
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
            // txtFechaVenta
            // 
            this.txtFechaVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtFechaVenta.BorderColor = System.Drawing.Color.DimGray;
            this.txtFechaVenta.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtFechaVenta.BorderRadius = 5;
            this.txtFechaVenta.BorderSize = 1;
            this.txtFechaVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFechaVenta.Location = new System.Drawing.Point(19, 56);
            this.txtFechaVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaVenta.Multiline = false;
            this.txtFechaVenta.Name = "txtFechaVenta";
            this.txtFechaVenta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFechaVenta.PasswordChar = false;
            this.txtFechaVenta.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtFechaVenta.PlaceholderText = "";
            this.txtFechaVenta.ReadOnly = true;
            this.txtFechaVenta.Size = new System.Drawing.Size(148, 31);
            this.txtFechaVenta.TabIndex = 1;
            this.txtFechaVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaVenta.UnderlinedStyle = false;
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
            this.rJ_Label4.Location = new System.Drawing.Point(211, 26);
            this.rJ_Label4.Name = "rJ_Label4";
            this.rJ_Label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label4.Size = new System.Drawing.Size(412, 43);
            this.rJ_Label4.TabIndex = 75;
            this.rJ_Label4.Text = "Detalle de Venta";
            this.rJ_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Label4.TextColor = System.Drawing.Color.Black;
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
            this.btnBuscarDocumento.Location = new System.Drawing.Point(995, 33);
            this.btnBuscarDocumento.Name = "btnBuscarDocumento";
            this.btnBuscarDocumento.Padding = new System.Windows.Forms.Padding(5);
            this.btnBuscarDocumento.Size = new System.Drawing.Size(40, 31);
            this.btnBuscarDocumento.TabIndex = 74;
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
            this.btnLimpiarBusquedaDocumento.Location = new System.Drawing.Point(1041, 33);
            this.btnLimpiarBusquedaDocumento.Name = "btnLimpiarBusquedaDocumento";
            this.btnLimpiarBusquedaDocumento.Padding = new System.Windows.Forms.Padding(5);
            this.btnLimpiarBusquedaDocumento.Size = new System.Drawing.Size(40, 31);
            this.btnLimpiarBusquedaDocumento.TabIndex = 73;
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
            this.txtBusquedaDocumento.Location = new System.Drawing.Point(832, 33);
            this.txtBusquedaDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaDocumento.Multiline = false;
            this.txtBusquedaDocumento.Name = "txtBusquedaDocumento";
            this.txtBusquedaDocumento.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusquedaDocumento.PasswordChar = false;
            this.txtBusquedaDocumento.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtBusquedaDocumento.PlaceholderText = "Ingrese el numero...";
            this.txtBusquedaDocumento.ReadOnly = false;
            this.txtBusquedaDocumento.Size = new System.Drawing.Size(156, 31);
            this.txtBusquedaDocumento.TabIndex = 72;
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
            this.rJ_Label5.Location = new System.Drawing.Point(629, 26);
            this.rJ_Label5.Name = "rJ_Label5";
            this.rJ_Label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label5.Size = new System.Drawing.Size(462, 43);
            this.rJ_Label5.TabIndex = 71;
            this.rJ_Label5.Text = "Numero de Documento:";
            this.rJ_Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label5.TextColor = System.Drawing.Color.Black;
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
            this.rJ_Label3.Location = new System.Drawing.Point(196, 9);
            this.rJ_Label3.Name = "rJ_Label3";
            this.rJ_Label3.Size = new System.Drawing.Size(910, 768);
            this.rJ_Label3.TabIndex = 70;
            this.rJ_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Label3.TextColor = System.Drawing.Color.White;
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMontoPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtMontoPago.BorderColor = System.Drawing.Color.DimGray;
            this.txtMontoPago.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtMontoPago.BorderRadius = 5;
            this.txtMontoPago.BorderSize = 1;
            this.txtMontoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMontoPago.Location = new System.Drawing.Point(524, 734);
            this.txtMontoPago.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoPago.Multiline = false;
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMontoPago.PasswordChar = false;
            this.txtMontoPago.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtMontoPago.PlaceholderText = "";
            this.txtMontoPago.ReadOnly = true;
            this.txtMontoPago.Size = new System.Drawing.Size(99, 31);
            this.txtMontoPago.TabIndex = 82;
            this.txtMontoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMontoPago.UnderlinedStyle = false;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(428, 734);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 31);
            this.label8.TabIndex = 83;
            this.label8.Text = "Monto Pago:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMontoCambio
            // 
            this.txtMontoCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMontoCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtMontoCambio.BorderColor = System.Drawing.Color.DimGray;
            this.txtMontoCambio.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtMontoCambio.BorderRadius = 5;
            this.txtMontoCambio.BorderSize = 1;
            this.txtMontoCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontoCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMontoCambio.Location = new System.Drawing.Point(744, 734);
            this.txtMontoCambio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoCambio.Multiline = false;
            this.txtMontoCambio.Name = "txtMontoCambio";
            this.txtMontoCambio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMontoCambio.PasswordChar = false;
            this.txtMontoCambio.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtMontoCambio.PlaceholderText = "";
            this.txtMontoCambio.ReadOnly = true;
            this.txtMontoCambio.Size = new System.Drawing.Size(99, 31);
            this.txtMontoCambio.TabIndex = 84;
            this.txtMontoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMontoCambio.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(630, 734);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 31);
            this.label9.TabIndex = 85;
            this.label9.Text = "Monto Cambio:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form_DetalleVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1303, 786);
            this.Controls.Add(this.txtMontoCambio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMontoPago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPDFDetalleVenta);
            this.Controls.Add(this.txtMontoTotalVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvListadoDetalleVenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rJ_Label4);
            this.Controls.Add(this.btnBuscarDocumento);
            this.Controls.Add(this.btnLimpiarBusquedaDocumento);
            this.Controls.Add(this.txtBusquedaDocumento);
            this.Controls.Add(this.rJ_Label5);
            this.Controls.Add(this.rJ_Label3);
            this.Name = "Form_DetalleVenta";
            this.Text = "Form_DetalleVenta";
            this.Load += new System.EventHandler(this.Form_DetalleVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDetalleVenta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls_Plus.RJ_Button btnPDFDetalleVenta;
        private ControlsLibrary.RJ_TextBox txtMontoTotalVenta;
        private System.Windows.Forms.Label label4;
        private Custom_Controls_Plus.RJDataGridView dgvListadoDetalleVenta;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private ControlsLibrary.RJ_TextBox txtnumerodocumento;
        private ControlsLibrary.RJ_TextBox txtNombreCliente;
        private System.Windows.Forms.Label label5;
        private ControlsLibrary.RJ_TextBox txtNDocClienteVenta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private ControlsLibrary.RJ_TextBox txtUsuarioVenta;
        private ControlsLibrary.RJ_TextBox txtTipoDocumentoVenta;
        private System.Windows.Forms.Label label2;
        private ControlsLibrary.RJ_TextBox txtFechaVenta;
        private Custom_Controls_Plus.RJ_Label rJ_Label4;
        private Custom_Controls_Plus.RJ_Button btnBuscarDocumento;
        private Custom_Controls_Plus.RJ_Button btnLimpiarBusquedaDocumento;
        private ControlsLibrary.RJ_TextBox txtBusquedaDocumento;
        private Custom_Controls_Plus.RJ_Label rJ_Label5;
        private Custom_Controls_Plus.RJ_Label rJ_Label3;
        private ControlsLibrary.RJ_TextBox txtMontoPago;
        private System.Windows.Forms.Label label8;
        private ControlsLibrary.RJ_TextBox txtMontoCambio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}