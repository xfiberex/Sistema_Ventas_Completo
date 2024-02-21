namespace CapaPresentacion.Formularios.Modales
{
    partial class Form_mdProveedor
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
            this.txtBusquedaProv = new ControlsLibrary.RJ_TextBox();
            this.cbbBuscarProv = new System.Windows.Forms.ComboBox();
            this.rJ_Label5 = new Custom_Controls_Plus.RJ_Label();
            this.dgvListadoMdProv = new Custom_Controls_Plus.RJDataGridView();
            this.rJ_Label3 = new Custom_Controls_Plus.RJ_Label();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarProv = new Custom_Controls_Plus.RJ_Button();
            this.btnLimpiarBusquedaProv = new Custom_Controls_Plus.RJ_Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMdProv)).BeginInit();
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
            this.rJ_Label4.Location = new System.Drawing.Point(33, 32);
            this.rJ_Label4.Name = "rJ_Label4";
            this.rJ_Label4.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label4.Size = new System.Drawing.Size(188, 43);
            this.rJ_Label4.TabIndex = 59;
            this.rJ_Label4.Text = "Lista de Proveedores:";
            this.rJ_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label4.TextColor = System.Drawing.Color.Black;
            // 
            // txtBusquedaProv
            // 
            this.txtBusquedaProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtBusquedaProv.BorderColor = System.Drawing.Color.DimGray;
            this.txtBusquedaProv.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtBusquedaProv.BorderRadius = 5;
            this.txtBusquedaProv.BorderSize = 1;
            this.txtBusquedaProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusquedaProv.Location = new System.Drawing.Point(483, 37);
            this.txtBusquedaProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaProv.Multiline = false;
            this.txtBusquedaProv.Name = "txtBusquedaProv";
            this.txtBusquedaProv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusquedaProv.PasswordChar = false;
            this.txtBusquedaProv.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtBusquedaProv.PlaceholderText = "Ingrese lo que busca...";
            this.txtBusquedaProv.ReadOnly = false;
            this.txtBusquedaProv.Size = new System.Drawing.Size(153, 31);
            this.txtBusquedaProv.TabIndex = 63;
            this.txtBusquedaProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBusquedaProv.UnderlinedStyle = true;
            // 
            // cbbBuscarProv
            // 
            this.cbbBuscarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbbBuscarProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBuscarProv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBuscarProv.FormattingEnabled = true;
            this.cbbBuscarProv.Location = new System.Drawing.Point(332, 43);
            this.cbbBuscarProv.Name = "cbbBuscarProv";
            this.cbbBuscarProv.Size = new System.Drawing.Size(144, 25);
            this.cbbBuscarProv.TabIndex = 62;
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
            this.rJ_Label5.Location = new System.Drawing.Point(227, 32);
            this.rJ_Label5.Name = "rJ_Label5";
            this.rJ_Label5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label5.Size = new System.Drawing.Size(511, 43);
            this.rJ_Label5.TabIndex = 61;
            this.rJ_Label5.Text = "Buscar por:";
            this.rJ_Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label5.TextColor = System.Drawing.Color.Black;
            // 
            // dgvListadoMdProv
            // 
            this.dgvListadoMdProv.AllowUserToAddRows = false;
            this.dgvListadoMdProv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoMdProv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoMdProv.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoMdProv.BorderColor = System.Drawing.Color.DimGray;
            this.dgvListadoMdProv.BorderRadius = 5;
            this.dgvListadoMdProv.BorderSize = 1;
            this.dgvListadoMdProv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvListadoMdProv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoMdProv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoMdProv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProveedor,
            this.Documento,
            this.RazonSocial});
            this.dgvListadoMdProv.Location = new System.Drawing.Point(33, 86);
            this.dgvListadoMdProv.MultiSelect = false;
            this.dgvListadoMdProv.Name = "dgvListadoMdProv";
            this.dgvListadoMdProv.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoMdProv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoMdProv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvListadoMdProv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoMdProv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoMdProv.Size = new System.Drawing.Size(705, 552);
            this.dgvListadoMdProv.TabIndex = 60;
            this.dgvListadoMdProv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoMdProv_CellDoubleClick);
            // 
            // rJ_Label3
            // 
            this.rJ_Label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.rJ_Label3.BorderColor = System.Drawing.Color.DimGray;
            this.rJ_Label3.BorderRadius = 8;
            this.rJ_Label3.BorderSize = 1;
            this.rJ_Label3.ForeColor = System.Drawing.Color.White;
            this.rJ_Label3.Location = new System.Drawing.Point(15, 18);
            this.rJ_Label3.Name = "rJ_Label3";
            this.rJ_Label3.Size = new System.Drawing.Size(742, 635);
            this.rJ_Label3.TabIndex = 58;
            this.rJ_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Label3.TextColor = System.Drawing.Color.White;
            // 
            // IdProveedor
            // 
            this.IdProveedor.HeaderText = "ID";
            this.IdProveedor.Name = "IdProveedor";
            this.IdProveedor.ReadOnly = true;
            this.IdProveedor.Visible = false;
            // 
            // Documento
            // 
            this.Documento.FillWeight = 150F;
            this.Documento.HeaderText = "Nro.Documento";
            this.Documento.Name = "Documento";
            this.Documento.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.FillWeight = 180F;
            this.RazonSocial.HeaderText = "Razón Social";
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // btnBuscarProv
            // 
            this.btnBuscarProv.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarProv.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBuscarProv.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscarProv.BorderRadius = 5;
            this.btnBuscarProv.BorderSize = 1;
            this.btnBuscarProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProv.FlatAppearance.BorderSize = 0;
            this.btnBuscarProv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProv.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarProv.Image = global::CapaPresentacion.Properties.Resources.SearchBlack;
            this.btnBuscarProv.Location = new System.Drawing.Point(643, 39);
            this.btnBuscarProv.Name = "btnBuscarProv";
            this.btnBuscarProv.Padding = new System.Windows.Forms.Padding(5);
            this.btnBuscarProv.Size = new System.Drawing.Size(40, 31);
            this.btnBuscarProv.TabIndex = 65;
            this.btnBuscarProv.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarProv.UseVisualStyleBackColor = false;
            this.btnBuscarProv.Click += new System.EventHandler(this.btnBuscarProv_Click);
            // 
            // btnLimpiarBusquedaProv
            // 
            this.btnLimpiarBusquedaProv.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBusquedaProv.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBusquedaProv.BorderColor = System.Drawing.Color.DimGray;
            this.btnLimpiarBusquedaProv.BorderRadius = 5;
            this.btnLimpiarBusquedaProv.BorderSize = 1;
            this.btnLimpiarBusquedaProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBusquedaProv.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBusquedaProv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusquedaProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnLimpiarBusquedaProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusquedaProv.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusquedaProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusquedaProv.Image = global::CapaPresentacion.Properties.Resources.BroomBlack;
            this.btnLimpiarBusquedaProv.Location = new System.Drawing.Point(689, 39);
            this.btnLimpiarBusquedaProv.Name = "btnLimpiarBusquedaProv";
            this.btnLimpiarBusquedaProv.Padding = new System.Windows.Forms.Padding(5);
            this.btnLimpiarBusquedaProv.Size = new System.Drawing.Size(40, 31);
            this.btnLimpiarBusquedaProv.TabIndex = 64;
            this.btnLimpiarBusquedaProv.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusquedaProv.UseVisualStyleBackColor = false;
            this.btnLimpiarBusquedaProv.Click += new System.EventHandler(this.btnLimpiarBusquedaProv_Click);
            // 
            // Form_mdProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(775, 668);
            this.Controls.Add(this.btnBuscarProv);
            this.Controls.Add(this.btnLimpiarBusquedaProv);
            this.Controls.Add(this.rJ_Label4);
            this.Controls.Add(this.txtBusquedaProv);
            this.Controls.Add(this.cbbBuscarProv);
            this.Controls.Add(this.rJ_Label5);
            this.Controls.Add(this.dgvListadoMdProv);
            this.Controls.Add(this.rJ_Label3);
            this.Name = "Form_mdProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_mdProveedor";
            this.Load += new System.EventHandler(this.Form_mdProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoMdProv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Custom_Controls_Plus.RJ_Button btnBuscarProv;
        private Custom_Controls_Plus.RJ_Button btnLimpiarBusquedaProv;
        private Custom_Controls_Plus.RJ_Label rJ_Label4;
        private ControlsLibrary.RJ_TextBox txtBusquedaProv;
        private System.Windows.Forms.ComboBox cbbBuscarProv;
        private Custom_Controls_Plus.RJ_Label rJ_Label5;
        private Custom_Controls_Plus.RJDataGridView dgvListadoMdProv;
        private Custom_Controls_Plus.RJ_Label rJ_Label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
    }
}