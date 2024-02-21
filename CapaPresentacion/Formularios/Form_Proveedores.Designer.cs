namespace CapaPresentacion.Formularios
{
    partial class Form_Proveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscarProv = new Custom_Controls_Plus.RJ_Button();
            this.btnLimpiarBusquedaProv = new Custom_Controls_Plus.RJ_Button();
            this.btnEliminarProv = new Custom_Controls_Plus.RJ_Button();
            this.rJ_Label4 = new Custom_Controls_Plus.RJ_Label();
            this.rJ_Label3 = new Custom_Controls_Plus.RJ_Label();
            this.rJ_Label2 = new Custom_Controls_Plus.RJ_Label();
            this.btnLimpiarDatosProv = new Custom_Controls_Plus.RJ_Button();
            this.txtTelefonoProv = new ControlsLibrary.RJ_TextBox();
            this.txtCorreoProv = new ControlsLibrary.RJ_TextBox();
            this.txtRazonSocialProv = new ControlsLibrary.RJ_TextBox();
            this.txtDocumentoProv = new ControlsLibrary.RJ_TextBox();
            this.rJ_Label1 = new Custom_Controls_Plus.RJ_Label();
            this.btnGuardarProv = new Custom_Controls_Plus.RJ_Button();
            this.txtIndiceProv = new System.Windows.Forms.TextBox();
            this.txtBusquedaProv = new ControlsLibrary.RJ_TextBox();
            this.cbbBuscarProv = new System.Windows.Forms.ComboBox();
            this.rJ_Label5 = new Custom_Controls_Plus.RJ_Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.dgvListadoProveedores = new Custom_Controls_Plus.RJDataGridView();
            this.cbbEstadoProv = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionarProveedor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscarProv
            // 
            this.btnBuscarProv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnBuscarProv.Location = new System.Drawing.Point(972, 30);
            this.btnBuscarProv.Name = "btnBuscarProv";
            this.btnBuscarProv.Padding = new System.Windows.Forms.Padding(5);
            this.btnBuscarProv.Size = new System.Drawing.Size(40, 31);
            this.btnBuscarProv.TabIndex = 57;
            this.btnBuscarProv.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarProv.UseVisualStyleBackColor = false;
            this.btnBuscarProv.Click += new System.EventHandler(this.btnBuscarProv_Click);
            // 
            // btnLimpiarBusquedaProv
            // 
            this.btnLimpiarBusquedaProv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            this.btnLimpiarBusquedaProv.Location = new System.Drawing.Point(1018, 30);
            this.btnLimpiarBusquedaProv.Name = "btnLimpiarBusquedaProv";
            this.btnLimpiarBusquedaProv.Padding = new System.Windows.Forms.Padding(5);
            this.btnLimpiarBusquedaProv.Size = new System.Drawing.Size(40, 31);
            this.btnLimpiarBusquedaProv.TabIndex = 55;
            this.btnLimpiarBusquedaProv.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusquedaProv.UseVisualStyleBackColor = false;
            this.btnLimpiarBusquedaProv.Click += new System.EventHandler(this.btnLimpiarBusquedaProv_Click);
            // 
            // btnEliminarProv
            // 
            this.btnEliminarProv.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarProv.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btnEliminarProv.BorderColor = System.Drawing.Color.DimGray;
            this.btnEliminarProv.BorderRadius = 5;
            this.btnEliminarProv.BorderSize = 1;
            this.btnEliminarProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProv.FlatAppearance.BorderSize = 0;
            this.btnEliminarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProv.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnEliminarProv.Image = global::CapaPresentacion.Properties.Resources.Trash30;
            this.btnEliminarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarProv.Location = new System.Drawing.Point(24, 484);
            this.btnEliminarProv.Name = "btnEliminarProv";
            this.btnEliminarProv.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.btnEliminarProv.Size = new System.Drawing.Size(193, 40);
            this.btnEliminarProv.TabIndex = 46;
            this.btnEliminarProv.Text = "Eliminar";
            this.btnEliminarProv.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnEliminarProv.UseVisualStyleBackColor = false;
            this.btnEliminarProv.Click += new System.EventHandler(this.btnEliminarProv_Click);
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
            this.rJ_Label4.Text = "Lista de Usuarios";
            this.rJ_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label4.TextColor = System.Drawing.Color.Black;
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
            this.rJ_Label2.Size = new System.Drawing.Size(192, 43);
            this.rJ_Label2.TabIndex = 47;
            this.rJ_Label2.Text = "Detalles del Proveedor";
            this.rJ_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Label2.TextColor = System.Drawing.Color.Black;
            // 
            // btnLimpiarDatosProv
            // 
            this.btnLimpiarDatosProv.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarDatosProv.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarDatosProv.BorderColor = System.Drawing.Color.DimGray;
            this.btnLimpiarDatosProv.BorderRadius = 5;
            this.btnLimpiarDatosProv.BorderSize = 1;
            this.btnLimpiarDatosProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarDatosProv.FlatAppearance.BorderSize = 0;
            this.btnLimpiarDatosProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatosProv.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatosProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarDatosProv.Image = global::CapaPresentacion.Properties.Resources.DeleteDetails;
            this.btnLimpiarDatosProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarDatosProv.Location = new System.Drawing.Point(24, 438);
            this.btnLimpiarDatosProv.Name = "btnLimpiarDatosProv";
            this.btnLimpiarDatosProv.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnLimpiarDatosProv.Size = new System.Drawing.Size(193, 40);
            this.btnLimpiarDatosProv.TabIndex = 45;
            this.btnLimpiarDatosProv.Text = "Limpiar detalles";
            this.btnLimpiarDatosProv.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDatosProv.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarDatosProv.UseVisualStyleBackColor = false;
            this.btnLimpiarDatosProv.Click += new System.EventHandler(this.btnLimpiarDatosProv_Click);
            // 
            // txtTelefonoProv
            // 
            this.txtTelefonoProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtTelefonoProv.BorderColor = System.Drawing.Color.DimGray;
            this.txtTelefonoProv.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtTelefonoProv.BorderRadius = 5;
            this.txtTelefonoProv.BorderSize = 1;
            this.txtTelefonoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoProv.ForeColor = System.Drawing.Color.Black;
            this.txtTelefonoProv.Location = new System.Drawing.Point(25, 290);
            this.txtTelefonoProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoProv.Multiline = false;
            this.txtTelefonoProv.Name = "txtTelefonoProv";
            this.txtTelefonoProv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefonoProv.PasswordChar = false;
            this.txtTelefonoProv.PlaceholderColor = System.Drawing.Color.Black;
            this.txtTelefonoProv.PlaceholderText = "Ingrese el telefono";
            this.txtTelefonoProv.Size = new System.Drawing.Size(192, 31);
            this.txtTelefonoProv.TabIndex = 37;
            this.txtTelefonoProv.UnderlinedStyle = false;
            // 
            // txtCorreoProv
            // 
            this.txtCorreoProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtCorreoProv.BorderColor = System.Drawing.Color.DimGray;
            this.txtCorreoProv.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtCorreoProv.BorderRadius = 5;
            this.txtCorreoProv.BorderSize = 1;
            this.txtCorreoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoProv.ForeColor = System.Drawing.Color.Black;
            this.txtCorreoProv.Location = new System.Drawing.Point(25, 228);
            this.txtCorreoProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoProv.Multiline = false;
            this.txtCorreoProv.Name = "txtCorreoProv";
            this.txtCorreoProv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCorreoProv.PasswordChar = false;
            this.txtCorreoProv.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCorreoProv.PlaceholderText = "Ingrese el correo";
            this.txtCorreoProv.Size = new System.Drawing.Size(192, 31);
            this.txtCorreoProv.TabIndex = 35;
            this.txtCorreoProv.UnderlinedStyle = false;
            // 
            // txtRazonSocialProv
            // 
            this.txtRazonSocialProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtRazonSocialProv.BorderColor = System.Drawing.Color.DimGray;
            this.txtRazonSocialProv.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtRazonSocialProv.BorderRadius = 5;
            this.txtRazonSocialProv.BorderSize = 1;
            this.txtRazonSocialProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocialProv.ForeColor = System.Drawing.Color.Black;
            this.txtRazonSocialProv.Location = new System.Drawing.Point(25, 166);
            this.txtRazonSocialProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtRazonSocialProv.Multiline = false;
            this.txtRazonSocialProv.Name = "txtRazonSocialProv";
            this.txtRazonSocialProv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtRazonSocialProv.PasswordChar = false;
            this.txtRazonSocialProv.PlaceholderColor = System.Drawing.Color.Black;
            this.txtRazonSocialProv.PlaceholderText = "Ingrese la razón social";
            this.txtRazonSocialProv.Size = new System.Drawing.Size(192, 31);
            this.txtRazonSocialProv.TabIndex = 33;
            this.txtRazonSocialProv.UnderlinedStyle = false;
            // 
            // txtDocumentoProv
            // 
            this.txtDocumentoProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtDocumentoProv.BorderColor = System.Drawing.Color.DimGray;
            this.txtDocumentoProv.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtDocumentoProv.BorderRadius = 5;
            this.txtDocumentoProv.BorderSize = 1;
            this.txtDocumentoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoProv.ForeColor = System.Drawing.Color.Black;
            this.txtDocumentoProv.Location = new System.Drawing.Point(25, 104);
            this.txtDocumentoProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumentoProv.Multiline = false;
            this.txtDocumentoProv.Name = "txtDocumentoProv";
            this.txtDocumentoProv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDocumentoProv.PasswordChar = false;
            this.txtDocumentoProv.PlaceholderColor = System.Drawing.Color.Black;
            this.txtDocumentoProv.PlaceholderText = "Ingrese el numero";
            this.txtDocumentoProv.Size = new System.Drawing.Size(192, 31);
            this.txtDocumentoProv.TabIndex = 31;
            this.txtDocumentoProv.UnderlinedStyle = false;
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
            // btnGuardarProv
            // 
            this.btnGuardarProv.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardarProv.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnGuardarProv.BorderColor = System.Drawing.Color.DimGray;
            this.btnGuardarProv.BorderRadius = 5;
            this.btnGuardarProv.BorderSize = 1;
            this.btnGuardarProv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarProv.FlatAppearance.BorderSize = 0;
            this.btnGuardarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProv.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnGuardarProv.Image = global::CapaPresentacion.Properties.Resources.save30;
            this.btnGuardarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarProv.Location = new System.Drawing.Point(24, 392);
            this.btnGuardarProv.Name = "btnGuardarProv";
            this.btnGuardarProv.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.btnGuardarProv.Size = new System.Drawing.Size(193, 40);
            this.btnGuardarProv.TabIndex = 44;
            this.btnGuardarProv.Text = "Guardar";
            this.btnGuardarProv.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnGuardarProv.UseVisualStyleBackColor = false;
            this.btnGuardarProv.Click += new System.EventHandler(this.btnGuardarProv_Click);
            // 
            // txtIndiceProv
            // 
            this.txtIndiceProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtIndiceProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndiceProv.Location = new System.Drawing.Point(145, 79);
            this.txtIndiceProv.Name = "txtIndiceProv";
            this.txtIndiceProv.ReadOnly = true;
            this.txtIndiceProv.Size = new System.Drawing.Size(33, 21);
            this.txtIndiceProv.TabIndex = 56;
            this.txtIndiceProv.Text = "0";
            this.txtIndiceProv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBusquedaProv
            // 
            this.txtBusquedaProv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusquedaProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtBusquedaProv.BorderColor = System.Drawing.Color.DimGray;
            this.txtBusquedaProv.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtBusquedaProv.BorderRadius = 5;
            this.txtBusquedaProv.BorderSize = 1;
            this.txtBusquedaProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaProv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusquedaProv.Location = new System.Drawing.Point(812, 30);
            this.txtBusquedaProv.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaProv.Multiline = false;
            this.txtBusquedaProv.Name = "txtBusquedaProv";
            this.txtBusquedaProv.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusquedaProv.PasswordChar = false;
            this.txtBusquedaProv.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtBusquedaProv.PlaceholderText = "Ingrese lo que busca...";
            this.txtBusquedaProv.Size = new System.Drawing.Size(153, 31);
            this.txtBusquedaProv.TabIndex = 54;
            this.txtBusquedaProv.UnderlinedStyle = true;
            // 
            // cbbBuscarProv
            // 
            this.cbbBuscarProv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbBuscarProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbbBuscarProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBuscarProv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBuscarProv.FormattingEnabled = true;
            this.cbbBuscarProv.Location = new System.Drawing.Point(661, 34);
            this.cbbBuscarProv.Name = "cbbBuscarProv";
            this.cbbBuscarProv.Size = new System.Drawing.Size(144, 25);
            this.cbbBuscarProv.TabIndex = 53;
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
            // txtIdProveedor
            // 
            this.txtIdProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtIdProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdProveedor.Location = new System.Drawing.Point(184, 79);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.ReadOnly = true;
            this.txtIdProveedor.Size = new System.Drawing.Size(33, 21);
            this.txtIdProveedor.TabIndex = 51;
            this.txtIdProveedor.Text = "0";
            this.txtIdProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvListadoProveedores
            // 
            this.dgvListadoProveedores.AllowUserToAddRows = false;
            this.dgvListadoProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoProveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoProveedores.BorderColor = System.Drawing.Color.DimGray;
            this.dgvListadoProveedores.BorderRadius = 5;
            this.dgvListadoProveedores.BorderSize = 1;
            this.dgvListadoProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvListadoProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnSeleccionarProveedor,
            this.IdProveedor,
            this.Documento,
            this.RazonSocial,
            this.Correo,
            this.Telefono,
            this.EstadoValor,
            this.Estado});
            this.dgvListadoProveedores.Location = new System.Drawing.Point(253, 77);
            this.dgvListadoProveedores.MultiSelect = false;
            this.dgvListadoProveedores.Name = "dgvListadoProveedores";
            this.dgvListadoProveedores.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoProveedores.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListadoProveedores.Size = new System.Drawing.Size(814, 564);
            this.dgvListadoProveedores.TabIndex = 50;
            this.dgvListadoProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoProveedorsProv_CellContentClick);
            this.dgvListadoProveedores.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListadoProveedorsProv_CellPainting);
            // 
            // cbbEstadoProv
            // 
            this.cbbEstadoProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbbEstadoProv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstadoProv.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstadoProv.FormattingEnabled = true;
            this.cbbEstadoProv.Location = new System.Drawing.Point(24, 352);
            this.cbbEstadoProv.Name = "cbbEstadoProv";
            this.cbbEstadoProv.Size = new System.Drawing.Size(193, 25);
            this.cbbEstadoProv.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 23);
            this.label7.TabIndex = 42;
            this.label7.Text = "Estado:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 23);
            this.label4.TabIndex = 36;
            this.label4.Text = "Telefono:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 23);
            this.label3.TabIndex = 34;
            this.label3.Text = "Correo:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Razon Social:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nro.Documento:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSeleccionarProveedor
            // 
            this.btnSeleccionarProveedor.FillWeight = 30F;
            this.btnSeleccionarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarProveedor.HeaderText = "";
            this.btnSeleccionarProveedor.Name = "btnSeleccionarProveedor";
            this.btnSeleccionarProveedor.ReadOnly = true;
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
            // Correo
            // 
            this.Correo.FillWeight = 150F;
            this.Correo.HeaderText = "Correo";
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Estado.DefaultCellStyle = dataGridViewCellStyle2;
            this.Estado.FillWeight = 51.5517F;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Form_Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1098, 662);
            this.Controls.Add(this.btnBuscarProv);
            this.Controls.Add(this.btnLimpiarBusquedaProv);
            this.Controls.Add(this.btnEliminarProv);
            this.Controls.Add(this.rJ_Label4);
            this.Controls.Add(this.rJ_Label2);
            this.Controls.Add(this.btnLimpiarDatosProv);
            this.Controls.Add(this.txtTelefonoProv);
            this.Controls.Add(this.txtCorreoProv);
            this.Controls.Add(this.txtRazonSocialProv);
            this.Controls.Add(this.txtDocumentoProv);
            this.Controls.Add(this.btnGuardarProv);
            this.Controls.Add(this.txtIndiceProv);
            this.Controls.Add(this.txtBusquedaProv);
            this.Controls.Add(this.cbbBuscarProv);
            this.Controls.Add(this.rJ_Label5);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.dgvListadoProveedores);
            this.Controls.Add(this.cbbEstadoProv);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rJ_Label1);
            this.Controls.Add(this.rJ_Label3);
            this.Name = "Form_Proveedores";
            this.Text = "Form_Proveedores";
            this.Load += new System.EventHandler(this.Form_Proveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom_Controls_Plus.RJ_Button btnBuscarProv;
        private Custom_Controls_Plus.RJ_Button btnLimpiarBusquedaProv;
        private Custom_Controls_Plus.RJ_Button btnEliminarProv;
        private Custom_Controls_Plus.RJ_Label rJ_Label4;
        private Custom_Controls_Plus.RJ_Label rJ_Label3;
        private Custom_Controls_Plus.RJ_Label rJ_Label2;
        private Custom_Controls_Plus.RJ_Button btnLimpiarDatosProv;
        private ControlsLibrary.RJ_TextBox txtTelefonoProv;
        private ControlsLibrary.RJ_TextBox txtCorreoProv;
        private ControlsLibrary.RJ_TextBox txtRazonSocialProv;
        private ControlsLibrary.RJ_TextBox txtDocumentoProv;
        private Custom_Controls_Plus.RJ_Label rJ_Label1;
        private Custom_Controls_Plus.RJ_Button btnGuardarProv;
        private System.Windows.Forms.TextBox txtIndiceProv;
        private ControlsLibrary.RJ_TextBox txtBusquedaProv;
        private System.Windows.Forms.ComboBox cbbBuscarProv;
        private Custom_Controls_Plus.RJ_Label rJ_Label5;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private Custom_Controls_Plus.RJDataGridView dgvListadoProveedores;
        private System.Windows.Forms.ComboBox cbbEstadoProv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionarProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}