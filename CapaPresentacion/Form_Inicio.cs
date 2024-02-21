using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Formularios;
using CapaPresentacion.Formularios.Modales;
using CapaPresentacion.Utilidades;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form_Inicio : Form
    {
        // Para pasarle el nombre del usuario al frm inicio
        private static CE_Usuario usuarioActual;

        // Para indicar si el menu esta activo y el frm
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Form_Inicio(CE_Usuario objCE_Usuario = null)
        {
            if (objCE_Usuario == null)
            {
                usuarioActual = new CE_Usuario()
                {
                    NombreCompleto = "ADMIN PREDEFINIDO",
                    IdUsuario = 1
                };
            }
            else
            {
                usuarioActual = objCE_Usuario;
            }

            InitializeComponent();
        }

        // Mostrar el nombre del usuario que inicia seccion durante la carga
        private void Form_Inicio_Load(object sender, EventArgs e)
        {
            // Identifica los permisos del usuario que inicio seccion
            List<CE_Permiso> ListaPermiso = new CN_Permiso().Listar(usuarioActual.IdUsuario);
            List<CE_Rol> ListaRol = new CN_Rol().Listar();

            // Recorre todos los menus para los permisos
            foreach (IconMenuItem iconmenu in menu.Items)
            {
                bool encontrado = ListaPermiso.Any(n => n.NombreMenu == iconmenu.Name);

                if (encontrado == false)
                {
                    iconmenu.Visible = false;
                }
            }

            lblUsuario.Text = "SISTEMA DE VENTAS - BIENVENIDO: " + usuarioActual.NombreCompleto.ToUpper() + " (" + usuarioActual.IdORol.Descripcion + ")";
            //                                                                                                //Descomentar esto para el inicio por login predeterminado
            //                                                                                                //Comentar para saltar el inicio de sesión
        }

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            // Manejar eventos MouseEnter y MouseLeave
            menu.MouseEnter += (sender, e) =>
            {
                if (menu != MenuActivo)
                {
                    menu.BackColor = Color.FromArgb(196, 43, 28);
                }
            };

            menu.MouseLeave += (sender, e) =>
            {
                if (menu != MenuActivo)
                {
                    menu.BackColor = Color.FromArgb(59, 59, 59);
                }
            };

            // Selecciona una opción y se queda de un color y si no de otro
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.FromArgb(59, 59, 59);
            }
            menu.BackColor = Color.FromArgb(39, 39, 39);
            MenuActivo = menu;

            // Indica si el formulario está activo o no, lo abre y cierra
            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;

            // Configurar el comportamiento del formulario
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Mostrar formulario dentro del panel contenedor
            pnlContenedor.Controls.Add(formulario);
            formulario.Show();
        }

        // Cuando es el menuPrincipal se escribe de esta forma el sender
        private void menuUsuario_Click(object sender, EventArgs e) => AbrirFormulario((IconMenuItem)sender, new Form_Usuario());

        private void sub_menuCategoria_Click(object sender, EventArgs e) => AbrirFormulario(menuMantenedor, new Form_Categoria());

        private void sub_menuProducto_Click(object sender, EventArgs e) => AbrirFormulario(menuMantenedor, new Form_Producto());

        private void sub_menuNegocio_Click(object sender, EventArgs e) => AbrirFormulario(menuMantenedor, new Form_Negocio());

        private void sub_menuRegistrarVenta_Click(object sender, EventArgs e) => AbrirFormulario(menuVentas, new Form_Ventas(usuarioActual));

        private void sub_menuDetalleVenta_Click(object sender, EventArgs e) => AbrirFormulario(menuVentas, new Form_DetalleVenta());

        //Despues del nombre de formulario se le puede pasar para saber que usuario a ingresado
        private void sub_menuRegistraCompra_Click(object sender, EventArgs e) => AbrirFormulario(menuCompras, new Form_Compras(usuarioActual));

        private void sub_menuDetalleCompra_Click(object sender, EventArgs e) => AbrirFormulario(menuCompras, new Form_DetalleCompra());

        private void menuClientes_Click(object sender, EventArgs e) => AbrirFormulario((IconMenuItem)sender, new Form_Clientes());

        private void menuProveedores_Click(object sender, EventArgs e) => AbrirFormulario((IconMenuItem)sender, new Form_Proveedores());

        private void sub_menuReporteCompra_Click(object sender, EventArgs e) => AbrirFormulario(menuReportes, new Form_ReporteCompras());

        private void sub_menuReporteVenta_Click(object sender, EventArgs e) => AbrirFormulario(menuReportes, new Form_ReporteVentas());

        private void menuAcerca_Click(object sender, EventArgs e)
        {
            Form_mdAcercaDe mdAcercaDe = new Form_mdAcercaDe();
            mdAcercaDe.ShowDialog();
        }

        private void btnCerrarSección_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar sesión?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
