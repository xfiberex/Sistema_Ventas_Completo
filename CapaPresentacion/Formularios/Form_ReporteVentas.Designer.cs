﻿namespace CapaPresentacion.Formularios
{
    partial class Form_ReporteVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnExcel = new Custom_Controls_Plus.RJ_Button();
            this.btnBuscarPor = new Custom_Controls_Plus.RJ_Button();
            this.btnLimpiarBusqueda = new Custom_Controls_Plus.RJ_Button();
            this.txtBusqueda = new ControlsLibrary.RJ_TextBox();
            this.cbbBuscar = new System.Windows.Forms.ComboBox();
            this.rJ_Label6 = new Custom_Controls_Plus.RJ_Label();
            this.rJ_Label3 = new Custom_Controls_Plus.RJ_Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.rJ_Label4 = new Custom_Controls_Plus.RJ_Label();
            this.dgvListadoReporteVT = new Custom_Controls_Plus.RJDataGridView();
            this.FechaRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UsuarioRegistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocumentoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rJ_Label2 = new Custom_Controls_Plus.RJ_Label();
            this.rJ_Label1 = new Custom_Controls_Plus.RJ_Label();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarReporteVT = new Custom_Controls_Plus.RJ_Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoReporteVT)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.btnExcel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.btnExcel.BorderColor = System.Drawing.Color.DimGray;
            this.btnExcel.BorderRadius = 5;
            this.btnExcel.BorderSize = 1;
            this.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(124)))), ((int)(((byte)(65)))));
            this.btnExcel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(167)))), ((int)(((byte)(128)))));
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnExcel.Location = new System.Drawing.Point(34, 72);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(152, 31);
            this.btnExcel.TabIndex = 75;
            this.btnExcel.Text = "Exportar a Excel";
            this.btnExcel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnBuscarPor
            // 
            this.btnBuscarPor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarPor.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarPor.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBuscarPor.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscarPor.BorderRadius = 5;
            this.btnBuscarPor.BorderSize = 1;
            this.btnBuscarPor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarPor.FlatAppearance.BorderSize = 0;
            this.btnBuscarPor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarPor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarPor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarPor.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarPor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarPor.Image = global::CapaPresentacion.Properties.Resources.SearchBlack;
            this.btnBuscarPor.Location = new System.Drawing.Point(975, 75);
            this.btnBuscarPor.Name = "btnBuscarPor";
            this.btnBuscarPor.Padding = new System.Windows.Forms.Padding(5);
            this.btnBuscarPor.Size = new System.Drawing.Size(40, 31);
            this.btnBuscarPor.TabIndex = 74;
            this.btnBuscarPor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarPor.UseVisualStyleBackColor = false;
            this.btnBuscarPor.Click += new System.EventHandler(this.btnBuscarPor_Click);
            // 
            // btnLimpiarBusqueda
            // 
            this.btnLimpiarBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBusqueda.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBusqueda.BorderColor = System.Drawing.Color.DimGray;
            this.btnLimpiarBusqueda.BorderRadius = 5;
            this.btnLimpiarBusqueda.BorderSize = 1;
            this.btnLimpiarBusqueda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBusqueda.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBusqueda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnLimpiarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusqueda.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusqueda.Image = global::CapaPresentacion.Properties.Resources.BroomBlack;
            this.btnLimpiarBusqueda.Location = new System.Drawing.Point(1021, 75);
            this.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda";
            this.btnLimpiarBusqueda.Padding = new System.Windows.Forms.Padding(5);
            this.btnLimpiarBusqueda.Size = new System.Drawing.Size(40, 31);
            this.btnLimpiarBusqueda.TabIndex = 73;
            this.btnLimpiarBusqueda.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusqueda.UseVisualStyleBackColor = false;
            this.btnLimpiarBusqueda.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtBusqueda.BorderColor = System.Drawing.Color.DimGray;
            this.txtBusqueda.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtBusqueda.BorderRadius = 5;
            this.txtBusqueda.BorderSize = 1;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusqueda.Location = new System.Drawing.Point(815, 75);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusqueda.Multiline = false;
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusqueda.PasswordChar = false;
            this.txtBusqueda.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtBusqueda.PlaceholderText = "Ingrese lo que busca...";
            this.txtBusqueda.ReadOnly = false;
            this.txtBusqueda.Size = new System.Drawing.Size(153, 31);
            this.txtBusqueda.TabIndex = 72;
            this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBusqueda.UnderlinedStyle = true;
            // 
            // cbbBuscar
            // 
            this.cbbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbbBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBuscar.FormattingEnabled = true;
            this.cbbBuscar.Location = new System.Drawing.Point(664, 79);
            this.cbbBuscar.Name = "cbbBuscar";
            this.cbbBuscar.Size = new System.Drawing.Size(144, 25);
            this.cbbBuscar.TabIndex = 71;
            // 
            // rJ_Label6
            // 
            this.rJ_Label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rJ_Label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label6.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label6.BorderRadius = 5;
            this.rJ_Label6.BorderSize = 0;
            this.rJ_Label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Label6.ForeColor = System.Drawing.Color.Black;
            this.rJ_Label6.Location = new System.Drawing.Point(574, 68);
            this.rJ_Label6.Name = "rJ_Label6";
            this.rJ_Label6.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label6.Size = new System.Drawing.Size(496, 43);
            this.rJ_Label6.TabIndex = 70;
            this.rJ_Label6.Text = "Buscar por:";
            this.rJ_Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label6.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Label3
            // 
            this.rJ_Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rJ_Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label3.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label3.BorderRadius = 5;
            this.rJ_Label3.BorderSize = 0;
            this.rJ_Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Label3.ForeColor = System.Drawing.Color.Black;
            this.rJ_Label3.Location = new System.Drawing.Point(739, 33);
            this.rJ_Label3.Name = "rJ_Label3";
            this.rJ_Label3.Size = new System.Drawing.Size(67, 23);
            this.rJ_Label3.TabIndex = 65;
            this.rJ_Label3.Text = "Fecha Fin:";
            this.rJ_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label3.TextColor = System.Drawing.Color.Black;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaFin.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFin.Location = new System.Drawing.Point(811, 33);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(98, 23);
            this.dtpFechaFin.TabIndex = 64;
            // 
            // rJ_Label4
            // 
            this.rJ_Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rJ_Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label4.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label4.BorderRadius = 5;
            this.rJ_Label4.BorderSize = 0;
            this.rJ_Label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Label4.ForeColor = System.Drawing.Color.Black;
            this.rJ_Label4.Location = new System.Drawing.Point(548, 33);
            this.rJ_Label4.Name = "rJ_Label4";
            this.rJ_Label4.Size = new System.Drawing.Size(81, 23);
            this.rJ_Label4.TabIndex = 63;
            this.rJ_Label4.Text = "Fecha Inicio:";
            this.rJ_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label4.TextColor = System.Drawing.Color.Black;
            // 
            // dgvListadoReporteVT
            // 
            this.dgvListadoReporteVT.AllowUserToAddRows = false;
            this.dgvListadoReporteVT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoReporteVT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvListadoReporteVT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoReporteVT.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoReporteVT.BorderColor = System.Drawing.Color.DimGray;
            this.dgvListadoReporteVT.BorderRadius = 5;
            this.dgvListadoReporteVT.BorderSize = 1;
            this.dgvListadoReporteVT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvListadoReporteVT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListadoReporteVT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoReporteVT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FechaRegistro,
            this.TipoDocumento,
            this.NumeroDocumento,
            this.MontoTotal,
            this.UsuarioRegistro,
            this.DocumentoCliente,
            this.NombreCliente,
            this.CodigoProducto,
            this.NombreProducto,
            this.Descripcion,
            this.Categoria,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal});
            this.dgvListadoReporteVT.Location = new System.Drawing.Point(27, 112);
            this.dgvListadoReporteVT.MultiSelect = false;
            this.dgvListadoReporteVT.Name = "dgvListadoReporteVT";
            this.dgvListadoReporteVT.ReadOnly = true;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoReporteVT.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListadoReporteVT.Size = new System.Drawing.Size(1045, 528);
            this.dgvListadoReporteVT.TabIndex = 69;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.HeaderText = "Fecha Registro";
            this.FechaRegistro.Name = "FechaRegistro";
            this.FechaRegistro.ReadOnly = true;
            this.FechaRegistro.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FechaRegistro.Width = 133;
            // 
            // TipoDocumento
            // 
            this.TipoDocumento.HeaderText = "Tipo Documento";
            this.TipoDocumento.Name = "TipoDocumento";
            this.TipoDocumento.ReadOnly = true;
            this.TipoDocumento.Width = 147;
            // 
            // NumeroDocumento
            // 
            this.NumeroDocumento.HeaderText = "Numero Documento";
            this.NumeroDocumento.Name = "NumeroDocumento";
            this.NumeroDocumento.ReadOnly = true;
            this.NumeroDocumento.Width = 169;
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Monto Total";
            this.MontoTotal.Name = "MontoTotal";
            this.MontoTotal.ReadOnly = true;
            this.MontoTotal.Width = 119;
            // 
            // UsuarioRegistro
            // 
            this.UsuarioRegistro.HeaderText = "Usuario Registrado";
            this.UsuarioRegistro.Name = "UsuarioRegistro";
            this.UsuarioRegistro.ReadOnly = true;
            this.UsuarioRegistro.Width = 160;
            // 
            // DocumentoCliente
            // 
            this.DocumentoCliente.HeaderText = "Documento Cliente";
            this.DocumentoCliente.Name = "DocumentoCliente";
            this.DocumentoCliente.ReadOnly = true;
            this.DocumentoCliente.Width = 162;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 140;
            // 
            // CodigoProducto
            // 
            this.CodigoProducto.HeaderText = "Codigo Producto";
            this.CodigoProducto.Name = "CodigoProducto";
            this.CodigoProducto.ReadOnly = true;
            this.CodigoProducto.Width = 147;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre Producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 153;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 115;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 102;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio de Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Width = 139;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 98;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 97;
            // 
            // rJ_Label2
            // 
            this.rJ_Label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rJ_Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label2.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label2.BorderRadius = 5;
            this.rJ_Label2.BorderSize = 1;
            this.rJ_Label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Label2.ForeColor = System.Drawing.Color.Black;
            this.rJ_Label2.Location = new System.Drawing.Point(27, 22);
            this.rJ_Label2.Name = "rJ_Label2";
            this.rJ_Label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label2.Size = new System.Drawing.Size(1045, 43);
            this.rJ_Label2.TabIndex = 62;
            this.rJ_Label2.Text = "Reporte de Ventas";
            this.rJ_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label2.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Label1
            // 
            this.rJ_Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rJ_Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label1.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label1.BorderRadius = 8;
            this.rJ_Label1.BorderSize = 1;
            this.rJ_Label1.ForeColor = System.Drawing.Color.White;
            this.rJ_Label1.Location = new System.Drawing.Point(12, 9);
            this.rJ_Label1.Name = "rJ_Label1";
            this.rJ_Label1.Size = new System.Drawing.Size(1074, 644);
            this.rJ_Label1.TabIndex = 61;
            this.rJ_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Label1.TextColor = System.Drawing.Color.White;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaInicio.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicio.Location = new System.Drawing.Point(635, 33);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(98, 23);
            this.dtpFechaInicio.TabIndex = 76;
            // 
            // btnBuscarReporteVT
            // 
            this.btnBuscarReporteVT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarReporteVT.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarReporteVT.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBuscarReporteVT.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscarReporteVT.BorderRadius = 5;
            this.btnBuscarReporteVT.BorderSize = 1;
            this.btnBuscarReporteVT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarReporteVT.FlatAppearance.BorderSize = 0;
            this.btnBuscarReporteVT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarReporteVT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarReporteVT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarReporteVT.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarReporteVT.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarReporteVT.Image = global::CapaPresentacion.Properties.Resources.SearchBlack;
            this.btnBuscarReporteVT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarReporteVT.Location = new System.Drawing.Point(919, 29);
            this.btnBuscarReporteVT.Name = "btnBuscarReporteVT";
            this.btnBuscarReporteVT.Padding = new System.Windows.Forms.Padding(20, 0, 35, 0);
            this.btnBuscarReporteVT.Size = new System.Drawing.Size(142, 30);
            this.btnBuscarReporteVT.TabIndex = 77;
            this.btnBuscarReporteVT.Text = "Buscar";
            this.btnBuscarReporteVT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarReporteVT.TextColor = System.Drawing.Color.Black;
            this.btnBuscarReporteVT.UseVisualStyleBackColor = false;
            this.btnBuscarReporteVT.Click += new System.EventHandler(this.btnBuscarReporteVT_Click);
            // 
            // Form_ReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1098, 662);
            this.Controls.Add(this.btnBuscarReporteVT);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnBuscarPor);
            this.Controls.Add(this.btnLimpiarBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.cbbBuscar);
            this.Controls.Add(this.rJ_Label6);
            this.Controls.Add(this.rJ_Label3);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.rJ_Label4);
            this.Controls.Add(this.dgvListadoReporteVT);
            this.Controls.Add(this.rJ_Label2);
            this.Controls.Add(this.rJ_Label1);
            this.Name = "Form_ReporteVentas";
            this.Text = "Form_ReporteVenta";
            this.Load += new System.EventHandler(this.Form_ReporteVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoReporteVT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls_Plus.RJ_Button btnExcel;
        private Custom_Controls_Plus.RJ_Button btnBuscarPor;
        private Custom_Controls_Plus.RJ_Button btnLimpiarBusqueda;
        private ControlsLibrary.RJ_TextBox txtBusqueda;
        private System.Windows.Forms.ComboBox cbbBuscar;
        private Custom_Controls_Plus.RJ_Label rJ_Label6;
        private Custom_Controls_Plus.RJ_Label rJ_Label3;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private Custom_Controls_Plus.RJ_Label rJ_Label4;
        private Custom_Controls_Plus.RJDataGridView dgvListadoReporteVT;
        private Custom_Controls_Plus.RJ_Label rJ_Label2;
        private Custom_Controls_Plus.RJ_Label rJ_Label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn UsuarioRegistro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocumentoCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private Custom_Controls_Plus.RJ_Button btnBuscarReporteVT;
    }
}