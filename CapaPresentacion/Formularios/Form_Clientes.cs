using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class Form_Clientes : Form
    {
        public Form_Clientes()
        {
            InitializeComponent();
        }

        private void Form_Clientes_Load(object sender, EventArgs e)
        {
            // Los item que van a recibir los cbb
            cbbEstadoClient.Items.Add(new OpcionCombo()
            {
                Valor = 1,
                Texto = "Activo"
            });

            cbbEstadoClient.Items.Add(new OpcionCombo()
            {
                Valor = 0,
                Texto = "No Activo"
            });

            // Esto es para que le cbb pueda mostrar el texto y valor
            cbbEstadoClient.DisplayMember = "Texto";
            cbbEstadoClient.ValueMember = "Valor";
            cbbEstadoClient.SelectedIndex = 0;

            // Para que recorre toda las columnas de dgvListadoClientes y la muestre en cbbBuscarClient
            foreach (DataGridViewColumn columna in dgvListadoClientes.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionarCliente") // que no agregue la columna del boton
                {
                    cbbBuscarClient.Items.Add(new OpcionCombo()
                    {
                        Valor = columna.Name,
                        Texto = columna.HeaderText
                    });
                }
            }
            cbbBuscarClient.DisplayMember = "Texto";
            cbbBuscarClient.ValueMember = "Valor";
            cbbBuscarClient.SelectedIndex = 0;

            // Mostrar todo los Clientes en el dgvListadoCliente
            List<CE_Cliente> listaCliente = new CN_Cliente().Listar();

            // Recorre la lista
            foreach (CE_Cliente item in listaCliente)
            {
                dgvListadoClientes.Rows.Add(new object[]
                {
                    "",
                    item.IdCliente,
                    item.Documento,
                    item.NombreCompleto,
                    item.Correo,
                    item.Telefono,
                    // En caso de que sea true que muestre un 1 o 0
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                });

            }
        }

        private void LimpiarControlesClientes()
        {
            txtIndiceClient.Text = "-1";
            txtIdCliente.Text = "0";
            txtDocumentoClient.Text = string.Empty;
            txtNombreCompletoClient.Text = string.Empty;
            txtCorreoClient.Text = string.Empty;
            txtTelefonoClient.Text = string.Empty;
            cbbEstadoClient.SelectedIndex = 0;
            // Le pone focus
            txtDocumentoClient.Focus();
        }

        private void btnGuardarClient_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Cliente objCliente = new CE_Cliente()
            {
                IdCliente = Convert.ToInt32(txtIdCliente.Text),
                Documento = txtDocumentoClient.Text,
                NombreCompleto = txtNombreCompletoClient.Text,
                Correo = txtCorreoClient.Text,
                Telefono = txtTelefonoClient.Text,
                // Si es igual a 1 sea true y si no false
                Estado = Convert.ToInt32(((OpcionCombo)cbbEstadoClient.SelectedItem).Valor) == 1 ? true : false
            };

            // Verifica si el IdCliente es 0, con esto se sabe si es para guardar o editar
            // Si el IdCliente es igual a 0, es un Cliente nuevo, y si es otro, es para editar el Cliente seleccionado
            if (objCliente.IdCliente == 0)
            {
                int idClientegenerado = new CN_Cliente().Registrar(objCliente, out mensaje);

                // Si idCliente es diferente de 0 agrega los datos
                if (idClientegenerado != 0)
                {
                    // Agrega los datos de las caja de texto y los convierte para mostrarlo en el dgvListadoCliente
                    dgvListadoClientes.Rows.Add(new object[] {"", idClientegenerado,txtDocumentoClient.Text,txtNombreCompletoClient.Text,txtCorreoClient.Text,txtTelefonoClient.Text,
                        ((OpcionCombo)cbbEstadoClient.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cbbEstadoClient.SelectedItem).Texto.ToString()
                    });

                    // Despues de almacenar los datos que limpie
                    LimpiarControlesClientes();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si el IdCliente no es 0, utliza Editar
                bool resultado = new CN_Cliente().Editar(objCliente, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvListadoClientes.Rows[Convert.ToInt32(txtIndiceClient.Text)];
                    row.Cells["IdCliente"].Value = txtIdCliente.Text;
                    row.Cells["Documento"].Value = txtDocumentoClient.Text;
                    row.Cells["NombreCompleto"].Value = txtNombreCompletoClient.Text;
                    row.Cells["Correo"].Value = txtCorreoClient.Text;
                    row.Cells["Telefono"].Value = txtTelefonoClient.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cbbEstadoClient.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbbEstadoClient.SelectedItem).Texto.ToString();
                    LimpiarControlesClientes();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiarDatosClient_Click(object sender, EventArgs e)
        {
            LimpiarControlesClientes();
        }

        private void btnEliminarClient_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdCliente.Text) != 0)
            {
                // Ventana que confirma la accion de si o no para eliminar
                if (MessageBox.Show("Desea eliminar a este Cliente?\n\n" +
                                    "Nro.Documento: " + txtDocumentoClient.Text + "\n" +
                                    "Nombre: " + txtNombreCompletoClient.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    CE_Cliente objCliente = new CE_Cliente()
                    {
                        IdCliente = Convert.ToInt32(txtIdCliente.Text),
                    };

                    bool respuesta = new CN_Cliente().Eliminar(objCliente, out mensaje);

                    if (respuesta)
                    {
                        dgvListadoClientes.Rows.RemoveAt(Convert.ToInt32(txtIndiceClient.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Estado de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnBuscarClient_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBuscarClient.SelectedItem).Valor.ToString();

            if (dgvListadoClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListadoClientes.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusquedaClient.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnLimpiarBusquedaClient_Click(object sender, EventArgs e)
        {
            txtBusquedaClient.Text = "";

            foreach (DataGridViewRow row in dgvListadoClientes.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvListadoClientesClient_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Esto es para que pinte una imagen o icono en las filas de la columna btnSeleccionar
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var ancho = Properties.Resources.ApuntaD.Width;
                var alto = Properties.Resources.ApuntaD.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - ancho) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - alto) / 2;

                e.Graphics.DrawImage(Properties.Resources.ApuntaD, new Rectangle(x, y, ancho, alto));
                e.Handled = true;
            }
        }

        private void dgvListadoClientesClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoClientes.Columns[e.ColumnIndex].Name == "btnSeleccionarCliente")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndiceClient.Text = indice.ToString();
                    txtIdCliente.Text = dgvListadoClientes.Rows[indice].Cells["IdCliente"].Value.ToString();
                    txtDocumentoClient.Text = dgvListadoClientes.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombreCompletoClient.Text = dgvListadoClientes.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreoClient.Text = dgvListadoClientes.Rows[indice].Cells["Correo"].Value.ToString();
                    txtTelefonoClient.Text = dgvListadoClientes.Rows[indice].Cells["Telefono"].Value.ToString();

                    // Para que capture el estado desde el dgvListadoClientes y lo muestre en txtEstado
                    foreach (OpcionCombo oc in cbbEstadoClient.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvListadoClientes.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indiceCombo = cbbEstadoClient.Items.IndexOf(oc);
                            cbbEstadoClient.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                }
            }
        }
    }
}
