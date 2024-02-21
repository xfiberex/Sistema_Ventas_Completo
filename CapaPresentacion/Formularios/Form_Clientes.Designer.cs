namespace CapaPresentacion.Formularios
{
    partial class Form_Clientes
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
            this.btnLimpiarBusquedaClient = new Custom_Controls_Plus.RJ_Button();
            this.btnEliminarClient = new Custom_Controls_Plus.RJ_Button();
            this.rJ_Label4 = new Custom_Controls_Plus.RJ_Label();
            this.rJ_Label3 = new Custom_Controls_Plus.RJ_Label();
            this.rJ_Label2 = new Custom_Controls_Plus.RJ_Label();
            this.btnLimpiarDatosClient = new Custom_Controls_Plus.RJ_Button();
            this.txtTelefonoClient = new ControlsLibrary.RJ_TextBox();
            this.txtCorreoClient = new ControlsLibrary.RJ_TextBox();
            this.txtNombreCompletoClient = new ControlsLibrary.RJ_TextBox();
            this.txtDocumentoClient = new ControlsLibrary.RJ_TextBox();
            this.rJ_Label1 = new Custom_Controls_Plus.RJ_Label();
            this.btnGuardarClient = new Custom_Controls_Plus.RJ_Button();
            this.txtIndiceClient = new System.Windows.Forms.TextBox();
            this.txtBusquedaClient = new ControlsLibrary.RJ_TextBox();
            this.cbbBuscarClient = new System.Windows.Forms.ComboBox();
            this.rJ_Label5 = new Custom_Controls_Plus.RJ_Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.dgvListadoClientes = new Custom_Controls_Plus.RJDataGridView();
            this.cbbEstadoClient = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarClient = new Custom_Controls_Plus.RJ_Button();
            this.btnSeleccionarCliente = new System.Windows.Forms.DataGridViewButtonColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstadoValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpiarBusquedaClient
            // 
            this.btnLimpiarBusquedaClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiarBusquedaClient.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBusquedaClient.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBusquedaClient.BorderColor = System.Drawing.Color.DimGray;
            this.btnLimpiarBusquedaClient.BorderRadius = 5;
            this.btnLimpiarBusquedaClient.BorderSize = 1;
            this.btnLimpiarBusquedaClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarBusquedaClient.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBusquedaClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusquedaClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.btnLimpiarBusquedaClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBusquedaClient.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusquedaClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusquedaClient.Image = global::CapaPresentacion.Properties.Resources.BroomBlack;
            this.btnLimpiarBusquedaClient.Location = new System.Drawing.Point(1018, 30);
            this.btnLimpiarBusquedaClient.Name = "btnLimpiarBusquedaClient";
            this.btnLimpiarBusquedaClient.Padding = new System.Windows.Forms.Padding(5);
            this.btnLimpiarBusquedaClient.Size = new System.Drawing.Size(40, 31);
            this.btnLimpiarBusquedaClient.TabIndex = 55;
            this.btnLimpiarBusquedaClient.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarBusquedaClient.UseVisualStyleBackColor = false;
            this.btnLimpiarBusquedaClient.Click += new System.EventHandler(this.btnLimpiarBusquedaClient_Click);
            // 
            // btnEliminarClient
            // 
            this.btnEliminarClient.BackColor = System.Drawing.Color.IndianRed;
            this.btnEliminarClient.BackgroundColor = System.Drawing.Color.IndianRed;
            this.btnEliminarClient.BorderColor = System.Drawing.Color.DimGray;
            this.btnEliminarClient.BorderRadius = 5;
            this.btnEliminarClient.BorderSize = 1;
            this.btnEliminarClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarClient.FlatAppearance.BorderSize = 0;
            this.btnEliminarClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarClient.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnEliminarClient.Image = global::CapaPresentacion.Properties.Resources.Trash30;
            this.btnEliminarClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarClient.Location = new System.Drawing.Point(24, 484);
            this.btnEliminarClient.Name = "btnEliminarClient";
            this.btnEliminarClient.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.btnEliminarClient.Size = new System.Drawing.Size(193, 40);
            this.btnEliminarClient.TabIndex = 46;
            this.btnEliminarClient.Text = "Eliminar";
            this.btnEliminarClient.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnEliminarClient.UseVisualStyleBackColor = false;
            this.btnEliminarClient.Click += new System.EventHandler(this.btnEliminarClient_Click);
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
            this.rJ_Label4.Text = "Lista de Clientes";
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
            this.rJ_Label2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rJ_Label2.Size = new System.Drawing.Size(192, 43);
            this.rJ_Label2.TabIndex = 47;
            this.rJ_Label2.Text = "Detalles del Cliente";
            this.rJ_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_Label2.TextColor = System.Drawing.Color.Black;
            // 
            // btnLimpiarDatosClient
            // 
            this.btnLimpiarDatosClient.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarDatosClient.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.btnLimpiarDatosClient.BorderColor = System.Drawing.Color.DimGray;
            this.btnLimpiarDatosClient.BorderRadius = 5;
            this.btnLimpiarDatosClient.BorderSize = 1;
            this.btnLimpiarDatosClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiarDatosClient.FlatAppearance.BorderSize = 0;
            this.btnLimpiarDatosClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarDatosClient.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarDatosClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarDatosClient.Image = global::CapaPresentacion.Properties.Resources.DeleteDetails;
            this.btnLimpiarDatosClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarDatosClient.Location = new System.Drawing.Point(24, 438);
            this.btnLimpiarDatosClient.Name = "btnLimpiarDatosClient";
            this.btnLimpiarDatosClient.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.btnLimpiarDatosClient.Size = new System.Drawing.Size(193, 40);
            this.btnLimpiarDatosClient.TabIndex = 45;
            this.btnLimpiarDatosClient.Text = "Limpiar detalles";
            this.btnLimpiarDatosClient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarDatosClient.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnLimpiarDatosClient.UseVisualStyleBackColor = false;
            this.btnLimpiarDatosClient.Click += new System.EventHandler(this.btnLimpiarDatosClient_Click);
            // 
            // txtTelefonoClient
            // 
            this.txtTelefonoClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtTelefonoClient.BorderColor = System.Drawing.Color.DimGray;
            this.txtTelefonoClient.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtTelefonoClient.BorderRadius = 5;
            this.txtTelefonoClient.BorderSize = 1;
            this.txtTelefonoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefonoClient.ForeColor = System.Drawing.Color.Black;
            this.txtTelefonoClient.Location = new System.Drawing.Point(25, 290);
            this.txtTelefonoClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoClient.Multiline = false;
            this.txtTelefonoClient.Name = "txtTelefonoClient";
            this.txtTelefonoClient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTelefonoClient.PasswordChar = false;
            this.txtTelefonoClient.PlaceholderColor = System.Drawing.Color.Black;
            this.txtTelefonoClient.PlaceholderText = "Ingrese el telefono";
            this.txtTelefonoClient.Size = new System.Drawing.Size(192, 31);
            this.txtTelefonoClient.TabIndex = 37;
            this.txtTelefonoClient.UnderlinedStyle = false;
            // 
            // txtCorreoClient
            // 
            this.txtCorreoClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtCorreoClient.BorderColor = System.Drawing.Color.DimGray;
            this.txtCorreoClient.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtCorreoClient.BorderRadius = 5;
            this.txtCorreoClient.BorderSize = 1;
            this.txtCorreoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreoClient.ForeColor = System.Drawing.Color.Black;
            this.txtCorreoClient.Location = new System.Drawing.Point(25, 228);
            this.txtCorreoClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoClient.Multiline = false;
            this.txtCorreoClient.Name = "txtCorreoClient";
            this.txtCorreoClient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtCorreoClient.PasswordChar = false;
            this.txtCorreoClient.PlaceholderColor = System.Drawing.Color.Black;
            this.txtCorreoClient.PlaceholderText = "Ingrese el correo";
            this.txtCorreoClient.Size = new System.Drawing.Size(192, 31);
            this.txtCorreoClient.TabIndex = 35;
            this.txtCorreoClient.UnderlinedStyle = false;
            // 
            // txtNombreCompletoClient
            // 
            this.txtNombreCompletoClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtNombreCompletoClient.BorderColor = System.Drawing.Color.DimGray;
            this.txtNombreCompletoClient.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtNombreCompletoClient.BorderRadius = 5;
            this.txtNombreCompletoClient.BorderSize = 1;
            this.txtNombreCompletoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCompletoClient.ForeColor = System.Drawing.Color.Black;
            this.txtNombreCompletoClient.Location = new System.Drawing.Point(25, 166);
            this.txtNombreCompletoClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCompletoClient.Multiline = false;
            this.txtNombreCompletoClient.Name = "txtNombreCompletoClient";
            this.txtNombreCompletoClient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNombreCompletoClient.PasswordChar = false;
            this.txtNombreCompletoClient.PlaceholderColor = System.Drawing.Color.Black;
            this.txtNombreCompletoClient.PlaceholderText = "Ingrese el nombre";
            this.txtNombreCompletoClient.Size = new System.Drawing.Size(192, 31);
            this.txtNombreCompletoClient.TabIndex = 33;
            this.txtNombreCompletoClient.UnderlinedStyle = false;
            // 
            // txtDocumentoClient
            // 
            this.txtDocumentoClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtDocumentoClient.BorderColor = System.Drawing.Color.DimGray;
            this.txtDocumentoClient.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtDocumentoClient.BorderRadius = 5;
            this.txtDocumentoClient.BorderSize = 1;
            this.txtDocumentoClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocumentoClient.ForeColor = System.Drawing.Color.Black;
            this.txtDocumentoClient.Location = new System.Drawing.Point(25, 104);
            this.txtDocumentoClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumentoClient.Multiline = false;
            this.txtDocumentoClient.Name = "txtDocumentoClient";
            this.txtDocumentoClient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDocumentoClient.PasswordChar = false;
            this.txtDocumentoClient.PlaceholderColor = System.Drawing.Color.Black;
            this.txtDocumentoClient.PlaceholderText = "Ingrese el numero";
            this.txtDocumentoClient.Size = new System.Drawing.Size(192, 31);
            this.txtDocumentoClient.TabIndex = 31;
            this.txtDocumentoClient.UnderlinedStyle = false;
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
            // btnGuardarClient
            // 
            this.btnGuardarClient.BackColor = System.Drawing.Color.ForestGreen;
            this.btnGuardarClient.BackgroundColor = System.Drawing.Color.ForestGreen;
            this.btnGuardarClient.BorderColor = System.Drawing.Color.DimGray;
            this.btnGuardarClient.BorderRadius = 5;
            this.btnGuardarClient.BorderSize = 1;
            this.btnGuardarClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarClient.FlatAppearance.BorderSize = 0;
            this.btnGuardarClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarClient.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnGuardarClient.Image = global::CapaPresentacion.Properties.Resources.save30;
            this.btnGuardarClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarClient.Location = new System.Drawing.Point(24, 392);
            this.btnGuardarClient.Name = "btnGuardarClient";
            this.btnGuardarClient.Padding = new System.Windows.Forms.Padding(30, 0, 10, 0);
            this.btnGuardarClient.Size = new System.Drawing.Size(193, 40);
            this.btnGuardarClient.TabIndex = 44;
            this.btnGuardarClient.Text = "Guardar";
            this.btnGuardarClient.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnGuardarClient.UseVisualStyleBackColor = false;
            this.btnGuardarClient.Click += new System.EventHandler(this.btnGuardarClient_Click);
            // 
            // txtIndiceClient
            // 
            this.txtIndiceClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtIndiceClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndiceClient.Location = new System.Drawing.Point(145, 79);
            this.txtIndiceClient.Name = "txtIndiceClient";
            this.txtIndiceClient.ReadOnly = true;
            this.txtIndiceClient.Size = new System.Drawing.Size(33, 21);
            this.txtIndiceClient.TabIndex = 56;
            this.txtIndiceClient.Text = "0";
            this.txtIndiceClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBusquedaClient
            // 
            this.txtBusquedaClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusquedaClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtBusquedaClient.BorderColor = System.Drawing.Color.DimGray;
            this.txtBusquedaClient.BorderFocusColor = System.Drawing.Color.DodgerBlue;
            this.txtBusquedaClient.BorderRadius = 5;
            this.txtBusquedaClient.BorderSize = 1;
            this.txtBusquedaClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusquedaClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBusquedaClient.Location = new System.Drawing.Point(812, 30);
            this.txtBusquedaClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtBusquedaClient.Multiline = false;
            this.txtBusquedaClient.Name = "txtBusquedaClient";
            this.txtBusquedaClient.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtBusquedaClient.PasswordChar = false;
            this.txtBusquedaClient.PlaceholderColor = System.Drawing.Color.DimGray;
            this.txtBusquedaClient.PlaceholderText = "Ingrese lo que busca...";
            this.txtBusquedaClient.Size = new System.Drawing.Size(153, 31);
            this.txtBusquedaClient.TabIndex = 54;
            this.txtBusquedaClient.UnderlinedStyle = true;
            // 
            // cbbBuscarClient
            // 
            this.cbbBuscarClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbBuscarClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbbBuscarClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBuscarClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBuscarClient.FormattingEnabled = true;
            this.cbbBuscarClient.Location = new System.Drawing.Point(661, 34);
            this.cbbBuscarClient.Name = "cbbBuscarClient";
            this.cbbBuscarClient.Size = new System.Drawing.Size(144, 25);
            this.cbbBuscarClient.TabIndex = 53;
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
            // txtIdCliente
            // 
            this.txtIdCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.txtIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdCliente.Location = new System.Drawing.Point(184, 79);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.ReadOnly = true;
            this.txtIdCliente.Size = new System.Drawing.Size(33, 21);
            this.txtIdCliente.TabIndex = 51;
            this.txtIdCliente.Text = "0";
            this.txtIdCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnSeleccionarCliente,
            this.IdCliente,
            this.Documento,
            this.NombreCompleto,
            this.Correo,
            this.Telefono,
            this.EstadoValor,
            this.Estado});
            this.dgvListadoClientes.Location = new System.Drawing.Point(253, 77);
            this.dgvListadoClientes.MultiSelect = false;
            this.dgvListadoClientes.Name = "dgvListadoClientes";
            this.dgvListadoClientes.ReadOnly = true;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvListadoClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListadoClientes.Size = new System.Drawing.Size(814, 564);
            this.dgvListadoClientes.TabIndex = 50;
            this.dgvListadoClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoClientesClient_CellContentClick);
            this.dgvListadoClientes.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgvListadoClientesClient_CellPainting);
            // 
            // cbbEstadoClient
            // 
            this.cbbEstadoClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.cbbEstadoClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbEstadoClient.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbEstadoClient.FormattingEnabled = true;
            this.cbbEstadoClient.Location = new System.Drawing.Point(25, 352);
            this.cbbEstadoClient.Name = "cbbEstadoClient";
            this.cbbEstadoClient.Size = new System.Drawing.Size(192, 25);
            this.cbbEstadoClient.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 23);
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
            this.label2.Text = "Nombre completo:";
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
            // btnBuscarClient
            // 
            this.btnBuscarClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscarClient.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarClient.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnBuscarClient.BorderColor = System.Drawing.Color.DimGray;
            this.btnBuscarClient.BorderRadius = 5;
            this.btnBuscarClient.BorderSize = 1;
            this.btnBuscarClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarClient.FlatAppearance.BorderSize = 0;
            this.btnBuscarClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarClient.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarClient.Image = global::CapaPresentacion.Properties.Resources.SearchBlack;
            this.btnBuscarClient.Location = new System.Drawing.Point(972, 30);
            this.btnBuscarClient.Name = "btnBuscarClient";
            this.btnBuscarClient.Padding = new System.Windows.Forms.Padding(5);
            this.btnBuscarClient.Size = new System.Drawing.Size(40, 31);
            this.btnBuscarClient.TabIndex = 58;
            this.btnBuscarClient.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.btnBuscarClient.UseVisualStyleBackColor = false;
            this.btnBuscarClient.Click += new System.EventHandler(this.btnBuscarClient_Click);
            // 
            // btnSeleccionarCliente
            // 
            this.btnSeleccionarCliente.FillWeight = 30F;
            this.btnSeleccionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionarCliente.HeaderText = "";
            this.btnSeleccionarCliente.Name = "btnSeleccionarCliente";
            this.btnSeleccionarCliente.ReadOnly = true;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "ID";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Visible = false;
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
            // Form_Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(244)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1098, 662);
            this.Controls.Add(this.btnBuscarClient);
            this.Controls.Add(this.btnLimpiarBusquedaClient);
            this.Controls.Add(this.btnEliminarClient);
            this.Controls.Add(this.rJ_Label4);
            this.Controls.Add(this.rJ_Label2);
            this.Controls.Add(this.btnLimpiarDatosClient);
            this.Controls.Add(this.txtTelefonoClient);
            this.Controls.Add(this.txtCorreoClient);
            this.Controls.Add(this.txtNombreCompletoClient);
            this.Controls.Add(this.txtDocumentoClient);
            this.Controls.Add(this.btnGuardarClient);
            this.Controls.Add(this.txtIndiceClient);
            this.Controls.Add(this.txtBusquedaClient);
            this.Controls.Add(this.cbbBuscarClient);
            this.Controls.Add(this.rJ_Label5);
            this.Controls.Add(this.txtIdCliente);
            this.Controls.Add(this.dgvListadoClientes);
            this.Controls.Add(this.cbbEstadoClient);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rJ_Label1);
            this.Controls.Add(this.rJ_Label3);
            this.Name = "Form_Clientes";
            this.Text = "Form_Clientes";
            this.Load += new System.EventHandler(this.Form_Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Custom_Controls_Plus.RJ_Button btnLimpiarBusquedaClient;
        private Custom_Controls_Plus.RJ_Button btnEliminarClient;
        private Custom_Controls_Plus.RJ_Label rJ_Label4;
        private Custom_Controls_Plus.RJ_Label rJ_Label3;
        private Custom_Controls_Plus.RJ_Label rJ_Label2;
        private Custom_Controls_Plus.RJ_Button btnLimpiarDatosClient;
        private ControlsLibrary.RJ_TextBox txtTelefonoClient;
        private ControlsLibrary.RJ_TextBox txtCorreoClient;
        private ControlsLibrary.RJ_TextBox txtNombreCompletoClient;
        private ControlsLibrary.RJ_TextBox txtDocumentoClient;
        private Custom_Controls_Plus.RJ_Label rJ_Label1;
        private Custom_Controls_Plus.RJ_Button btnGuardarClient;
        private System.Windows.Forms.TextBox txtIndiceClient;
        private ControlsLibrary.RJ_TextBox txtBusquedaClient;
        private System.Windows.Forms.ComboBox cbbBuscarClient;
        private Custom_Controls_Plus.RJ_Label rJ_Label5;
        private System.Windows.Forms.TextBox txtIdCliente;
        private Custom_Controls_Plus.RJDataGridView dgvListadoClientes;
        private System.Windows.Forms.ComboBox cbbEstadoClient;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Custom_Controls_Plus.RJ_Button btnBuscarClient;
        private System.Windows.Forms.DataGridViewButtonColumn btnSeleccionarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstadoValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}