namespace CapaPresentacion.Formularios.Modales
{
    partial class Form_mdCliente
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
            this.txtmdBusquedaCliente = new ControlsLibrary.RJ_TextBox();
            this.cbbmdBuscarCliente = new System.Windows.Forms.ComboBox();
            this.rJ_Label5 = new Custom_Controls_Plus.RJ_Label();
            this.btnmdBuscarCliente = new Custom_Controls_Plus.RJ_Button();
            this.btnLimpiarmdCliente = new Custom_Controls_Plus.RJ_Button();
            this.rJ_Label3 = new Custom_Controls_Plus.RJ_Label();
            this.dgvListadoClientes = new Custom_Controls_Plus.RJDataGridView();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
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
            this.rJ_Label4.TabIndex = 77;
            this.rJ_Label4.Text = "Lista de Clientes:";
            this.rJ_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label4.TextColor = System.Drawing.Color.Black;
            // 
            // txtmdBusquedaCliente
            // 
            this.txtmdBusquedaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtmdBusquedaCliente.BorderColor = System.Drawing.Color.DimGray;
            this.txtmdBusquedaCliente.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtmdBusquedaCliente.BorderRadius = 5;
            this.txtmdBusquedaCliente.BorderSize = 1;
            this.txtmdBusquedaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmdBusquedaCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmdBusquedaCliente.Location = new System.Drawing.Point(484, 36);
            this.txtmdBusquedaCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtmdBusquedaCliente.Multiline = false;
            this.txtmdBusquedaCliente.Name = "txtmdBusquedaCliente";
            this.txtmdBusquedaCliente.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtmdBusquedaCliente.PasswordChar = false;
            this.txtmdBusquedaCliente.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtmdBusquedaCliente.PlaceholderText = "Ingrese lo que busca...";
            this.txtmdBusquedaCliente.ReadOnly = false;
            this.txtmdBusquedaCliente.Size = new System.Drawing.Size(153, 31);
            this.txtmdBusquedaCliente.TabIndex = 81;
            this.txtmdBusquedaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtmdBusquedaCliente.UnderlinedStyle = true;
            // 
            // cbbmdBuscarCliente
            // 
            this.cbbmdBuscarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbbmdBuscarCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmdBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbmdBuscarCliente.FormattingEnabled = true;
            this.cbbmdBuscarCliente.Location = new System.Drawing.Point(333, 42);
            this.cbbmdBuscarCliente.Name = "cbbmdBuscarCliente";
            this.cbbmdBuscarCliente.Size = new System.Drawing.Size(144, 25);
            this.cbbmdBuscarCliente.TabIndex = 80;
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
            this.rJ_Label5.TabIndex = 79;
            this.rJ_Label5.Text = "Buscar por:";
            this.rJ_Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label5.TextColor = System.Drawing.Color.Black;
            // 
            // btnmdBuscarCliente
            // 
            this.btnmdBuscarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnmdBuscarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnmdBuscarCliente.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnmdBuscarCliente.BorderColor = System.Drawing.Color.DimGray;
            this.btnmdBuscarCliente.BorderRadius = 5;
            this.btnmdBuscarCliente.BorderSize = 1;
            this.btnmdBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmdBuscarCliente.FlatAppearance.BorderSize = 0;
            this.btnmdBuscarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnmdBuscarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnmdBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmdBuscarCliente.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmdBuscarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnmdBuscarCliente.Image = global::CapaPresentacion.Properties.Resources.SearchBlack;
            this.btnmdBuscarCliente.Location = new System.Drawing.Point(644, 38);
            this.btnmdBuscarCliente.Name = "btnmdBuscarCliente";
            this.btnmdBuscarCliente.Padding = new System.Windows.Forms.Padding(5);
            this.btnmdBuscarCliente.Size = new System.Drawing.Size(40, 31);
            this.btnmdBuscarCliente.TabIndex = 83;
            this.btnmdBuscarCliente.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnmdBuscarCliente.UseVisualStyleBackColor = false;
            this.btnmdBuscarCliente.Click += new System.EventHandler(this.btnmdBuscarCliente_Click);
            // 
            // btnLimpiarmdCliente
            // 
            this.btnLimpiarmdCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarmdCliente.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLimpiarmdCliente.BorderColor = System.Drawing.Color.DimGray;
            this.btnLimpiarmdCliente.BorderRadius = 5;
            this.btnLimpiarmdCliente.BorderSize = 1;
            this.btnLimpiarmdCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarmdCliente.FlatAppearance.BorderSize = 0;
            this.btnLimpiarmdCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarmdCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnLimpiarmdCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarmdCliente.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarmdCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarmdCliente.Image = global::CapaPresentacion.Properties.Resources.BroomBlack;
            this.btnLimpiarmdCliente.Location = new System.Drawing.Point(690, 38);
            this.btnLimpiarmdCliente.Name = "btnLimpiarmdCliente";
            this.btnLimpiarmdCliente.Padding = new System.Windows.Forms.Padding(5);
            this.btnLimpiarmdCliente.Size = new System.Drawing.Size(40, 31);
            this.btnLimpiarmdCliente.TabIndex = 82;
            this.btnLimpiarmdCliente.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarmdCliente.UseVisualStyleBackColor = false;
            this.btnLimpiarmdCliente.Click += new System.EventHandler(this.btnLimpiarmdCliente_Click);
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
            this.rJ_Label3.TabIndex = 76;
            this.rJ_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Label3.TextColor = System.Drawing.Color.White;
            // 
            // dgvListadoClientes
            // 
            this.dgvListadoClientes.AllowUserToAddRows = false;
            this.dgvListadoClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoClientes.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoClientes.BorderColor = System.Drawing.Color.DimGray;
            this.dgvListadoClientes.BorderRadius = 5;
            this.dgvListadoClientes.BorderSize = 1;
            this.dgvListadoClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvListadoClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Documento,
            this.NombreCompleto});
            this.dgvListadoClientes.Location = new System.Drawing.Point(34, 83);
            this.dgvListadoClientes.MultiSelect = false;
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoClientes.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoClientes.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListadoClientes.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoClientes.Size = new System.Drawing.Size(705, 553);
            this.dgvListadoClientes.TabIndex = 84;
            this.dgvListadoClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoClientes_CellDoubleClick);
            // 
            // Documento
            // 
            this.Documento.FillWeight = 150F;
            this.Documento.HeaderText = "Nro.Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.FillWeight = 180F;
            this.NombreCompleto.HeaderText = "Nombre completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            // 
            // Form_mdCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(775, 668);
            this.Controls.Add(this.dgvListadoClientes);
            this.Controls.Add(this.btnmdBuscarCliente);
            this.Controls.Add(this.btnLimpiarmdCliente);
            this.Controls.Add(this.rJ_Label4);
            this.Controls.Add(this.txtmdBusquedaCliente);
            this.Controls.Add(this.cbbmdBuscarCliente);
            this.Controls.Add(this.rJ_Label5);
            this.Controls.Add(this.rJ_Label3);
            this.Name = "Form_mdCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_mdCliente";
            this.Load += new System.EventHandler(this.Form_mdCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls_Plus.RJ_Label rJ_Label4;
        private ControlsLibrary.RJ_TextBox txtmdBusquedaCliente;
        private System.Windows.Forms.ComboBox cbbmdBuscarCliente;
        private Custom_Controls_Plus.RJ_Label rJ_Label5;
        private Custom_Controls_Plus.RJ_Button btnmdBuscarCliente;
        private Custom_Controls_Plus.RJ_Button btnLimpiarmdCliente;
        private Custom_Controls_Plus.RJ_Label rJ_Label3;
        private Custom_Controls_Plus.RJDataGridView dgvListadoClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
    }
}