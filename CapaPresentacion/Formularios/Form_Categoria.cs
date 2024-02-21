using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class Form_Categoria : Form
    {
        public Form_Categoria()
        {
            InitializeComponent();
        }

        private void Form_Categoria_Load(object sender, EventArgs e)
        {
            cbbEstadoCateg.Items.Add(new OpcionCombo()
            {
                Valor = 1,
                Texto = "Activo"
            });

            cbbEstadoCateg.Items.Add(new OpcionCombo()
            {
                Valor = 0,
                Texto = "No Activo"
            });

            cbbEstadoCateg.DisplayMember = "Texto";
            cbbEstadoCateg.ValueMember = "Valor";
            cbbEstadoCateg.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvListadoCategorias.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionarCategoria")
                {
                    cbbBuscarCateg.Items.Add(new OpcionCombo()
                    {
                        Valor = columna.Name,
                        Texto = columna.HeaderText
                    });
                }
            }
            cbbBuscarCateg.DisplayMember = "Texto";
            cbbBuscarCateg.ValueMember = "Valor";
            cbbBuscarCateg.SelectedIndex = 0;

            List<CE_Categoria> listaCategoria = new CN_Categoria().Listar();

            foreach (CE_Categoria item in listaCategoria)
            {
                dgvListadoCategorias.Rows.Add(new object[] {"", item.IdCategoria,
                    item.Descripcion,
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"

                });

            }
        }

        private void LimpiarControlesCateg()
        {
            txtIndiceCateg.Text = "-1";
            txtIdCategoria.Text = "0";
            txtDescripcionCateg.Text = string.Empty;
            cbbEstadoCateg.SelectedIndex = 0;
            // Le pone focus
            txtDescripcionCateg.Focus();
        }

        private void btnGuardarCateg_Click(object sender, System.EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Categoria objCategoria = new CE_Categoria()
            {
                IdCategoria = Convert.ToInt32(txtIdCategoria.Text),
                Descripcion = txtDescripcionCateg.Text,
                // Si es igual a 1 sea true y si no false
                Estado = Convert.ToInt32(((OpcionCombo)cbbEstadoCateg.SelectedItem).Valor) == 1 ? true : false
            };

            // Verifica si el IdCategoria es 0, con esto se sabe si es para guardar o editar
            // Si el IdCategoria es igual a 0, es un Categoria nuevo, y si es otro, es para editar el Categoria seleccionado
            if (objCategoria.IdCategoria == 0)
            {
                int idCategoriagenerado = new CN_Categoria().Registrar(objCategoria, out mensaje);

                // Si idCategoria es diferente de 0 agrega los datos
                if (idCategoriagenerado != 0)
                {
                    // Agrega los datos de las caja de texto y los convierte para mostrarlo en el dgvListadoCategoria
                    dgvListadoCategorias.Rows.Add(new object[]
                    {
                        "",
                        idCategoriagenerado,
                        txtDescripcionCateg.Text,
                        ((OpcionCombo)cbbEstadoCateg.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cbbEstadoCateg.SelectedItem).Texto.ToString()
                    });

                    // Despues de almacenar los datos que limpie
                    LimpiarControlesCateg();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si el IdCategoria no es 0, utliza Editar
                bool resultado = new CN_Categoria().Editar(objCategoria, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvListadoCategorias.Rows[Convert.ToInt32(txtIndiceCateg.Text)];
                    row.Cells["IdCategoria"].Value = txtIdCategoria.Text;
                    row.Cells["Descripcion"].Value = txtDescripcionCateg.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cbbEstadoCateg.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbbEstadoCateg.SelectedItem).Texto.ToString();
                    LimpiarControlesCateg();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiarDatosCateg_Click(object sender, EventArgs e)
        {
            LimpiarControlesCateg();
        }

        private void btnEliminarCateg_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdCategoria.Text) != 0)
            {
                // Ventana que confirma la accion de si o no para eliminar
                if (MessageBox.Show("Desea eliminar esta categoria?\n\n" +
                                    "Descripción: " + txtDescripcionCateg.Text + "\n" +
                                    "Con estado: " + cbbEstadoCateg.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    CE_Usuario objusuario = new CE_Usuario()
                    {
                        IdUsuario = Convert.ToInt32(txtIdCategoria.Text),
                    };

                    bool respuesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (respuesta)
                    {
                        dgvListadoCategorias.Rows.RemoveAt(Convert.ToInt32(txtIndiceCateg.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Estado de eliminación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void btnBuscarCateg_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBuscarCateg.SelectedItem).Valor.ToString();

            if (dgvListadoCategorias.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListadoCategorias.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusquedaCateg.Text.Trim().ToUpper()))
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

        private void btnLimpiarBusquedaCateg_Click(object sender, EventArgs e)
        {
            txtBusquedaCateg.Text = "";

            foreach (DataGridViewRow row in dgvListadoCategorias.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvListadoCategorias_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvListadoCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoCategorias.Columns[e.ColumnIndex].Name == "btnSeleccionarCategoria")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndiceCateg.Text = indice.ToString();
                    txtIdCategoria.Text = dgvListadoCategorias.Rows[indice].Cells["IdCategoria"].Value.ToString();
                    txtDescripcionCateg.Text = dgvListadoCategorias.Rows[indice].Cells["Descripcion"].Value.ToString();
                    cbbEstadoCateg.Text = dgvListadoCategorias.Rows[indice].Cells["Estado"].Value.ToString();

                    // Para que capture el estado desde el dgvListadoUsuarios y lo muestre en txtEstado
                    foreach (OpcionCombo oc in cbbEstadoCateg.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvListadoCategorias.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indiceCombo = cbbEstadoCateg.Items.IndexOf(oc);
                            cbbEstadoCateg.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                }
            }
        }
    }
}
