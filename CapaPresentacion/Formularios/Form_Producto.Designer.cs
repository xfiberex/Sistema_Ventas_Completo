namespace CapaPresentacion.Formularios
{
    partial class Form_Producto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbbBuscarProd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbCategoriaProd = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbEstadoProd = new System.Windows.Forms.ComboBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtIndiceProd = new System.Windows.Forms.TextBox();
            this.btnGuardarProd = new Custom_Controls_Plus.RJ_Button();
            this.txtCodigoProd = new ControlsLibrary.RJ_TextBox();
            this.txtNombreProd = new ControlsLibrary.RJ_TextBox();
            this.txtDescripcionProd = new ControlsLibrary.RJ_TextBox();
            this.btnLimpiarDatosProd = new Custom_Controls_Plus.RJ_Button();
            this.rJ_Label2 = new Custom_Controls_Plus.RJ_Label();
            this.rJ_Label4 = new Custom_Controls_Plus.RJ_Label();
            this.btnEliminarProd = new Custom_Controls_Plus.RJ_Button();
            this.rJ_Label1 = new Custom_Controls_Plus.RJ_Label();
            this.btnLimpiarBusquedaProd = new Custom_Controls_Plus.RJ_Button();
            this.btnBuscarProd = new Custom_Controls_Plus.RJ_Button();
            this.txtBusquedaProd = new ControlsLibrary.RJ_TextBox();
            this.rJ_Label5 = new Custom_Controls_Plus.RJ_Label();
            this.rJ_Label3 = new Custom_Controls_Plus.RJ_Label();
            this.dgvListadoProductos = new Custom_Controls_Plus.RJDataGridView();
            this.btnSeleccionarProducto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcel = new Custom_Controls_Plus.RJ_Button();
            this.btnPDF = new Custom_Controls_Plus.RJ_Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbBuscarProd
            // 
            this.cbbBuscarProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbBuscarProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbbBuscarProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBuscarProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBuscarProd.FormattingEnabled = true;
            this.cbbBuscarProd.Location = new System.Drawing.Point(661, 34);
            this.cbbBuscarProd.Name = "cbbBuscarProd";
            this.cbbBuscarProd.Size = new System.Drawing.Size(144, 25);
            this.cbbBuscarProd.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Codigo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Descripción:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 23);
            this.label6.TabIndex = 40;
            this.label6.Text = "Categoria:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbCategoriaProd
            // 
            this.cbbCategoriaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbbCategoriaProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCategoriaProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCategoriaProd.FormattingEnabled = true;
            this.cbbCategoriaProd.Location = new System.Drawing.Point(25, 290);
            this.cbbCategoriaProd.Name = "cbbCategoriaProd";
            this.cbbCategoriaProd.Size = new System.Drawing.Size(193, 25);
            this.cbbCategoriaProd.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Estado:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbEstadoProd
            // 
            this.cbbEstadoProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbbEstadoProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstadoProd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstadoProd.FormattingEnabled = true;
            this.cbbEstadoProd.Location = new System.Drawing.Point(25, 345);
            this.cbbEstadoProd.Name = "cbbEstadoProd";
            this.cbbEstadoProd.Size = new System.Drawing.Size(193, 25);
            this.cbbEstadoProd.TabIndex = 43;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtIdProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProducto.Location = new System.Drawing.Point(184, 79);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.ReadOnly = true;
            this.txtIdProducto.Size = new System.Drawing.Size(33, 21);
            this.txtIdProducto.TabIndex = 51;
            this.txtIdProducto.Text = "0";
            this.txtIdProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtIndiceProd
            // 
            this.txtIndiceProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtIndiceProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndiceProd.Location = new System.Drawing.Point(145, 79);
            this.txtIndiceProd.Name = "txtIndiceProd";
            this.txtIndiceProd.ReadOnly = true;
            this.txtIndiceProd.Size = new System.Drawing.Size(33, 21);
            this.txtIndiceProd.TabIndex = 56;
            this.txtIndiceProd.Text = "0";
            this.txtIndiceProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuardarProd
            // 
            this.btnGuardarProd.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardarProd.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnGuardarProd.BorderColor = System.Drawing.Color.DimGray;
            this.btnGuardarProd.BorderRadius = 5;
            this.btnGuardarProd.BorderSize = 1;
            this.btnGuardarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarProd.FlatAppearance.BorderSize = 0;
            this.btnGuardarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProd.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnGuardarProd.Image = global::CapaPresentacion.Properties.Resources.save30;
            this.btnGuardarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProd.Location = new System.Drawing.Point(25, 387);
            this.btnGuardarProd.Name = "btnGuardarProd";
            this.btnGuardarProd.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.btnGuardarProd.Size = new System.Drawing.Size(193, 40);
            this.btnGuardarProd.TabIndex = 44;
            this.btnGuardarProd.Text = "Guardar";
            this.btnGuardarProd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnGuardarProd.UseVisualStyleBackColor = false;
            this.btnGuardarProd.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtCodigoProd.BorderColor = System.Drawing.Color.DimGray;
            this.txtCodigoProd.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtCodigoProd.BorderRadius = 5;
            this.txtCodigoProd.BorderSize = 1;
            this.txtCodigoProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoProd.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoProd.Location = new System.Drawing.Point(25, 104);
            this.txtCodigoProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoProd.Multiline = false;
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCodigoProd.PasswordChar = false;
            this.txtCodigoProd.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCodigoProd.PlaceholderText = "Ingrese el codigo";
            this.txtCodigoProd.ReadOnly = false;
            this.txtCodigoProd.Size = new System.Drawing.Size(192, 31);
            this.txtCodigoProd.TabIndex = 31;
            this.txtCodigoProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCodigoProd.UnderlinedStyle = false;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtNombreProd.BorderColor = System.Drawing.Color.DimGray;
            this.txtNombreProd.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtNombreProd.BorderRadius = 5;
            this.txtNombreProd.BorderSize = 1;
            this.txtNombreProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProd.ForeColor = System.Drawing.Color.Black;
            this.txtNombreProd.Location = new System.Drawing.Point(25, 166);
            this.txtNombreProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProd.Multiline = false;
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreProd.PasswordChar = false;
            this.txtNombreProd.PlaceholderColor = System.Drawing.Color.Black;
            this.txtNombreProd.PlaceholderText = "Ingrese el nombre";
            this.txtNombreProd.ReadOnly = false;
            this.txtNombreProd.Size = new System.Drawing.Size(192, 31);
            this.txtNombreProd.TabIndex = 33;
            this.txtNombreProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreProd.UnderlinedStyle = false;
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtDescripcionProd.BorderColor = System.Drawing.Color.DimGray;
            this.txtDescripcionProd.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtDescripcionProd.BorderRadius = 5;
            this.txtDescripcionProd.BorderSize = 1;
            this.txtDescripcionProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionProd.ForeColor = System.Drawing.Color.Black;
            this.txtDescripcionProd.Location = new System.Drawing.Point(25, 228);
            this.txtDescripcionProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripcionProd.Multiline = false;
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescripcionProd.PasswordChar = false;
            this.txtDescripcionProd.PlaceholderColor = System.Drawing.Color.Black;
            this.txtDescripcionProd.PlaceholderText = "Ingrese las caracteristicas";
            this.txtDescripcionProd.ReadOnly = false;
            this.txtDescripcionProd.Size = new System.Drawing.Size(192, 31);
            this.txtDescripcionProd.TabIndex = 35;
            this.txtDescripcionProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcionProd.UnderlinedStyle = false;
            // 
            // btnLimpiarDatosProd
            // 
            this.btnLimpiarDatosProd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarDatosProd.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarDatosProd.BorderColor = System.Drawing.Color.DimGray;
            this.btnLimpiarDatosProd.BorderRadius = 5;
            this.btnLimpiarDatosProd.BorderSize = 1;
            this.btnLimpiarDatosProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarDatosProd.FlatAppearance.BorderSize = 0;
            this.btnLimpiarDatosProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatosProd.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatosProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarDatosProd.Image = global::CapaPresentacion.Properties.Resources.DeleteDetails;
            this.btnLimpiarDatosProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarDatosProd.Location = new System.Drawing.Point(25, 433);
            this.btnLimpiarDatosProd.Name = "btnLimpiarDatosProd";
            this.btnLimpiarDatosProd.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnLimpiarDatosProd.Size = new System.Drawing.Size(193, 40);
            this.btnLimpiarDatosProd.TabIndex = 45;
            this.btnLimpiarDatosProd.Text = "Limpiar detalles";
            this.btnLimpiarDatosProd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDatosProd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarDatosProd.UseVisualStyleBackColor = false;
            this.btnLimpiarDatosProd.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
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
            this.rJ_Label2.Location = new System.Drawing.Point(25, 23);
            this.rJ_Label2.Name = "rJ_Label2";
            this.rJ_Label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label2.Size = new System.Drawing.Size(192, 43);
            this.rJ_Label2.TabIndex = 47;
            this.rJ_Label2.Text = "Detalles del Producto";
            this.rJ_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label2.TextColor = System.Drawing.Color.Black;
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
            this.rJ_Label4.Location = new System.Drawing.Point(253, 23);
            this.rJ_Label4.Name = "rJ_Label4";
            this.rJ_Label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label4.Size = new System.Drawing.Size(294, 43);
            this.rJ_Label4.TabIndex = 49;
            this.rJ_Label4.Text = "Lista de Productos:";
            this.rJ_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label4.TextColor = System.Drawing.Color.Black;
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarProd.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btnEliminarProd.BorderColor = System.Drawing.Color.DimGray;
            this.btnEliminarProd.BorderRadius = 5;
            this.btnEliminarProd.BorderSize = 1;
            this.btnEliminarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProd.FlatAppearance.BorderSize = 0;
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProd.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnEliminarProd.Image = global::CapaPresentacion.Properties.Resources.Trash30;
            this.btnEliminarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProd.Location = new System.Drawing.Point(25, 479);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.btnEliminarProd.Size = new System.Drawing.Size(193, 40);
            this.btnEliminarProd.TabIndex = 46;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // rJ_Label1
            // 
            this.rJ_Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rJ_Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label1.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label1.BorderRadius = 8;
            this.rJ_Label1.BorderSize = 1;
            this.rJ_Label1.ForeColor = System.Drawing.Color.White;
            this.rJ_Label1.Location = new System.Drawing.Point(12, 9);
            this.rJ_Label1.Name = "rJ_Label1";
            this.rJ_Label1.Size = new System.Drawing.Size(217, 644);
            this.rJ_Label1.TabIndex = 29;
            this.rJ_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Label1.TextColor = System.Drawing.Color.White;
            // 
            // btnLimpiarBusquedaProd
            // 
            this.btnLimpiarBusquedaProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarBusquedaProd.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBusquedaProd.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBusquedaProd.BorderColor = System.Drawing.Color.DimGray;
            this.btnLimpiarBusquedaProd.BorderRadius = 5;
            this.btnLimpiarBusquedaProd.BorderSize = 1;
            this.btnLimpiarBusquedaProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBusquedaProd.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBusquedaProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusquedaProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnLimpiarBusquedaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusquedaProd.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusquedaProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusquedaProd.Image = global::CapaPresentacion.Properties.Resources.BroomBlack;
            this.btnLimpiarBusquedaProd.Location = new System.Drawing.Point(1018, 30);
            this.btnLimpiarBusquedaProd.Name = "btnLimpiarBusquedaProd";
            this.btnLimpiarBusquedaProd.Padding = new System.Windows.Forms.Padding(5);
            this.btnLimpiarBusquedaProd.Size = new System.Drawing.Size(40, 31);
            this.btnLimpiarBusquedaProd.TabIndex = 55;
            this.btnLimpiarBusquedaProd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusquedaProd.UseVisualStyleBackColor = false;
            this.btnLimpiarBusquedaProd.Click += new System.EventHandler(this.btnLimpiarBusqueda_Click);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarProd.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProd.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBuscarProd.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscarProd.BorderRadius = 5;
            this.btnBuscarProd.BorderSize = 1;
            this.btnBuscarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProd.FlatAppearance.BorderSize = 0;
            this.btnBuscarProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProd.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarProd.Image = global::CapaPresentacion.Properties.Resources.SearchBlack;
            this.btnBuscarProd.Location = new System.Drawing.Point(972, 30);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Padding = new System.Windows.Forms.Padding(5);
            this.btnBuscarProd.Size = new System.Drawing.Size(40, 31);
            this.btnBuscarProd.TabIndex = 58;
            this.btnBuscarProd.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBusquedaProd
            // 
            this.txtBusquedaProd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusquedaProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtBusquedaProd.BorderColor = System.Drawing.Color.DimGray;
            this.txtBusquedaProd.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtBusquedaProd.BorderRadius = 5;
            this.txtBusquedaProd.BorderSize = 1;
            this.txtBusquedaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaProd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusquedaProd.Location = new System.Drawing.Point(812, 30);
            this.txtBusquedaProd.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaProd.Multiline = false;
            this.txtBusquedaProd.Name = "txtBusquedaProd";
            this.txtBusquedaProd.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusquedaProd.PasswordChar = false;
            this.txtBusquedaProd.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtBusquedaProd.PlaceholderText = "Ingrese lo que busca...";
            this.txtBusquedaProd.ReadOnly = false;
            this.txtBusquedaProd.Size = new System.Drawing.Size(153, 31);
            this.txtBusquedaProd.TabIndex = 54;
            this.txtBusquedaProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBusquedaProd.UnderlinedStyle = true;
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
            this.rJ_Label5.Location = new System.Drawing.Point(553, 23);
            this.rJ_Label5.Name = "rJ_Label5";
            this.rJ_Label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label5.Size = new System.Drawing.Size(514, 43);
            this.rJ_Label5.TabIndex = 52;
            this.rJ_Label5.Text = "Buscar por:";
            this.rJ_Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label5.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Label3
            // 
            this.rJ_Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rJ_Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label3.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label3.BorderRadius = 8;
            this.rJ_Label3.BorderSize = 1;
            this.rJ_Label3.ForeColor = System.Drawing.Color.White;
            this.rJ_Label3.Location = new System.Drawing.Point(235, 9);
            this.rJ_Label3.Name = "rJ_Label3";
            this.rJ_Label3.Size = new System.Drawing.Size(851, 644);
            this.rJ_Label3.TabIndex = 48;
            this.rJ_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Label3.TextColor = System.Drawing.Color.White;
            // 
            // dgvListadoProductos
            // 
            this.dgvListadoProductos.AllowUserToAddRows = false;
            this.dgvListadoProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoProductos.BorderColor = System.Drawing.Color.DimGray;
            this.dgvListadoProductos.BorderRadius = 5;
            this.dgvListadoProductos.BorderSize = 1;
            this.dgvListadoProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvListadoProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionarProducto,
            this.IdProducto,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.IdCategoria,
            this.Categoria,
            this.Stock,
            this.PrecioCompra,
            this.PrecioVenta,
            this.EstadoValor,
            this.Estado});
            this.dgvListadoProductos.Location = new System.Drawing.Point(253, 77);
            this.dgvListadoProductos.MultiSelect = false;
            this.dgvListadoProductos.Name = "dgvListadoProductos";
            this.dgvListadoProductos.ReadOnly = true;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoProductos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListadoProductos.Size = new System.Drawing.Size(814, 564);
            this.dgvListadoProductos.TabIndex = 50;
            this.dgvListadoProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoProducto_CellContentClick);
            this.dgvListadoProductos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListadoProducto_CellPainting);
            // 
            // btnSeleccionarProducto
            // 
            this.btnSeleccionarProducto.FillWeight = 30F;
            this.btnSeleccionarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarProducto.HeaderText = "";
            this.btnSeleccionarProducto.Name = "btnSeleccionarProducto";
            this.btnSeleccionarProducto.ReadOnly = true;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "ID";
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            // 
            // Codigo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Codigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.Codigo.FillWeight = 60F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.FillWeight = 150F;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.FillWeight = 150F;
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // IdCategoria
            // 
            this.IdCategoria.HeaderText = "IdCategoria";
            this.IdCategoria.Name = "IdCategoria";
            this.IdCategoria.ReadOnly = true;
            this.IdCategoria.Visible = false;
            // 
            // Categoria
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Categoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.Categoria.FillWeight = 90F;
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Stock
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Stock.DefaultCellStyle = dataGridViewCellStyle4;
            this.Stock.FillWeight = 50F;
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            // 
            // PrecioCompra
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioCompra.DefaultCellStyle = dataGridViewCellStyle5;
            this.PrecioCompra.FillWeight = 70F;
            this.PrecioCompra.HeaderText = "Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            // 
            // PrecioVenta
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PrecioVenta.DefaultCellStyle = dataGridViewCellStyle6;
            this.PrecioVenta.FillWeight = 70F;
            this.PrecioVenta.HeaderText = "Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            // 
            // EstadoValor
            // 
            this.EstadoValor.HeaderText = "EstadoValor";
            this.EstadoValor.Name = "EstadoValor";
            this.EstadoValor.ReadOnly = true;
            this.EstadoValor.Visible = false;
            // 
            // Estado
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle7;
            this.Estado.FillWeight = 60F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // btnExcel
            // 
            this.btnExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnExcel.Location = new System.Drawing.Point(476, 30);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(62, 31);
            this.btnExcel.TabIndex = 59;
            this.btnExcel.Text = "Excel";
            this.btnExcel.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnPDF.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnPDF.BorderColor = System.Drawing.Color.DimGray;
            this.btnPDF.BorderRadius = 5;
            this.btnPDF.BorderSize = 1;
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.FlatAppearance.BorderSize = 0;
            this.btnPDF.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(74)))), ((int)(((byte)(64)))));
            this.btnPDF.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(134)))), ((int)(((byte)(127)))));
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnPDF.Location = new System.Drawing.Point(408, 30);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(62, 31);
            this.btnPDF.TabIndex = 60;
            this.btnPDF.Text = "PDF";
            this.btnPDF.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // Form_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1098, 662);
            this.Controls.Add(this.btnPDF);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.btnLimpiarBusquedaProd);
            this.Controls.Add(this.btnEliminarProd);
            this.Controls.Add(this.rJ_Label4);
            this.Controls.Add(this.rJ_Label2);
            this.Controls.Add(this.btnLimpiarDatosProd);
            this.Controls.Add(this.txtDescripcionProd);
            this.Controls.Add(this.txtNombreProd);
            this.Controls.Add(this.txtCodigoProd);
            this.Controls.Add(this.btnGuardarProd);
            this.Controls.Add(this.txtIndiceProd);
            this.Controls.Add(this.txtBusquedaProd);
            this.Controls.Add(this.cbbBuscarProd);
            this.Controls.Add(this.rJ_Label5);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.dgvListadoProductos);
            this.Controls.Add(this.cbbEstadoProd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbbCategoriaProd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rJ_Label1);
            this.Controls.Add(this.rJ_Label3);
            this.Name = "Form_Producto";
            this.Text = "Form_Producto";
            this.Load += new System.EventHandler(this.Form_Producto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbBuscarProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbCategoriaProd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbbEstadoProd;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtIndiceProd;
        private Custom_Controls_Plus.RJ_Button btnGuardarProd;
        private ControlsLibrary.RJ_TextBox txtCodigoProd;
        private ControlsLibrary.RJ_TextBox txtNombreProd;
        private ControlsLibrary.RJ_TextBox txtDescripcionProd;
        private Custom_Controls_Plus.RJ_Button btnLimpiarDatosProd;
        private Custom_Controls_Plus.RJ_Label rJ_Label2;
        private Custom_Controls_Plus.RJ_Label rJ_Label4;
        private Custom_Controls_Plus.RJ_Button btnEliminarProd;
        private Custom_Controls_Plus.RJ_Label rJ_Label1;
        private Custom_Controls_Plus.RJ_Button btnLimpiarBusquedaProd;
        private Custom_Controls_Plus.RJ_Button btnBuscarProd;
        private ControlsLibrary.RJ_TextBox txtBusquedaProd;
        private Custom_Controls_Plus.RJ_Label rJ_Label5;
        private Custom_Controls_Plus.RJ_Label rJ_Label3;
        private Custom_Controls_Plus.RJDataGridView dgvListadoProductos;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private Custom_Controls_Plus.RJ_Button btnExcel;
        private Custom_Controls_Plus.RJ_Button btnPDF;
    }
}