namespace CapaPresentacion.Formularios
{
    partial class Form_Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDescripProductoCliente = new ControlsLibrary.RJ_TextBox();
            this.txtNombreProductoCliente = new ControlsLibrary.RJ_TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudCantidadProductoCliente = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTPProductoCliente = new ControlsLibrary.RJ_TextBox();
            this.dgvListadoVenta = new Custom_Controls_Plus.RJDataGridView();
            this.txtStockCliente = new ControlsLibrary.RJ_TextBox();
            this.rJ_Label2 = new Custom_Controls_Plus.RJ_Label();
            this.rJ_Label3 = new Custom_Controls_Plus.RJ_Label();
            this.btnAgregarProdCliente = new Custom_Controls_Plus.RJ_Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTipoDocumentoCliente = new System.Windows.Forms.ComboBox();
            this.txtFechaCliente = new ControlsLibrary.RJ_TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNombreCliente = new ControlsLibrary.RJ_TextBox();
            this.btnBuscarCliente = new Custom_Controls_Plus.RJ_Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumentoCliente = new ControlsLibrary.RJ_TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegistrarVenta = new Custom_Controls_Plus.RJ_Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPrecioCliente = new ControlsLibrary.RJ_TextBox();
            this.txtIdProductoCliente = new ControlsLibrary.RJ_TextBox();
            this.btnBuscarProductoCliente = new Custom_Controls_Plus.RJ_Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodProdCliente = new ControlsLibrary.RJ_TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tx = new System.Windows.Forms.Label();
            this.txtPagaCon = new ControlsLibrary.RJ_TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCambio = new ControlsLibrary.RJ_TextBox();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProductoCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoVenta)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1037, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 31);
            this.label10.TabIndex = 46;
            this.label10.Text = "Total a Pagar:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(408, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 31);
            this.label11.TabIndex = 39;
            this.label11.Text = "Descripción:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripProductoCliente
            // 
            this.txtDescripProductoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtDescripProductoCliente.BorderColor = System.Drawing.Color.DimGray;
            this.txtDescripProductoCliente.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtDescripProductoCliente.BorderRadius = 5;
            this.txtDescripProductoCliente.BorderSize = 1;
            this.txtDescripProductoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripProductoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDescripProductoCliente.Location = new System.Drawing.Point(401, 56);
            this.txtDescripProductoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripProductoCliente.Multiline = false;
            this.txtDescripProductoCliente.Name = "txtDescripProductoCliente";
            this.txtDescripProductoCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescripProductoCliente.PasswordChar = false;
            this.txtDescripProductoCliente.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDescripProductoCliente.PlaceholderText = "";
            this.txtDescripProductoCliente.ReadOnly = true;
            this.txtDescripProductoCliente.Size = new System.Drawing.Size(208, 31);
            this.txtDescripProductoCliente.TabIndex = 38;
            this.txtDescripProductoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripProductoCliente.UnderlinedStyle = false;
            // 
            // txtNombreProductoCliente
            // 
            this.txtNombreProductoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtNombreProductoCliente.BorderColor = System.Drawing.Color.DimGray;
            this.txtNombreProductoCliente.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtNombreProductoCliente.BorderRadius = 5;
            this.txtNombreProductoCliente.BorderSize = 1;
            this.txtNombreProductoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProductoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombreProductoCliente.Location = new System.Drawing.Point(264, 56);
            this.txtNombreProductoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProductoCliente.Multiline = false;
            this.txtNombreProductoCliente.Name = "txtNombreProductoCliente";
            this.txtNombreProductoCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreProductoCliente.PasswordChar = false;
            this.txtNombreProductoCliente.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtNombreProductoCliente.PlaceholderText = "";
            this.txtNombreProductoCliente.ReadOnly = true;
            this.txtNombreProductoCliente.Size = new System.Drawing.Size(129, 31);
            this.txtNombreProductoCliente.TabIndex = 37;
            this.txtNombreProductoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreProductoCliente.UnderlinedStyle = false;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(905, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 31);
            this.label9.TabIndex = 36;
            this.label9.Text = "Cantidad:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudCantidadProductoCliente
            // 
            this.nudCantidadProductoCliente.Location = new System.Drawing.Point(895, 62);
            this.nudCantidadProductoCliente.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadProductoCliente.Name = "nudCantidadProductoCliente";
            this.nudCantidadProductoCliente.Size = new System.Drawing.Size(112, 25);
            this.nudCantidadProductoCliente.TabIndex = 35;
            this.nudCantidadProductoCliente.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(767, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 31);
            this.label8.TabIndex = 34;
            this.label8.Text = "Stock:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTPProductoCliente
            // 
            this.txtTPProductoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTPProductoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtTPProductoCliente.BorderColor = System.Drawing.Color.DimGray;
            this.txtTPProductoCliente.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtTPProductoCliente.BorderRadius = 5;
            this.txtTPProductoCliente.BorderSize = 1;
            this.txtTPProductoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTPProductoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTPProductoCliente.Location = new System.Drawing.Point(1030, 543);
            this.txtTPProductoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtTPProductoCliente.Multiline = false;
            this.txtTPProductoCliente.Name = "txtTPProductoCliente";
            this.txtTPProductoCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTPProductoCliente.PasswordChar = false;
            this.txtTPProductoCliente.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTPProductoCliente.PlaceholderText = "";
            this.txtTPProductoCliente.ReadOnly = true;
            this.txtTPProductoCliente.Size = new System.Drawing.Size(133, 31);
            this.txtTPProductoCliente.TabIndex = 45;
            this.txtTPProductoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTPProductoCliente.UnderlinedStyle = false;
            // 
            // dgvListadoVenta
            // 
            this.dgvListadoVenta.AllowUserToAddRows = false;
            this.dgvListadoVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvListadoVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoVenta.BorderColor = System.Drawing.Color.DimGray;
            this.dgvListadoVenta.BorderRadius = 5;
            this.dgvListadoVenta.BorderSize = 1;
            this.dgvListadoVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvListadoVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Descripcion,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btnEliminarProducto});
            this.dgvListadoVenta.Location = new System.Drawing.Point(143, 301);
            this.dgvListadoVenta.MultiSelect = false;
            this.dgvListadoVenta.Name = "dgvListadoVenta";
            this.dgvListadoVenta.ReadOnly = true;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoVenta.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListadoVenta.Size = new System.Drawing.Size(880, 460);
            this.dgvListadoVenta.TabIndex = 42;
            this.dgvListadoVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoVenta_CellContentClick);
            this.dgvListadoVenta.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListadoVenta_CellPainting);
            // 
            // txtStockCliente
            // 
            this.txtStockCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtStockCliente.BorderColor = System.Drawing.Color.DimGray;
            this.txtStockCliente.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtStockCliente.BorderRadius = 5;
            this.txtStockCliente.BorderSize = 1;
            this.txtStockCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStockCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStockCliente.Location = new System.Drawing.Point(757, 56);
            this.txtStockCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtStockCliente.Multiline = false;
            this.txtStockCliente.Name = "txtStockCliente";
            this.txtStockCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtStockCliente.PasswordChar = false;
            this.txtStockCliente.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtStockCliente.PlaceholderText = "";
            this.txtStockCliente.ReadOnly = true;
            this.txtStockCliente.Size = new System.Drawing.Size(133, 31);
            this.txtStockCliente.TabIndex = 33;
            this.txtStockCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtStockCliente.UnderlinedStyle = false;
            // 
            // rJ_Label2
            // 
            this.rJ_Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label2.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label2.BorderRadius = 5;
            this.rJ_Label2.BorderSize = 1;
            this.rJ_Label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Label2.ForeColor = System.Drawing.Color.Black;
            this.rJ_Label2.Location = new System.Drawing.Point(143, 23);
            this.rJ_Label2.Name = "rJ_Label2";
            this.rJ_Label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label2.Size = new System.Drawing.Size(1017, 43);
            this.rJ_Label2.TabIndex = 38;
            this.rJ_Label2.Text = "Registrar Venta";
            this.rJ_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Label2.TextColor = System.Drawing.Color.Black;
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
            this.rJ_Label3.Location = new System.Drawing.Point(126, 9);
            this.rJ_Label3.Name = "rJ_Label3";
            this.rJ_Label3.Size = new System.Drawing.Size(1050, 768);
            this.rJ_Label3.TabIndex = 44;
            this.rJ_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Label3.TextColor = System.Drawing.Color.White;
            // 
            // btnAgregarProdCliente
            // 
            this.btnAgregarProdCliente.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarProdCliente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnAgregarProdCliente.BorderColor = System.Drawing.Color.DimGray;
            this.btnAgregarProdCliente.BorderRadius = 5;
            this.btnAgregarProdCliente.BorderSize = 1;
            this.btnAgregarProdCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProdCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarProdCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnAgregarProdCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarProdCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProdCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProdCliente.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProdCliente.Image = global::CapaPresentacion.Properties.Resources.Plus;
            this.btnAgregarProdCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarProdCliente.Location = new System.Drawing.Point(1030, 301);
            this.btnAgregarProdCliente.Name = "btnAgregarProdCliente";
            this.btnAgregarProdCliente.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnAgregarProdCliente.Size = new System.Drawing.Size(131, 58);
            this.btnAgregarProdCliente.TabIndex = 43;
            this.btnAgregarProdCliente.Text = "Agregar";
            this.btnAgregarProdCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarProdCliente.TextColor = System.Drawing.Color.Black;
            this.btnAgregarProdCliente.UseVisualStyleBackColor = false;
            this.btnAgregarProdCliente.Click += new System.EventHandler(this.btnAgregarProdCliente_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(626, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 31);
            this.label7.TabIndex = 32;
            this.label7.Text = "Precio:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbTipoDocumentoCliente);
            this.groupBox1.Controls.Add(this.txtFechaCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(143, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 104);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Venta";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(184, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de documento:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbTipoDocumentoCliente
            // 
            this.cbbTipoDocumentoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbbTipoDocumentoCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoDocumentoCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoDocumentoCliente.FormattingEnabled = true;
            this.cbbTipoDocumentoCliente.Location = new System.Drawing.Point(174, 62);
            this.cbbTipoDocumentoCliente.Name = "cbbTipoDocumentoCliente";
            this.cbbTipoDocumentoCliente.Size = new System.Drawing.Size(205, 25);
            this.cbbTipoDocumentoCliente.TabIndex = 2;
            // 
            // txtFechaCliente
            // 
            this.txtFechaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtFechaCliente.BorderColor = System.Drawing.Color.DimGray;
            this.txtFechaCliente.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtFechaCliente.BorderRadius = 5;
            this.txtFechaCliente.BorderSize = 1;
            this.txtFechaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFechaCliente.Location = new System.Drawing.Point(19, 56);
            this.txtFechaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaCliente.Multiline = false;
            this.txtFechaCliente.Name = "txtFechaCliente";
            this.txtFechaCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFechaCliente.PasswordChar = false;
            this.txtFechaCliente.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtFechaCliente.PlaceholderText = "";
            this.txtFechaCliente.ReadOnly = true;
            this.txtFechaCliente.Size = new System.Drawing.Size(148, 31);
            this.txtFechaCliente.TabIndex = 1;
            this.txtFechaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaCliente.UnderlinedStyle = false;
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
            this.groupBox2.Controls.Add(this.txtNombreCliente);
            this.groupBox2.Controls.Add(this.btnBuscarCliente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDocumentoCliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(541, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 104);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del Cliente";
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
            this.txtNombreCliente.Location = new System.Drawing.Point(264, 56);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Multiline = false;
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreCliente.PasswordChar = false;
            this.txtNombreCliente.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtNombreCliente.PlaceholderText = "";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(204, 31);
            this.txtNombreCliente.TabIndex = 30;
            this.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreCliente.UnderlinedStyle = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBuscarCliente.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscarCliente.BorderRadius = 5;
            this.btnBuscarCliente.BorderSize = 1;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarCliente.Image = global::CapaPresentacion.Properties.Resources.SearchBlack;
            this.btnBuscarCliente.Location = new System.Drawing.Point(217, 56);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Padding = new System.Windows.Forms.Padding(5);
            this.btnBuscarCliente.Size = new System.Drawing.Size(40, 31);
            this.btnBuscarCliente.TabIndex = 29;
            this.btnBuscarCliente.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre completo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtDocumentoCliente.BorderColor = System.Drawing.Color.DimGray;
            this.txtDocumentoCliente.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtDocumentoCliente.BorderRadius = 5;
            this.txtDocumentoCliente.BorderSize = 1;
            this.txtDocumentoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDocumentoCliente.Location = new System.Drawing.Point(19, 56);
            this.txtDocumentoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumentoCliente.Multiline = false;
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDocumentoCliente.PasswordChar = false;
            this.txtDocumentoCliente.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDocumentoCliente.PlaceholderText = "";
            this.txtDocumentoCliente.ReadOnly = false;
            this.txtDocumentoCliente.Size = new System.Drawing.Size(191, 31);
            this.txtDocumentoCliente.TabIndex = 1;
            this.txtDocumentoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDocumentoCliente.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Número de documento:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistrarVenta.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarVenta.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarVenta.BorderColor = System.Drawing.Color.DimGray;
            this.btnRegistrarVenta.BorderRadius = 5;
            this.btnRegistrarVenta.BorderSize = 1;
            this.btnRegistrarVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarVenta.FlatAppearance.BorderSize = 0;
            this.btnRegistrarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnRegistrarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarVenta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarVenta.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarVenta.Image = global::CapaPresentacion.Properties.Resources.Add_Tag;
            this.btnRegistrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarVenta.Location = new System.Drawing.Point(1030, 721);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.btnRegistrarVenta.Size = new System.Drawing.Size(133, 40);
            this.btnRegistrarVenta.TabIndex = 47;
            this.btnRegistrarVenta.Text = "Crear Venta";
            this.btnRegistrarVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarVenta.TextColor = System.Drawing.Color.Black;
            this.btnRegistrarVenta.UseVisualStyleBackColor = false;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtDescripProductoCliente);
            this.groupBox3.Controls.Add(this.txtNombreProductoCliente);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.nudCantidadProductoCliente);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtStockCliente);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtPrecioCliente);
            this.groupBox3.Controls.Add(this.txtIdProductoCliente);
            this.groupBox3.Controls.Add(this.btnBuscarProductoCliente);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCodProdCliente);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(143, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1017, 104);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información del Producto";
            // 
            // txtPrecioCliente
            // 
            this.txtPrecioCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtPrecioCliente.BorderColor = System.Drawing.Color.DimGray;
            this.txtPrecioCliente.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPrecioCliente.BorderRadius = 5;
            this.txtPrecioCliente.BorderSize = 1;
            this.txtPrecioCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioCliente.Location = new System.Drawing.Point(616, 56);
            this.txtPrecioCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioCliente.Multiline = false;
            this.txtPrecioCliente.Name = "txtPrecioCliente";
            this.txtPrecioCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecioCliente.PasswordChar = false;
            this.txtPrecioCliente.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPrecioCliente.PlaceholderText = "";
            this.txtPrecioCliente.ReadOnly = false;
            this.txtPrecioCliente.Size = new System.Drawing.Size(133, 31);
            this.txtPrecioCliente.TabIndex = 31;
            this.txtPrecioCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecioCliente.UnderlinedStyle = false;
            this.txtPrecioCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCliente_KeyPress);
            // 
            // txtIdProductoCliente
            // 
            this.txtIdProductoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtIdProductoCliente.BorderColor = System.Drawing.Color.DimGray;
            this.txtIdProductoCliente.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtIdProductoCliente.BorderRadius = 5;
            this.txtIdProductoCliente.BorderSize = 1;
            this.txtIdProductoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProductoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdProductoCliente.Location = new System.Drawing.Point(163, 21);
            this.txtIdProductoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProductoCliente.Multiline = false;
            this.txtIdProductoCliente.Name = "txtIdProductoCliente";
            this.txtIdProductoCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIdProductoCliente.PasswordChar = false;
            this.txtIdProductoCliente.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtIdProductoCliente.PlaceholderText = "";
            this.txtIdProductoCliente.ReadOnly = true;
            this.txtIdProductoCliente.Size = new System.Drawing.Size(47, 31);
            this.txtIdProductoCliente.TabIndex = 30;
            this.txtIdProductoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdProductoCliente.UnderlinedStyle = false;
            // 
            // btnBuscarProductoCliente
            // 
            this.btnBuscarProductoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProductoCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProductoCliente.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBuscarProductoCliente.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscarProductoCliente.BorderRadius = 5;
            this.btnBuscarProductoCliente.BorderSize = 1;
            this.btnBuscarProductoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProductoCliente.FlatAppearance.BorderSize = 0;
            this.btnBuscarProductoCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarProductoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarProductoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProductoCliente.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProductoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarProductoCliente.Image = global::CapaPresentacion.Properties.Resources.SearchBlack;
            this.btnBuscarProductoCliente.Location = new System.Drawing.Point(217, 56);
            this.btnBuscarProductoCliente.Name = "btnBuscarProductoCliente";
            this.btnBuscarProductoCliente.Padding = new System.Windows.Forms.Padding(5);
            this.btnBuscarProductoCliente.Size = new System.Drawing.Size(40, 31);
            this.btnBuscarProductoCliente.TabIndex = 29;
            this.btnBuscarProductoCliente.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarProductoCliente.UseVisualStyleBackColor = false;
            this.btnBuscarProductoCliente.Click += new System.EventHandler(this.btnBuscarProductoCliente_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(271, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 31);
            this.label5.TabIndex = 3;
            this.label5.Text = "Producto:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodProdCliente
            // 
            this.txtCodProdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtCodProdCliente.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodProdCliente.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtCodProdCliente.BorderRadius = 5;
            this.txtCodProdCliente.BorderSize = 1;
            this.txtCodProdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodProdCliente.Location = new System.Drawing.Point(19, 56);
            this.txtCodProdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodProdCliente.Multiline = false;
            this.txtCodProdCliente.Name = "txtCodProdCliente";
            this.txtCodProdCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodProdCliente.PasswordChar = false;
            this.txtCodProdCliente.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtCodProdCliente.PlaceholderText = "";
            this.txtCodProdCliente.ReadOnly = false;
            this.txtCodProdCliente.Size = new System.Drawing.Size(191, 31);
            this.txtCodProdCliente.TabIndex = 1;
            this.txtCodProdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodProdCliente.UnderlinedStyle = false;
            this.txtCodProdCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProdCliente_KeyDown);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Codigo de producto:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tx
            // 
            this.tx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tx.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx.Location = new System.Drawing.Point(1037, 578);
            this.tx.Name = "tx";
            this.tx.Size = new System.Drawing.Size(108, 31);
            this.tx.TabIndex = 49;
            this.tx.Text = "Paga con:";
            this.tx.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPagaCon
            // 
            this.txtPagaCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPagaCon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtPagaCon.BorderColor = System.Drawing.Color.DimGray;
            this.txtPagaCon.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPagaCon.BorderRadius = 5;
            this.txtPagaCon.BorderSize = 1;
            this.txtPagaCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPagaCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPagaCon.Location = new System.Drawing.Point(1030, 613);
            this.txtPagaCon.Margin = new System.Windows.Forms.Padding(4);
            this.txtPagaCon.Multiline = false;
            this.txtPagaCon.Name = "txtPagaCon";
            this.txtPagaCon.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPagaCon.PasswordChar = false;
            this.txtPagaCon.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPagaCon.PlaceholderText = "";
            this.txtPagaCon.ReadOnly = false;
            this.txtPagaCon.Size = new System.Drawing.Size(133, 31);
            this.txtPagaCon.TabIndex = 48;
            this.txtPagaCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPagaCon.UnderlinedStyle = false;
            this.txtPagaCon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPagaCon_KeyDown);
            this.txtPagaCon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPagaCon_KeyPress);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1037, 648);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 31);
            this.label13.TabIndex = 51;
            this.label13.Text = "Cambio:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCambio
            // 
            this.txtCambio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtCambio.BorderColor = System.Drawing.Color.DimGray;
            this.txtCambio.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtCambio.BorderRadius = 5;
            this.txtCambio.BorderSize = 1;
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCambio.Location = new System.Drawing.Point(1030, 683);
            this.txtCambio.Margin = new System.Windows.Forms.Padding(4);
            this.txtCambio.Multiline = false;
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCambio.PasswordChar = false;
            this.txtCambio.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtCambio.PlaceholderText = "";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(133, 31);
            this.txtCambio.TabIndex = 50;
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCambio.UnderlinedStyle = false;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "ID";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrecioVenta.FillWeight = 80F;
            this.PrecioVenta.HeaderText = "Precio";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.Cantidad.FillWeight = 50F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.SubTotal.FillWeight = 50F;
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.FillWeight = 20F;
            this.btnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProducto.HeaderText = "";
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.ReadOnly = true;
            this.btnEliminarProducto.Text = "";
            // 
            // Form_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1303, 786);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.tx);
            this.Controls.Add(this.txtPagaCon);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTPProductoCliente);
            this.Controls.Add(this.dgvListadoVenta);
            this.Controls.Add(this.rJ_Label2);
            this.Controls.Add(this.btnAgregarProdCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.rJ_Label3);
            this.Name = "Form_Ventas";
            this.Text = "Form_Ventas";
            this.Load += new System.EventHandler(this.Form_Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProductoCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoVenta)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private ControlsLibrary.RJ_TextBox txtDescripProductoCliente;
        private ControlsLibrary.RJ_TextBox txtNombreProductoCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudCantidadProductoCliente;
        private System.Windows.Forms.Label label8;
        private ControlsLibrary.RJ_TextBox txtTPProductoCliente;
        private Custom_Controls_Plus.RJDataGridView dgvListadoVenta;
        private ControlsLibrary.RJ_TextBox txtStockCliente;
        private Custom_Controls_Plus.RJ_Label rJ_Label2;
        private Custom_Controls_Plus.RJ_Label rJ_Label3;
        private Custom_Controls_Plus.RJ_Button btnAgregarProdCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbTipoDocumentoCliente;
        private ControlsLibrary.RJ_TextBox txtFechaCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ControlsLibrary.RJ_TextBox txtNombreCliente;
        private Custom_Controls_Plus.RJ_Button btnBuscarCliente;
        private System.Windows.Forms.Label label3;
        private ControlsLibrary.RJ_TextBox txtDocumentoCliente;
        private System.Windows.Forms.Label label4;
        private Custom_Controls_Plus.RJ_Button btnRegistrarVenta;
        private System.Windows.Forms.GroupBox groupBox3;
        private ControlsLibrary.RJ_TextBox txtPrecioCliente;
        private ControlsLibrary.RJ_TextBox txtIdProductoCliente;
        private Custom_Controls_Plus.RJ_Button btnBuscarProductoCliente;
        private System.Windows.Forms.Label label5;
        private ControlsLibrary.RJ_TextBox txtCodProdCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label tx;
        private ControlsLibrary.RJ_TextBox txtPagaCon;
        private System.Windows.Forms.Label label13;
        private ControlsLibrary.RJ_TextBox txtCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminarProducto;
    }
}