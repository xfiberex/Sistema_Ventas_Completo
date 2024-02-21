using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<CE_Usuario> TEST = new CN_Usuario().Listar();

            // Llama a la capa entidad y la capa negocio para buscar los credenciales del usuario en la lista y los verifique
            CE_Usuario OUsuario = new CN_Usuario().Listar().Where(u => u.Documento == txtDocumento.Text && u.Clave == txtContraseña.Text).FirstOrDefault();

            if (OUsuario != null)
            {
                Form_Inicio inicio = new Form_Inicio(OUsuario);
                inicio.Show();
                Hide();

                // Suscribirse al evento para cerrar y volver al frm login
                inicio.FormClosing += frm_Closing;
            }
            else
            {
                MessageBox.Show("No se encontro el usuario", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Si se cierrar el formulario inicio, vuelve al formulario login
        private void frm_Closing(object sender, FormClosingEventArgs e)
        {
            txtDocumento.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            Show();
        }
    }
}
