namespace CapaPresentacion.Formularios
{
    partial class Form_Compras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbTipoDocumentoProducto = new System.Windows.Forms.ComboBox();
            this.txtFechaProducto = new ControlsLibrary.RJ_TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtRazonSocialProv = new ControlsLibrary.RJ_TextBox();
            this.txtIdProveedor = new ControlsLibrary.RJ_TextBox();
            this.btnBuscarProveedor = new Custom_Controls_Plus.RJ_Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDocumentoProveedor = new ControlsLibrary.RJ_TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtmdDescripProducto = new ControlsLibrary.RJ_TextBox();
            this.txtmdNombreProducto = new ControlsLibrary.RJ_TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nudCantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new ControlsLibrary.RJ_TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new ControlsLibrary.RJ_TextBox();
            this.txtIdCodigoProducto = new ControlsLibrary.RJ_TextBox();
            this.btnmdBuscarProducto = new Custom_Controls_Plus.RJ_Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new ControlsLibrary.RJ_TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotalPagarProducto = new ControlsLibrary.RJ_TextBox();
            this.dgvListadoCompra = new Custom_Controls_Plus.RJDataGridView();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.rJ_Label2 = new Custom_Controls_Plus.RJ_Label();
            this.rJ_Label3 = new Custom_Controls_Plus.RJ_Label();
            this.btnRegistrarCompra = new Custom_Controls_Plus.RJ_Button();
            this.btnAgregarProducto = new Custom_Controls_Plus.RJ_Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbTipoDocumentoProducto);
            this.groupBox1.Controls.Add(this.txtFechaProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(129, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 104);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de Compra";
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
            // cbbTipoDocumentoProducto
            // 
            this.cbbTipoDocumentoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbbTipoDocumentoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTipoDocumentoProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTipoDocumentoProducto.FormattingEnabled = true;
            this.cbbTipoDocumentoProducto.Location = new System.Drawing.Point(174, 62);
            this.cbbTipoDocumentoProducto.Name = "cbbTipoDocumentoProducto";
            this.cbbTipoDocumentoProducto.Size = new System.Drawing.Size(205, 25);
            this.cbbTipoDocumentoProducto.TabIndex = 2;
            // 
            // txtFechaProducto
            // 
            this.txtFechaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtFechaProducto.BorderColor = System.Drawing.Color.DimGray;
            this.txtFechaProducto.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtFechaProducto.BorderRadius = 5;
            this.txtFechaProducto.BorderSize = 1;
            this.txtFechaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFechaProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFechaProducto.Location = new System.Drawing.Point(19, 56);
            this.txtFechaProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtFechaProducto.Multiline = false;
            this.txtFechaProducto.Name = "txtFechaProducto";
            this.txtFechaProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtFechaProducto.PasswordChar = false;
            this.txtFechaProducto.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtFechaProducto.PlaceholderText = "";
            this.txtFechaProducto.ReadOnly = true;
            this.txtFechaProducto.Size = new System.Drawing.Size(148, 31);
            this.txtFechaProducto.TabIndex = 1;
            this.txtFechaProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFechaProducto.UnderlinedStyle = false;
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
            this.groupBox2.Controls.Add(this.txtRazonSocialProv);
            this.groupBox2.Controls.Add(this.txtIdProveedor);
            this.groupBox2.Controls.Add(this.btnBuscarProveedor);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDocumentoProveedor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(527, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 104);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Información del Proveedor";
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
            this.txtRazonSocialProv.Location = new System.Drawing.Point(264, 56);
            this.txtRazonSocialProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocialProv.Multiline = false;
            this.txtRazonSocialProv.Name = "txtRazonSocialProv";
            this.txtRazonSocialProv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRazonSocialProv.PasswordChar = false;
            this.txtRazonSocialProv.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtRazonSocialProv.PlaceholderText = "";
            this.txtRazonSocialProv.ReadOnly = false;
            this.txtRazonSocialProv.Size = new System.Drawing.Size(204, 31);
            this.txtRazonSocialProv.TabIndex = 30;
            this.txtRazonSocialProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRazonSocialProv.UnderlinedStyle = false;
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtIdProveedor.BorderColor = System.Drawing.Color.DimGray;
            this.txtIdProveedor.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtIdProveedor.BorderRadius = 5;
            this.txtIdProveedor.BorderSize = 1;
            this.txtIdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdProveedor.Location = new System.Drawing.Point(421, 21);
            this.txtIdProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProveedor.Multiline = false;
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIdProveedor.PasswordChar = false;
            this.txtIdProveedor.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtIdProveedor.PlaceholderText = "";
            this.txtIdProveedor.ReadOnly = true;
            this.txtIdProveedor.Size = new System.Drawing.Size(47, 31);
            this.txtIdProveedor.TabIndex = 23;
            this.txtIdProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdProveedor.UnderlinedStyle = false;
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProveedor.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBuscarProveedor.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscarProveedor.BorderRadius = 5;
            this.btnBuscarProveedor.BorderSize = 1;
            this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProveedor.FlatAppearance.BorderSize = 0;
            this.btnBuscarProveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarProveedor.Image = global::CapaPresentacion.Properties.Resources.SearchBlack;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(217, 56);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Padding = new System.Windows.Forms.Padding(5);
            this.btnBuscarProveedor.Size = new System.Drawing.Size(40, 31);
            this.btnBuscarProveedor.TabIndex = 29;
            this.btnBuscarProveedor.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Razón social:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDocumentoProveedor
            // 
            this.txtDocumentoProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtDocumentoProveedor.BorderColor = System.Drawing.Color.DimGray;
            this.txtDocumentoProveedor.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtDocumentoProveedor.BorderRadius = 5;
            this.txtDocumentoProveedor.BorderSize = 1;
            this.txtDocumentoProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDocumentoProveedor.Location = new System.Drawing.Point(19, 56);
            this.txtDocumentoProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumentoProveedor.Multiline = false;
            this.txtDocumentoProveedor.Name = "txtDocumentoProveedor";
            this.txtDocumentoProveedor.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDocumentoProveedor.PasswordChar = false;
            this.txtDocumentoProveedor.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtDocumentoProveedor.PlaceholderText = "";
            this.txtDocumentoProveedor.ReadOnly = false;
            this.txtDocumentoProveedor.Size = new System.Drawing.Size(191, 31);
            this.txtDocumentoProveedor.TabIndex = 1;
            this.txtDocumentoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDocumentoProveedor.UnderlinedStyle = false;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtmdDescripProducto);
            this.groupBox3.Controls.Add(this.txtmdNombreProducto);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.nudCantidadProducto);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtPrecioVenta);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtPrecioCompra);
            this.groupBox3.Controls.Add(this.txtIdCodigoProducto);
            this.groupBox3.Controls.Add(this.btnmdBuscarProducto);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtCodigoProducto);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(129, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1017, 104);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información del Producto";
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
            // txtmdDescripProducto
            // 
            this.txtmdDescripProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtmdDescripProducto.BorderColor = System.Drawing.Color.DimGray;
            this.txtmdDescripProducto.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtmdDescripProducto.BorderRadius = 5;
            this.txtmdDescripProducto.BorderSize = 1;
            this.txtmdDescripProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmdDescripProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmdDescripProducto.Location = new System.Drawing.Point(401, 56);
            this.txtmdDescripProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtmdDescripProducto.Multiline = false;
            this.txtmdDescripProducto.Name = "txtmdDescripProducto";
            this.txtmdDescripProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtmdDescripProducto.PasswordChar = false;
            this.txtmdDescripProducto.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtmdDescripProducto.PlaceholderText = "";
            this.txtmdDescripProducto.ReadOnly = false;
            this.txtmdDescripProducto.Size = new System.Drawing.Size(208, 31);
            this.txtmdDescripProducto.TabIndex = 38;
            this.txtmdDescripProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmdDescripProducto.UnderlinedStyle = false;
            // 
            // txtmdNombreProducto
            // 
            this.txtmdNombreProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtmdNombreProducto.BorderColor = System.Drawing.Color.DimGray;
            this.txtmdNombreProducto.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtmdNombreProducto.BorderRadius = 5;
            this.txtmdNombreProducto.BorderSize = 1;
            this.txtmdNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmdNombreProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmdNombreProducto.Location = new System.Drawing.Point(264, 56);
            this.txtmdNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtmdNombreProducto.Multiline = false;
            this.txtmdNombreProducto.Name = "txtmdNombreProducto";
            this.txtmdNombreProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtmdNombreProducto.PasswordChar = false;
            this.txtmdNombreProducto.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtmdNombreProducto.PlaceholderText = "";
            this.txtmdNombreProducto.ReadOnly = false;
            this.txtmdNombreProducto.Size = new System.Drawing.Size(129, 31);
            this.txtmdNombreProducto.TabIndex = 37;
            this.txtmdNombreProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmdNombreProducto.UnderlinedStyle = false;
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
            // nudCantidadProducto
            // 
            this.nudCantidadProducto.Location = new System.Drawing.Point(895, 62);
            this.nudCantidadProducto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidadProducto.Name = "nudCantidadProducto";
            this.nudCantidadProducto.Size = new System.Drawing.Size(112, 25);
            this.nudCantidadProducto.TabIndex = 35;
            this.nudCantidadProducto.Value = new decimal(new int[] {
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
            this.label8.Text = "Precio de venta:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtPrecioVenta.BorderColor = System.Drawing.Color.DimGray;
            this.txtPrecioVenta.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPrecioVenta.BorderRadius = 5;
            this.txtPrecioVenta.BorderSize = 1;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioVenta.Location = new System.Drawing.Point(757, 56);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioVenta.Multiline = false;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecioVenta.PasswordChar = false;
            this.txtPrecioVenta.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPrecioVenta.PlaceholderText = "";
            this.txtPrecioVenta.ReadOnly = false;
            this.txtPrecioVenta.Size = new System.Drawing.Size(133, 31);
            this.txtPrecioVenta.TabIndex = 33;
            this.txtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecioVenta.UnderlinedStyle = false;
            this.txtPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVenta_KeyPress);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(626, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 31);
            this.label7.TabIndex = 32;
            this.label7.Text = "Precio de compra:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtPrecioCompra.BorderColor = System.Drawing.Color.DimGray;
            this.txtPrecioCompra.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtPrecioCompra.BorderRadius = 5;
            this.txtPrecioCompra.BorderSize = 1;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrecioCompra.Location = new System.Drawing.Point(616, 56);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioCompra.Multiline = false;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPrecioCompra.PasswordChar = false;
            this.txtPrecioCompra.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtPrecioCompra.PlaceholderText = "";
            this.txtPrecioCompra.ReadOnly = false;
            this.txtPrecioCompra.Size = new System.Drawing.Size(133, 31);
            this.txtPrecioCompra.TabIndex = 31;
            this.txtPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrecioCompra.UnderlinedStyle = false;
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // txtIdCodigoProducto
            // 
            this.txtIdCodigoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtIdCodigoProducto.BorderColor = System.Drawing.Color.DimGray;
            this.txtIdCodigoProducto.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtIdCodigoProducto.BorderRadius = 5;
            this.txtIdCodigoProducto.BorderSize = 1;
            this.txtIdCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCodigoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIdCodigoProducto.Location = new System.Drawing.Point(163, 21);
            this.txtIdCodigoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCodigoProducto.Multiline = false;
            this.txtIdCodigoProducto.Name = "txtIdCodigoProducto";
            this.txtIdCodigoProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtIdCodigoProducto.PasswordChar = false;
            this.txtIdCodigoProducto.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtIdCodigoProducto.PlaceholderText = "";
            this.txtIdCodigoProducto.ReadOnly = true;
            this.txtIdCodigoProducto.Size = new System.Drawing.Size(47, 31);
            this.txtIdCodigoProducto.TabIndex = 30;
            this.txtIdCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIdCodigoProducto.UnderlinedStyle = false;
            // 
            // btnmdBuscarProducto
            // 
            this.btnmdBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmdBuscarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnmdBuscarProducto.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnmdBuscarProducto.BorderColor = System.Drawing.Color.DimGray;
            this.btnmdBuscarProducto.BorderRadius = 5;
            this.btnmdBuscarProducto.BorderSize = 1;
            this.btnmdBuscarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmdBuscarProducto.FlatAppearance.BorderSize = 0;
            this.btnmdBuscarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnmdBuscarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnmdBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmdBuscarProducto.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmdBuscarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnmdBuscarProducto.Image = global::CapaPresentacion.Properties.Resources.SearchBlack;
            this.btnmdBuscarProducto.Location = new System.Drawing.Point(217, 56);
            this.btnmdBuscarProducto.Name = "btnmdBuscarProducto";
            this.btnmdBuscarProducto.Padding = new System.Windows.Forms.Padding(5);
            this.btnmdBuscarProducto.Size = new System.Drawing.Size(40, 31);
            this.btnmdBuscarProducto.TabIndex = 29;
            this.btnmdBuscarProducto.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnmdBuscarProducto.UseVisualStyleBackColor = false;
            this.btnmdBuscarProducto.Click += new System.EventHandler(this.btnmdBuscarProducto_Click);
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
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtCodigoProducto.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodigoProducto.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtCodigoProducto.BorderRadius = 5;
            this.txtCodigoProducto.BorderSize = 1;
            this.txtCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCodigoProducto.Location = new System.Drawing.Point(19, 56);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoProducto.Multiline = false;
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodigoProducto.PasswordChar = false;
            this.txtCodigoProducto.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtCodigoProducto.PlaceholderText = "";
            this.txtCodigoProducto.ReadOnly = false;
            this.txtCodigoProducto.Size = new System.Drawing.Size(191, 31);
            this.txtCodigoProducto.TabIndex = 1;
            this.txtCodigoProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoProducto.UnderlinedStyle = false;
            this.txtCodigoProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoProducto_KeyDown);
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
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1023, 648);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 31);
            this.label10.TabIndex = 36;
            this.label10.Text = "Total a Pagar:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTotalPagarProducto
            // 
            this.txtTotalPagarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalPagarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtTotalPagarProducto.BorderColor = System.Drawing.Color.DimGray;
            this.txtTotalPagarProducto.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtTotalPagarProducto.BorderRadius = 5;
            this.txtTotalPagarProducto.BorderSize = 1;
            this.txtTotalPagarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotalPagarProducto.Location = new System.Drawing.Point(1016, 683);
            this.txtTotalPagarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalPagarProducto.Multiline = false;
            this.txtTotalPagarProducto.Name = "txtTotalPagarProducto";
            this.txtTotalPagarProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTotalPagarProducto.PasswordChar = false;
            this.txtTotalPagarProducto.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtTotalPagarProducto.PlaceholderText = "";
            this.txtTotalPagarProducto.ReadOnly = false;
            this.txtTotalPagarProducto.Size = new System.Drawing.Size(133, 31);
            this.txtTotalPagarProducto.TabIndex = 35;
            this.txtTotalPagarProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTotalPagarProducto.UnderlinedStyle = false;
            // 
            // dgvListadoCompra
            // 
            this.dgvListadoCompra.AllowUserToAddRows = false;
            this.dgvListadoCompra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvListadoCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoCompra.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoCompra.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoCompra.BorderColor = System.Drawing.Color.DimGray;
            this.dgvListadoCompra.BorderRadius = 5;
            this.dgvListadoCompra.BorderSize = 1;
            this.dgvListadoCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvListadoCompra.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.Producto,
            this.Descripcion,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Cantidad,
            this.SubTotal,
            this.btnEliminarProducto});
            this.dgvListadoCompra.Location = new System.Drawing.Point(129, 301);
            this.dgvListadoCompra.MultiSelect = false;
            this.dgvListadoCompra.Name = "dgvListadoCompra";
            this.dgvListadoCompra.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoCompra.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListadoCompra.Size = new System.Drawing.Size(880, 460);
            this.dgvListadoCompra.TabIndex = 24;
            this.dgvListadoCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoCompra_CellContentClick);
            this.dgvListadoCompra.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListadoCompra_CellPainting);
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
            // PrecioCompra
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioCompra.DefaultCellStyle = dataGridViewCellStyle2;
            this.PrecioCompra.FillWeight = 80F;
            this.PrecioCompra.HeaderText = "Precio de Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioVenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.PrecioVenta.HeaderText = "Precio de venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
            // 
            // Cantidad
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Cantidad.DefaultCellStyle = dataGridViewCellStyle4;
            this.Cantidad.FillWeight = 50F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // SubTotal
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.SubTotal.DefaultCellStyle = dataGridViewCellStyle5;
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
            // rJ_Label2
            // 
            this.rJ_Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label2.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label2.BorderRadius = 5;
            this.rJ_Label2.BorderSize = 1;
            this.rJ_Label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Label2.ForeColor = System.Drawing.Color.Black;
            this.rJ_Label2.Location = new System.Drawing.Point(129, 23);
            this.rJ_Label2.Name = "rJ_Label2";
            this.rJ_Label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label2.Size = new System.Drawing.Size(1017, 43);
            this.rJ_Label2.TabIndex = 20;
            this.rJ_Label2.Text = "Registrar Compra";
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
            this.rJ_Label3.Location = new System.Drawing.Point(112, 9);
            this.rJ_Label3.Name = "rJ_Label3";
            this.rJ_Label3.Size = new System.Drawing.Size(1050, 768);
            this.rJ_Label3.TabIndex = 31;
            this.rJ_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Label3.TextColor = System.Drawing.Color.White;
            // 
            // btnRegistrarCompra
            // 
            this.btnRegistrarCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistrarCompra.BackColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarCompra.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnRegistrarCompra.BorderColor = System.Drawing.Color.DimGray;
            this.btnRegistrarCompra.BorderRadius = 5;
            this.btnRegistrarCompra.BorderSize = 1;
            this.btnRegistrarCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarCompra.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnRegistrarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegistrarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCompra.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarCompra.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarCompra.Image = global::CapaPresentacion.Properties.Resources.Add_Tag;
            this.btnRegistrarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarCompra.Location = new System.Drawing.Point(1016, 721);
            this.btnRegistrarCompra.Name = "btnRegistrarCompra";
            this.btnRegistrarCompra.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnRegistrarCompra.Size = new System.Drawing.Size(133, 40);
            this.btnRegistrarCompra.TabIndex = 37;
            this.btnRegistrarCompra.Text = "Registrar";
            this.btnRegistrarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarCompra.TextColor = System.Drawing.Color.Black;
            this.btnRegistrarCompra.UseVisualStyleBackColor = false;
            this.btnRegistrarCompra.Click += new System.EventHandler(this.btnRegistrarCompra_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgregarProducto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.btnAgregarProducto.BorderColor = System.Drawing.Color.DimGray;
            this.btnAgregarProducto.BorderRadius = 5;
            this.btnAgregarProducto.BorderSize = 1;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatAppearance.BorderSize = 0;
            this.btnAgregarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnAgregarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.Image = global::CapaPresentacion.Properties.Resources.Plus;
            this.btnAgregarProducto.Location = new System.Drawing.Point(1016, 301);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Padding = new System.Windows.Forms.Padding(5, 5, 5, 20);
            this.btnAgregarProducto.Size = new System.Drawing.Size(131, 104);
            this.btnAgregarProducto.TabIndex = 30;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarProducto.TextColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // Form_Compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1303, 786);
            this.Controls.Add(this.btnRegistrarCompra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotalPagarProducto);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.dgvListadoCompra);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rJ_Label2);
            this.Controls.Add(this.rJ_Label3);
            this.Name = "Form_Compras";
            this.Text = "Form_Compras";
            this.Load += new System.EventHandler(this.Form_Compras_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoCompra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls_Plus.RJ_Label rJ_Label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private ControlsLibrary.RJ_TextBox txtFechaProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTipoDocumentoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private ControlsLibrary.RJ_TextBox txtDocumentoProveedor;
        private System.Windows.Forms.Label label4;
        private Custom_Controls_Plus.RJ_Button btnBuscarProveedor;
        private ControlsLibrary.RJ_TextBox txtIdProveedor;
        private System.Windows.Forms.GroupBox groupBox3;
        private Custom_Controls_Plus.RJ_Button btnmdBuscarProducto;
        private System.Windows.Forms.Label label5;
        private ControlsLibrary.RJ_TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label6;
        private ControlsLibrary.RJ_TextBox txtIdCodigoProducto;
        private System.Windows.Forms.Label label7;
        private ControlsLibrary.RJ_TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label8;
        private ControlsLibrary.RJ_TextBox txtPrecioVenta;
        private System.Windows.Forms.NumericUpDown nudCantidadProducto;
        private System.Windows.Forms.Label label9;
        private Custom_Controls_Plus.RJDataGridView dgvListadoCompra;
        private Custom_Controls_Plus.RJ_Button btnAgregarProducto;
        private Custom_Controls_Plus.RJ_Label rJ_Label3;
        private System.Windows.Forms.Label label10;
        private ControlsLibrary.RJ_TextBox txtTotalPagarProducto;
        private Custom_Controls_Plus.RJ_Button btnRegistrarCompra;
        private ControlsLibrary.RJ_TextBox txtRazonSocialProv;
        private ControlsLibrary.RJ_TextBox txtmdNombreProducto;
        private System.Windows.Forms.Label label11;
        private ControlsLibrary.RJ_TextBox txtmdDescripProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewButtonColumn btnEliminarProducto;
    }
}