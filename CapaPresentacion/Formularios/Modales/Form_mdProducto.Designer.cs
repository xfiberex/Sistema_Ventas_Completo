namespace CapaPresentacion.Formularios.Modales
{
    partial class Form_mdProducto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rJ_Label4 = new Custom_Controls_Plus.RJ_Label();
            this.txtmdBusquedaProducto = new ControlsLibrary.RJ_TextBox();
            this.cbbmdBuscarProducto = new System.Windows.Forms.ComboBox();
            this.rJ_Label5 = new Custom_Controls_Plus.RJ_Label();
            this.dgvListadoMdProducto = new Custom_Controls_Plus.RJDataGridView();
            this.IdmdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rJ_Label3 = new Custom_Controls_Plus.RJ_Label();
            this.btnLimpiarmdProducto = new Custom_Controls_Plus.RJ_Button();
            this.btnmdBuscarProducto = new Custom_Controls_Plus.RJ_Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMdProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // rJ_Label4
            // 
            this.rJ_Label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label4.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label4.BorderRadius = 5;
            this.rJ_Label4.BorderSize = 1;
            this.rJ_Label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Label4.ForeColor = System.Drawing.Color.Black;
            this.rJ_Label4.Location = new System.Drawing.Point(34, 31);
            this.rJ_Label4.Name = "rJ_Label4";
            this.rJ_Label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label4.Size = new System.Drawing.Size(188, 43);
            this.rJ_Label4.TabIndex = 67;
            this.rJ_Label4.Text = "Lista de Productos:";
            this.rJ_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label4.TextColor = System.Drawing.Color.Black;
            // 
            // txtmdBusquedaProducto
            // 
            this.txtmdBusquedaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtmdBusquedaProducto.BorderColor = System.Drawing.Color.DimGray;
            this.txtmdBusquedaProducto.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtmdBusquedaProducto.BorderRadius = 5;
            this.txtmdBusquedaProducto.BorderSize = 1;
            this.txtmdBusquedaProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmdBusquedaProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmdBusquedaProducto.Location = new System.Drawing.Point(484, 36);
            this.txtmdBusquedaProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtmdBusquedaProducto.Multiline = false;
            this.txtmdBusquedaProducto.Name = "txtmdBusquedaProducto";
            this.txtmdBusquedaProducto.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtmdBusquedaProducto.PasswordChar = false;
            this.txtmdBusquedaProducto.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtmdBusquedaProducto.PlaceholderText = "Ingrese lo que busca...";
            this.txtmdBusquedaProducto.ReadOnly = false;
            this.txtmdBusquedaProducto.Size = new System.Drawing.Size(153, 31);
            this.txtmdBusquedaProducto.TabIndex = 71;
            this.txtmdBusquedaProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmdBusquedaProducto.UnderlinedStyle = true;
            // 
            // cbbmdBuscarProducto
            // 
            this.cbbmdBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbbmdBuscarProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmdBuscarProducto.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmdBuscarProducto.FormattingEnabled = true;
            this.cbbmdBuscarProducto.Location = new System.Drawing.Point(333, 42);
            this.cbbmdBuscarProducto.Name = "cbbmdBuscarProducto";
            this.cbbmdBuscarProducto.Size = new System.Drawing.Size(144, 25);
            this.cbbmdBuscarProducto.TabIndex = 70;
            // 
            // rJ_Label5
            // 
            this.rJ_Label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label5.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label5.BorderRadius = 5;
            this.rJ_Label5.BorderSize = 1;
            this.rJ_Label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rJ_Label5.ForeColor = System.Drawing.Color.Black;
            this.rJ_Label5.Location = new System.Drawing.Point(228, 31);
            this.rJ_Label5.Name = "rJ_Label5";
            this.rJ_Label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label5.Size = new System.Drawing.Size(511, 43);
            this.rJ_Label5.TabIndex = 69;
            this.rJ_Label5.Text = "Buscar por:";
            this.rJ_Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label5.TextColor = System.Drawing.Color.Black;
            // 
            // dgvListadoMdProducto
            // 
            this.dgvListadoMdProducto.AllowUserToAddRows = false;
            this.dgvListadoMdProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoMdProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoMdProducto.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoMdProducto.BorderColor = System.Drawing.Color.DimGray;
            this.dgvListadoMdProducto.BorderRadius = 5;
            this.dgvListadoMdProducto.BorderSize = 1;
            this.dgvListadoMdProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvListadoMdProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoMdProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoMdProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdmdProducto,
            this.Codigo,
            this.Nombre,
            this.Descripcion,
            this.Categoria,
            this.Stock,
            this.PrecioCompra,
            this.PrecioVenta});
            this.dgvListadoMdProducto.Location = new System.Drawing.Point(34, 85);
            this.dgvListadoMdProducto.MultiSelect = false;
            this.dgvListadoMdProducto.Name = "dgvListadoMdProducto";
            this.dgvListadoMdProducto.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoMdProducto.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoMdProducto.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListadoMdProducto.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoMdProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoMdProducto.Size = new System.Drawing.Size(705, 552);
            this.dgvListadoMdProducto.TabIndex = 68;
            this.dgvListadoMdProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoMdProducto_CellDoubleClick);
            // 
            // IdmdProducto
            // 
            this.IdmdProducto.HeaderText = "ID";
            this.IdmdProducto.Name = "IdmdProducto";
            this.IdmdProducto.ReadOnly = true;
            this.IdmdProducto.Visible = false;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Stock
            // 
            this.Stock.HeaderText = "Stock";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Visible = false;
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio de compra";
            this.PrecioCompra.Name = "PrecioCompra";
            this.PrecioCompra.ReadOnly = true;
            this.PrecioCompra.Visible = false;
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio de venta";
            this.PrecioVenta.Name = "PrecioVenta";
            this.PrecioVenta.ReadOnly = true;
            this.PrecioVenta.Visible = false;
            // 
            // rJ_Label3
            // 
            this.rJ_Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label3.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label3.BorderRadius = 8;
            this.rJ_Label3.BorderSize = 1;
            this.rJ_Label3.ForeColor = System.Drawing.Color.White;
            this.rJ_Label3.Location = new System.Drawing.Point(16, 17);
            this.rJ_Label3.Name = "rJ_Label3";
            this.rJ_Label3.Size = new System.Drawing.Size(742, 635);
            this.rJ_Label3.TabIndex = 66;
            this.rJ_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Label3.TextColor = System.Drawing.Color.White;
            // 
            // btnLimpiarmdProducto
            // 
            this.btnLimpiarmdProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarmdProducto.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLimpiarmdProducto.BorderColor = System.Drawing.Color.DimGray;
            this.btnLimpiarmdProducto.BorderRadius = 5;
            this.btnLimpiarmdProducto.BorderSize = 1;
            this.btnLimpiarmdProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarmdProducto.FlatAppearance.BorderSize = 0;
            this.btnLimpiarmdProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarmdProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnLimpiarmdProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarmdProducto.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarmdProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarmdProducto.Image = global::CapaPresentacion.Properties.Resources.BroomBlack;
            this.btnLimpiarmdProducto.Location = new System.Drawing.Point(690, 38);
            this.btnLimpiarmdProducto.Name = "btnLimpiarmdProducto";
            this.btnLimpiarmdProducto.Padding = new System.Windows.Forms.Padding(5);
            this.btnLimpiarmdProducto.Size = new System.Drawing.Size(40, 31);
            this.btnLimpiarmdProducto.TabIndex = 74;
            this.btnLimpiarmdProducto.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarmdProducto.UseVisualStyleBackColor = false;
            this.btnLimpiarmdProducto.Click += new System.EventHandler(this.btnmdLimpiarBusquedaProducto_Click);
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
            this.btnmdBuscarProducto.Location = new System.Drawing.Point(644, 38);
            this.btnmdBuscarProducto.Name = "btnmdBuscarProducto";
            this.btnmdBuscarProducto.Padding = new System.Windows.Forms.Padding(5);
            this.btnmdBuscarProducto.Size = new System.Drawing.Size(40, 31);
            this.btnmdBuscarProducto.TabIndex = 75;
            this.btnmdBuscarProducto.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnmdBuscarProducto.UseVisualStyleBackColor = false;
            this.btnmdBuscarProducto.Click += new System.EventHandler(this.btnmdBuscarProducto_Click);
            // 
            // Form_mdProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(775, 668);
            this.Controls.Add(this.btnmdBuscarProducto);
            this.Controls.Add(this.btnLimpiarmdProducto);
            this.Controls.Add(this.rJ_Label4);
            this.Controls.Add(this.txtmdBusquedaProducto);
            this.Controls.Add(this.cbbmdBuscarProducto);
            this.Controls.Add(this.rJ_Label5);
            this.Controls.Add(this.dgvListadoMdProducto);
            this.Controls.Add(this.rJ_Label3);
            this.Name = "Form_mdProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_mdProducto";
            this.Load += new System.EventHandler(this.Form_mdProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMdProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls_Plus.RJ_Label rJ_Label4;
        private ControlsLibrary.RJ_TextBox txtmdBusquedaProducto;
        private System.Windows.Forms.ComboBox cbbmdBuscarProducto;
        private Custom_Controls_Plus.RJ_Label rJ_Label5;
        private Custom_Controls_Plus.RJDataGridView dgvListadoMdProducto;
        private Custom_Controls_Plus.RJ_Label rJ_Label3;
        private Custom_Controls_Plus.RJ_Button btnLimpiarmdProducto;
        private Custom_Controls_Plus.RJ_Button btnmdBuscarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdmdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
    }
}