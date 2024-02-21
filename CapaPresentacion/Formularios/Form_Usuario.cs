using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class Form_Usuario : Form
    {
        public Form_Usuario()
        {
            InitializeComponent();
        }

        private void Form_Usuario_Load(object sender, EventArgs e)
        {
            // Los item que van a recibir los cbb
            cbbEstado.Items.Add(new OpcionCombo()
            {
                Valor = 1,
                Texto = "Activo"
            });

            cbbEstado.Items.Add(new OpcionCombo()
            {
                Valor = 0,
                Texto = "No Activo"
            });

            // Esto es para que le cbb pueda mostrar el texto y valor
            cbbEstado.DisplayMember = "Texto";
            cbbEstado.ValueMember = "Valor";
            cbbEstado.SelectedIndex = 0;

            // Obtener la lista de los roles
            List<CE_Rol> listaRol = new CN_Rol().Listar();

            // Recorre la lista
            foreach (CE_Rol item in listaRol)
            {
                cbbRol.Items.Add(new OpcionCombo()
                {
                    // Los muestra de esta forma con item
                    Valor = item.IdRol,
                    Texto = item.Descripcion
                });
            }

            // Mostra esto predeterminado
            cbbRol.DisplayMember = "Texto";
            cbbRol.ValueMember = "Valor";
            cbbRol.SelectedIndex = 0;

            // Para que recorre toda las columnas de dgvListadoUsuario y la muestre en cbbBuscar
            foreach (DataGridViewColumn columna in dgvListadoUsuarios.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionar") // que no agregue la columna del boton
                {
                    cbbBuscar.Items.Add(new OpcionCombo()
                    {
                        Valor = columna.Name,
                        Texto = columna.HeaderText
                    });
                }
            }
            cbbBuscar.DisplayMember = "Texto";
            cbbBuscar.ValueMember = "Valor";
            cbbBuscar.SelectedIndex = 0;

            // Mostrar todo los usuarios en el dgvListadoUsuario
            List<CE_Usuario> listaUsuario = new CN_Usuario().Listar();

            // Recorre la lista
            foreach (CE_Usuario item in listaUsuario)
            {
                dgvListadoUsuarios.Rows.Add(new object[] {"", item.IdUsuario, item.Documento, item.NombreCompleto, item.Correo, item.Clave,
                    item.IdORol.IdRol,
                    item.IdORol.Descripcion,
                    // En caso de que sea true que muestre un 1 o 0
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                });

            }
        }

        private void LimpiarControles()
        {
            txtIndice.Text = "-1";
            txtIdUsuario.Text = "0";
            txtDocumento.Text = string.Empty;
            txtNombreCompleto.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtConfirmarClave.Text = string.Empty;
            cbbRol.SelectedIndex = 0;
            cbbEstado.SelectedIndex = 0;
            // Le pone focus
            txtDocumento.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Usuario objusuario = new CE_Usuario()
            {
                IdUsuario = Convert.ToInt32(txtIdUsuario.Text),
                Documento = txtDocumento.Text,
                NombreCompleto = txtNombreCompleto.Text,
                Correo = txtCorreo.Text,
                Clave = txtClave.Text,
                ConfirmarClave = txtConfirmarClave.Text,
                IdORol = new CE_Rol() { IdRol = Convert.ToInt32(((OpcionCombo)cbbRol.SelectedItem).Valor) },
                // Si es igual a 1 sea true y si no false
                Estado = Convert.ToInt32(((OpcionCombo)cbbEstado.SelectedItem).Valor) == 1 ? true : false
            };

            // Verifica si el IdUsuario es 0, con esto se sabe si es para guardar o editar
            // Si el IdUsuario es igual a 0, es un usuario nuevo, y si es otro, es para editar el usuario seleccionado
            if (objusuario.IdUsuario == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                // Si idusuario es diferente de 0 agrega los datos
                if (idusuariogenerado != 0)
                {
                    // Agrega los datos de las caja de texto y los convierte para mostrarlo en el dgvListadoUsuario
                    dgvListadoUsuarios.Rows.Add(new object[] {"", idusuariogenerado,txtDocumento.Text,txtNombreCompleto.Text,txtCorreo.Text,txtClave.Text,
                        ((OpcionCombo)cbbRol.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cbbRol.SelectedItem).Texto.ToString(),
                        ((OpcionCombo)cbbEstado.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cbbEstado.SelectedItem).Texto.ToString()
                    });

                    // Despues de almacenar los datos que limpie
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show("Se necesitan los siguientes datos para el usuario:\n\n" + mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                // Si el IdUsuario no es 0, utliza Editar
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvListadoUsuarios.Rows[Convert.ToInt32(txtIndice.Text)];
                    row.Cells["IdUsuario"].Value = txtIdUsuario.Text;
                    row.Cells["Documento"].Value = txtDocumento.Text;
                    row.Cells["NombreCompleto"].Value = txtNombreCompleto.Text;
                    row.Cells["Correo"].Value = txtCorreo.Text;
                    row.Cells["Clave"].Value = txtClave.Text;
                    row.Cells["IdRol"].Value = ((OpcionCombo)cbbRol.SelectedItem).Valor.ToString();
                    row.Cells["Rol"].Value = ((OpcionCombo)cbbRol.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cbbEstado.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbbEstado.SelectedItem).Texto.ToString();
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdUsuario.Text) != 0)
            {
                // Ventana que confirma la accion de si o no para eliminar
                if (MessageBox.Show("Desea eliminar a este " + cbbRol.Text + "?\n\n" +
                                    "Nombre: " + txtNombreCompleto.Text + "\n" +
                                    "Nro.Documento: " + txtDocumento.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    CE_Usuario objusuario = new CE_Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtIdUsuario.Text),
                    };

                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        dgvListadoUsuarios.Rows.RemoveAt(Convert.ToInt32(txtIndice.Text));
                        LimpiarControles();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Estado de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBuscar.SelectedItem).Valor.ToString();

            if (dgvListadoUsuarios.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListadoUsuarios.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusqueda.Text.Trim().ToUpper()))
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

        private void btnLimpiarBusqueda_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = "";

            foreach (DataGridViewRow row in dgvListadoUsuarios.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvListadoUsuarios_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvListadoUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoUsuarios.Columns[e.ColumnIndex].Name == "btnSeleccionar")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndice.Text = indice.ToString();
                    txtIdUsuario.Text = dgvListadoUsuarios.Rows[indice].Cells["IdUsuario"].Value.ToString();
                    txtDocumento.Text = dgvListadoUsuarios.Rows[indice].Cells["Documento"].Value.ToString();
                    txtNombreCompleto.Text = dgvListadoUsuarios.Rows[indice].Cells["NombreCompleto"].Value.ToString();
                    txtCorreo.Text = dgvListadoUsuarios.Rows[indice].Cells["Correo"].Value.ToString();
                    txtClave.Text = dgvListadoUsuarios.Rows[indice].Cells["Clave"].Value.ToString();
                    txtConfirmarClave.Text = dgvListadoUsuarios.Rows[indice].Cells["Clave"].Value.ToString();

                    // Para que capture el rol desde el dgvListadoUsuarios y lo muestre en txtRol
                    foreach (OpcionCombo oc in cbbRol.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvListadoUsuarios.Rows[indice].Cells["IdRol"].Value))
                        {
                            int indiceCombo = cbbRol.Items.IndexOf(oc);
                            cbbRol.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                    // Para que capture el estado desde el dgvListadoUsuarios y lo muestre en txtEstado
                    foreach (OpcionCombo oc in cbbEstado.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvListadoUsuarios.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indiceCombo = cbbEstado.Items.IndexOf(oc);
                            cbbEstado.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                }
            }
        }
    }
}