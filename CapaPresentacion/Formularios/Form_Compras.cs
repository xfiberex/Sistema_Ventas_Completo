using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Formularios.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace CapaPresentacion.Formularios
{
    public partial class Form_Compras : Form
    {
        private CE_Usuario _Usuario;

        public Form_Compras(CE_Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void Form_Compras_Load(object sender, EventArgs e)
        {
            // Los item que van a recibir los cbb
            // Y que los cbb pueda mostrar el texto y valor
            cbbTipoDocumentoProducto.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbbTipoDocumentoProducto.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbbTipoDocumentoProducto.DisplayMember = "Texto";
            cbbTipoDocumentoProducto.ValueMember = "Valor";
            cbbTipoDocumentoProducto.SelectedIndex = 0;

            // Inicia siempre con esto
            txtFechaProducto.Text = DateTime.Now.ToString("d");
            txtIdProveedor.Text = "0";
            txtIdCodigoProducto.Text = "0";

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var modal = new Form_mdProveedor())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdProveedor.Text = modal._Proveedor.IdProveedor.ToString();
                    txtDocumentoProveedor.Text = modal._Proveedor.Documento;
                    txtRazonSocialProv.Text = modal._Proveedor.RazonSocial;
                    txtCodigoProducto.Focus();
                }
                else
                {
                    txtCodigoProducto.Focus();
                }
            }
        }

        private void btnmdBuscarProducto_Click(object sender, EventArgs e)
        {
            using (var modal = new Form_mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdCodigoProducto.Text = modal._Producto.IdProducto.ToString();
                    txtCodigoProducto.Text = modal._Producto.Codigo;
                    txtmdNombreProducto.Text = modal._Producto.Nombre;
                    txtmdDescripProducto.Text = modal._Producto.Descripcion;
                    txtPrecioCompra.Focus();
                }
                else
                {
                    txtPrecioCompra.Focus();
                }
            }
        }

        private void txtCodigoProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Realiza las acciones que deseas cuando se presiona Enter
                CE_Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtCodigoProducto.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtCodigoProducto.BackColor = Color.Honeydew;
                    txtIdCodigoProducto.Text = oProducto.IdProducto.ToString();
                    txtmdNombreProducto.Text = oProducto.Nombre;
                    txtmdDescripProducto.Text = oProducto.Descripcion;
                    txtPrecioCompra.Focus();
                }
                else
                {
                    txtCodigoProducto.BackColor = Color.MistyRose;
                    txtIdCodigoProducto.Text = "0";
                    txtmdNombreProducto.Text = "";
                    txtmdDescripProducto.Text = "";
                }

                // Evita que el evento se propague más allá del control actual
                e.Handled = true;
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            decimal precioCompra = 0;
            decimal precioVenta = 0;
            bool productoExiste = false;

            if (int.Parse(txtIdCodigoProducto.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!decimal.TryParse(txtPrecioCompra.Text, out precioCompra))
            {
                MessageBox.Show("El precio de compra no tiene el formato de moneda correcto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioCompra.Focus();
                return;
            }

            if (!decimal.TryParse(txtPrecioVenta.Text, out precioVenta))
            {
                MessageBox.Show("El precio de venta no tiene el formato de moneda correcto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioVenta.Focus();
                return;
            }

            // Para que cuando encuentre el producto no siga iterando
            foreach (DataGridViewRow fila in dgvListadoCompra.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtIdCodigoProducto.Text)
                {
                    productoExiste = true;
                    break;
                }
            }

            // Si no encuentra el producto
            if (!productoExiste)
            {
                dgvListadoCompra.Rows.Add(new object[]
                {
                     txtIdCodigoProducto.Text,
                     txtmdNombreProducto.Text,
                     txtmdDescripProducto.Text,
                     precioCompra.ToString("0,0.00"),
                     precioVenta.ToString("0,0.00"),
                     nudCantidadProducto.Value.ToString(),

                     // Multiplicar la cantidad por el precio de compra
                     (nudCantidadProducto.Value * precioCompra).ToString("0,0.00")

                });

                calcularTotal();
                limpiarProductos();
                txtCodigoProducto.Focus();
            }
            else
            {
                MessageBox.Show("El producto ya ha sido agregado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void limpiarProductos()
        {
            txtIdCodigoProducto.Text = "0";
            txtCodigoProducto.Text = "";
            txtCodigoProducto.BackColor = Color.FromArgb(239, 244, 249);
            txtmdNombreProducto.Text = "";
            txtmdDescripProducto.Text = "";
            txtPrecioCompra.Text = "0,0.00";
            txtPrecioVenta.Text = "0,0.00";
            nudCantidadProducto.Value = 1;
        }

        private void calcularTotal()
        {
            decimal total = 0;

            if (dgvListadoCompra.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvListadoCompra.Rows)
                {
                    total += Convert.ToDecimal(fila.Cells["SubTotal"].Value.ToString());
                }
            }
            txtTotalPagarProducto.Text = total.ToString("0,0.00");
        }

        private void dgvListadoCompra_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Esto es para que pinte una imagen o icono en las filas de la columna btnSeleccionar
            if (e.RowIndex < 0)
            {
                return;
            }

            // En que columna esta el boton
            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var ancho = Properties.Resources.Remove__1_.Width;
                var alto = Properties.Resources.Remove__1_.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - ancho) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - alto) / 2;

                e.Graphics.DrawImage(Properties.Resources.Remove__1_, new Rectangle(x, y, ancho, alto));
                e.Handled = true;
            }
        }

        private void dgvListadoCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoCompra.Columns[e.ColumnIndex].Name == "btnEliminarProducto")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    dgvListadoCompra.Rows.RemoveAt(indice);
                    calcularTotal();
                }
            }
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si no ingresa algo que no sea un numero no lo deja
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecioCompra.Text.Trim().Length == 0 && e.KeyChar.ToString() == "")
                {
                    e.Handled = true;
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == "")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si no ingresa algo que no sea un numero no lo deja
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecioVenta.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void btnRegistrarCompra_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtIdProveedor.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un proveedor", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvListadoCompra.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la compra", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_compra = new DataTable();

            detalle_compra.Columns.Add("IdProducto", typeof(int));
            detalle_compra.Columns.Add("PrecioCompra", typeof(decimal));
            detalle_compra.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_compra.Columns.Add("Cantidad", typeof(int));
            detalle_compra.Columns.Add("MontoTotal", typeof(decimal));

            // No se le agrega la conversion a precioCompra y Venta porque ya lo tiene arriba
            foreach (DataGridViewRow fila in dgvListadoCompra.Rows)
            {
                detalle_compra.Rows.Add(new object[]
                {
                    Convert.ToInt32(fila.Cells["IdProducto"].Value.ToString()),
                    Convert.ToDecimal(fila.Cells["PrecioCompra"].Value.ToString()),
                    Convert.ToDecimal(fila.Cells["PrecioVenta"].Value.ToString()),
                    Convert.ToInt32(fila.Cells["Cantidad"].Value.ToString()),
                    Convert.ToDecimal(fila.Cells["SubTotal"].Value.ToString())
                });
            }

            int idcorrelativo = new CN_Compra().ObtenerCorrelativo();
            // Formato en el que registraran las compras en orden
            string FormatoDocumento = string.Format("{0:00000}", idcorrelativo);

            CE_Compra oCompra = new CE_Compra()
            {
                IdOUsuario = new CE_Usuario() { IdUsuario = _Usuario.IdUsuario },
                IdOProveedor = new CE_Proveedor() { IdProveedor = Convert.ToInt32(txtIdProveedor.Text) },
                TipoDocumento = ((OpcionCombo)cbbTipoDocumentoProducto.SelectedItem).Texto,
                NumeroDocumento = FormatoDocumento,
                MontoTotal = Convert.ToDecimal(txtTotalPagarProducto.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Compra().Registrar(oCompra, detalle_compra, out mensaje);

            // Mensaje que aviso sobre el numero de compra generado
            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + FormatoDocumento + "\n\nDesea copiar?", "Estado de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                // si el usuario le da a si, se copia el numero
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(FormatoDocumento);

                    txtIdProveedor.Text = "0";
                    txtDocumentoProveedor.Text = "";
                    txtRazonSocialProv.Text = "";
                    txtIdCodigoProducto.Text = "0";
                    txtCodigoProducto.Text = "";
                    txtmdNombreProducto.Text = "";
                    txtmdDescripProducto.Text = "";
                    txtPrecioCompra.Text = "0,0.00";
                    txtPrecioVenta.Text = "0,0.00";
                    nudCantidadProducto.Text = "1";
                    dgvListadoCompra.Rows.Clear();
                    calcularTotal();
                }
                else
                {
                    MessageBox.Show("No se ha registrado la compra" + mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }
    }
}