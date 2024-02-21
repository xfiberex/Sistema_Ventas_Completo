using CapaEntidad;
using CapaNegocio;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class Form_Negocio : Form
    {
        public Form_Negocio()
        {
            InitializeComponent();
        }

        public Image ByteToImage(byte[] imageByte)
        {
            MemoryStream ms = new MemoryStream();
            ms.Write(imageByte, 0, imageByte.Length);
            Image image = new Bitmap(ms);

            return image;
        }

        private void Form_Negocio_Load(object sender, EventArgs e)
        {
            bool obtenido = true;
            byte[] byteimagen = new CN_Negocio().ObtenerLogo(out obtenido);

            if (obtenido)
            {
                picLogo.Image = ByteToImage(byteimagen);
            }

            CE_Negocio datos = new CN_Negocio().ObtenerDatos();
            txtNombreNego.Text = datos.Nombre;
            txtRUCNego.Text = datos.RNC;
            txtDireccionNego.Text = datos.Direccion;

        }

        private void btnSubirNegoImg_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Files | *.jpg; *.jpeg; *.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteImagen = File.ReadAllBytes(openFileDialog.FileName);
                bool respuesta = new CN_Negocio().ActualizarLogo(byteImagen, out mensaje);

                if (respuesta)
                {
                    picLogo.Image = ByteToImage(byteImagen);
                }
                else
                {
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnGuardarNego_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Negocio obj = new CE_Negocio()
            {
                Nombre = txtNombreNego.Text,
                RNC = txtRUCNego.Text,
                Direccion = txtDireccionNego.Text,
            };

            bool respuesta = new CN_Negocio().GuardarDatos(obj, out mensaje);

            if (respuesta)
            {
                MessageBox.Show("Los cambios fueron guardados", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se puedieron guardar los cambios", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
