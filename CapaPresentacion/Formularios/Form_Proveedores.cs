using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class Form_Proveedores : Form
    {
        public Form_Proveedores()
        {
            InitializeComponent();
        }

        private void Form_Proveedores_Load(object sender, EventArgs e)
        {
            // Los item que van a recibir los cbb
            cbbEstadoProv.Items.Add(new OpcionCombo()
            {
                Valor = 1,
                Texto = "Activo"
            });

            cbbEstadoProv.Items.Add(new OpcionCombo()
            {
                Valor = 0,
                Texto = "No Activo"
            });

            // Esto es para que le cbb pueda mostrar el texto y valor
            cbbEstadoProv.DisplayMember = "Texto";
            cbbEstadoProv.ValueMember = "Valor";
            cbbEstadoProv.SelectedIndex = 0;

            // Para que recorre toda las columnas de dgvListadoProveedor y la muestre en cbbBuscar
            foreach (DataGridViewColumn columna in dgvListadoProveedores.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionarProveedor") // que no agregue la columna del boton
                {
                    cbbBuscarProv.Items.Add(new OpcionCombo()
                    {
                        Valor = columna.Name,
                        Texto = columna.HeaderText
                    });
                }
            }
            cbbBuscarProv.DisplayMember = "Texto";
            cbbBuscarProv.ValueMember = "Valor";
            cbbBuscarProv.SelectedIndex = 0;

            // Mostrar todo los Proveedors en el dgvListadoProveedor
            List<CE_Proveedor> listaProveedor = new CN_Proveedor().Listar();

            // Recorre la lista
            foreach (CE_Proveedor item in listaProveedor)
            {
                dgvListadoProveedores.Rows.Add(new object[]
                {
                    "",
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial,
                    item.Correo,
                    item.Telefono,
                    // En caso de que sea true que muestre un 1 o 0
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                });

            }
        }

        private void LimpiarControlesProveedores()
        {
            txtIndiceProv.Text = "-1";
            txtIdProveedor.Text = "0";
            txtDocumentoProv.Text = string.Empty;
            txtRazonSocialProv.Text = string.Empty;
            txtCorreoProv.Text = string.Empty;
            txtTelefonoProv.Text = string.Empty;
            cbbEstadoProv.SelectedIndex = 0;
            // Le pone focus
            txtDocumentoProv.Focus();
        }

        private void btnGuardarProv_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Proveedor objProveedor = new CE_Proveedor()
            {
                IdProveedor = Convert.ToInt32(txtIdProveedor.Text),
                Documento = txtDocumentoProv.Text,
                RazonSocial = txtRazonSocialProv.Text,
                Correo = txtCorreoProv.Text,
                Telefono = txtTelefonoProv.Text,
                // Si es igual a 1 sea true y si no false
                Estado = Convert.ToInt32(((OpcionCombo)cbbEstadoProv.SelectedItem).Valor) == 1 ? true : false
            };

            // Verifica si el IdProveedor es 0, con esto se sabe si es para guardar o editar
            // Si el IdProveedor es igual a 0, es un Proveedor nuevo, y si es otro, es para editar el Proveedor seleccionado
            if (objProveedor.IdProveedor == 0)
            {
                int idProveedorgenerado = new CN_Proveedor().Registrar(objProveedor, out mensaje);

                // Si idProveedor es diferente de 0 agrega los datos
                if (idProveedorgenerado != 0)
                {
                    // Agrega los datos de las caja de texto y los convierte para mostrarlo en el dgvListadoProveedor
                    dgvListadoProveedores.Rows.Add(new object[] {"", idProveedorgenerado,txtDocumentoProv.Text,txtRazonSocialProv.Text,txtCorreoProv.Text,txtTelefonoProv.Text,
                        ((OpcionCombo)cbbEstadoProv.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cbbEstadoProv.SelectedItem).Texto.ToString()
                    });

                    // Despues de almacenar los datos que limpie
                    LimpiarControlesProveedores();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si el IdProveedor no es 0, utliza Editar
                bool resultado = new CN_Proveedor().Editar(objProveedor, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvListadoProveedores.Rows[Convert.ToInt32(txtIndiceProv.Text)];
                    row.Cells["IdProveedor"].Value = txtIdProveedor.Text;
                    row.Cells["Documento"].Value = txtDocumentoProv.Text;
                    row.Cells["RazonSocial"].Value = txtRazonSocialProv.Text;
                    row.Cells["Correo"].Value = txtCorreoProv.Text;
                    row.Cells["Telefono"].Value = txtTelefonoProv.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cbbEstadoProv.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbbEstadoProv.SelectedItem).Texto.ToString();
                    LimpiarControlesProveedores();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiarDatosProv_Click(object sender, EventArgs e)
        {
            LimpiarControlesProveedores();
        }

        private void btnEliminarProv_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdProveedor.Text) != 0)
            {
                // Ventana que confirma la accion de si o no para eliminar
                if (MessageBox.Show("Desea eliminar a este Proveedor?\n\n" +
                                    "Razón Social: " + txtRazonSocialProv.Text + "\n" +
                                    "Nro.Documento: " + txtDocumentoProv.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    CE_Proveedor objProveedor = new CE_Proveedor()
                    {
                        IdProveedor = Convert.ToInt32(txtIdProveedor.Text),
                    };

                    bool respuesta = new CN_Proveedor().Eliminar(objProveedor, out mensaje);

                    if (respuesta)
                    {
                        dgvListadoProveedores.Rows.RemoveAt(Convert.ToInt32(txtIndiceProv.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Estado de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnBuscarProv_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBuscarProv.SelectedItem).Valor.ToString();

            if (dgvListadoProveedores.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListadoProveedores.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusquedaProv.Text.Trim().ToUpper()))
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

        private void btnLimpiarBusquedaProv_Click(object sender, EventArgs e)
        {
            txtBusquedaProv.Text = "";

            foreach (DataGridViewRow row in dgvListadoProveedores.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvListadoProveedorsProv_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvListadoProveedorsProv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoProveedores.Columns[e.ColumnIndex].Name == "btnSeleccionarProveedor")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndiceProv.Text = indice.ToString();
                    txtIdProveedor.Text = dgvListadoProveedores.Rows[indice].Cells["IdProveedor"].Value.ToString();
                    txtDocumentoProv.Text = dgvListadoProveedores.Rows[indice].Cells["Documento"].Value.ToString();
                    txtRazonSocialProv.Text = dgvListadoProveedores.Rows[indice].Cells["RazonSocial"].Value.ToString();
                    txtCorreoProv.Text = dgvListadoProveedores.Rows[indice].Cells["Correo"].Value.ToString();
                    txtTelefonoProv.Text = dgvListadoProveedores.Rows[indice].Cells["Telefono"].Value.ToString();

                    // Para que capture el estado desde el dgvListadoProveedors y lo muestre en txtEstado
                    foreach (OpcionCombo oc in cbbEstadoProv.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvListadoProveedores.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indiceCombo = cbbEstadoProv.Items.IndexOf(oc);
                            cbbEstadoProv.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                }
            }
        }
    }
}
