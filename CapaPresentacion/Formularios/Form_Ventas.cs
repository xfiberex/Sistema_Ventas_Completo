using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Formularios.Modales;
using CapaPresentacion.Utilidades;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class Form_Ventas : Form
    {
        // Esta variable captura el usuario que a inicio sección
        private CE_Usuario _Usuario;

        public Form_Ventas(CE_Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }

        private void Form_Ventas_Load(object sender, System.EventArgs e)
        {
            // Los item que van a recibir los cbb
            // Y que los cbb pueda mostrar el texto y valor
            cbbTipoDocumentoCliente.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            cbbTipoDocumentoCliente.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            cbbTipoDocumentoCliente.DisplayMember = "Texto";
            cbbTipoDocumentoCliente.ValueMember = "Valor";
            cbbTipoDocumentoCliente.SelectedIndex = 0;

            // Inicia siempre con esto
            txtFechaCliente.Text = DateTime.Now.ToString("d");
            txtIdProductoCliente.Text = "0";
            txtPagaCon.Text = "0";
            txtCambio.Text = "0";
            txtTPProductoCliente.Text = "0";
            txtPrecioCliente.Text = "0,0.00";
            txtStockCliente.Text = "1";
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new Form_mdCliente())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtDocumentoCliente.Text = modal._Cliente.Documento.ToString();
                    txtNombreCliente.Text = modal._Cliente.NombreCompleto;
                    txtCodProdCliente.Focus();
                }
                else
                {
                    txtCodProdCliente.Focus();
                }
            }
        }

        private void btnBuscarProductoCliente_Click(object sender, EventArgs e)
        {
            using (var modal = new Form_mdProducto())
            {
                var result = modal.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txtIdProductoCliente.Text = modal._Producto.IdProducto.ToString();
                    txtCodProdCliente.Text = modal._Producto.Codigo;
                    txtNombreProductoCliente.Text = modal._Producto.Nombre;
                    txtDescripProductoCliente.Text = modal._Producto.Descripcion;
                    txtPrecioCliente.Text = modal._Producto.PrecioVenta.ToString("0,0.00");
                    txtStockCliente.Text = modal._Producto.Stock.ToString();
                    nudCantidadProductoCliente.Focus();
                }
                else
                {
                    nudCantidadProductoCliente.Focus();
                }
            }
        }

        private void txtCodProdCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Realiza las acciones que deseas cuando se presiona Enter
                CE_Producto oProducto = new CN_Producto().Listar().Where(p => p.Codigo == txtCodProdCliente.Text && p.Estado == true).FirstOrDefault();

                if (oProducto != null)
                {
                    txtCodProdCliente.BackColor = Color.Honeydew;
                    txtIdProductoCliente.Text = oProducto.IdProducto.ToString();
                    txtNombreProductoCliente.Text = oProducto.Nombre;
                    txtDescripProductoCliente.Text = oProducto.Descripcion;
                    txtPrecioCliente.Text = oProducto.PrecioVenta.ToString("0,0.00");
                    txtStockCliente.Text = oProducto.Stock.ToString();
                    nudCantidadProductoCliente.Focus();
                }
                else
                {
                    txtCodProdCliente.BackColor = Color.MistyRose;
                    txtIdProductoCliente.Text = "0";
                    txtNombreProductoCliente.Text = "";
                    txtDescripProductoCliente.Text = "";
                    txtPrecioCliente.Text = "0";
                    txtStockCliente.Text = "0";
                    nudCantidadProductoCliente.Value = 1;
                }

                // Evita que el evento se propague más allá del control actual
                e.Handled = true;
            }
        }

        private void btnAgregarProdCliente_Click(object sender, EventArgs e)
        {
            decimal precioVenta = 0;
            bool productoExiste = false;

            if (int.Parse(txtIdProductoCliente.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            if (!decimal.TryParse(txtPrecioCliente.Text, out precioVenta))
            {
                MessageBox.Show("El precio no tiene el formato de moneda correcto", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrecioCliente.Focus();
                return;
            }

            if (Convert.ToInt32(txtStockCliente.Text) < Convert.ToInt32(nudCantidadProductoCliente.Value.ToString()))
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtStockCliente.Focus();
                return;
            }

            // Para que cuando encuentre el producto no siga iterando
            foreach (DataGridViewRow fila in dgvListadoVenta.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtIdProductoCliente.Text)
                {
                    productoExiste = true;
                    break;
                }
            }

            // Si no encuentra el producto
            if (!productoExiste)
            {
                bool respuesta = new CN_Venta().RestarStock(
                    Convert.ToInt32(txtIdProductoCliente.Text),
                    Convert.ToInt32(nudCantidadProductoCliente.Value.ToString())
                );

                if (respuesta)
                {
                    dgvListadoVenta.Rows.Add(new object[]
                    {
                         txtIdProductoCliente.Text,
                         txtNombreProductoCliente.Text,
                         txtDescripProductoCliente.Text,
                         precioVenta.ToString("0,0.00"),
                         nudCantidadProductoCliente.Value.ToString(),

                         // Multiplicar la cantidad por el precio de compra
                         (nudCantidadProductoCliente.Value * precioVenta).ToString("0,0.00")

                    });

                    calcularTotal();
                    limpiarProductos();
                    txtCodProdCliente.Focus();
                }
            }
            else
            {
                MessageBox.Show("El producto ya ha sido agregado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void calcularTotal()
        {
            decimal total = 0;

            if (dgvListadoVenta.Rows.Count > 0)
            {
                foreach (DataGridViewRow fila in dgvListadoVenta.Rows)
                {
                    total += Convert.ToDecimal(fila.Cells["SubTotal"].Value.ToString());
                }
            }
            txtTPProductoCliente.Text = total.ToString("0");
        }

        private void limpiarProductos()
        {
            txtIdProductoCliente.Text = "0";
            txtCodProdCliente.Text = "";
            txtCodProdCliente.BackColor = Color.FromArgb(239, 244, 249);
            txtNombreProductoCliente.Text = "";
            txtDescripProductoCliente.Text = "";
            txtPrecioCliente.Text = "0,0.00";
            txtStockCliente.Text = "0";
            nudCantidadProductoCliente.Value = 1;
        }

        private void dgvListadoVenta_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Esto es para que pinte una imagen o icono en las filas de la columna btnSeleccionar
            if (e.RowIndex < 0)
            {
                return;
            }

            // En que columna esta el boton, empezando desde 0
            if (e.ColumnIndex == 6)
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

        private void dgvListadoVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoVenta.Columns[e.ColumnIndex].Name == "btnEliminarProducto")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    bool respuesta = new CN_Venta().SumarStock(
                        Convert.ToInt32(dgvListadoVenta.Rows[indice].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(dgvListadoVenta.Rows[indice].Cells["Cantidad"].Value.ToString())
                    );

                    if (respuesta)
                    {
                        dgvListadoVenta.Rows.RemoveAt(indice);
                        txtIdProductoCliente.Text = "0";
                        txtCodProdCliente.Text = "";
                        txtNombreProductoCliente.Text = "";
                        txtDescripProductoCliente.Text = "";
                        txtPrecioCliente.Text = "0,0.00";
                        txtStockCliente.Text = "0";
                        calcularTotal();
                    }
                }
            }
        }

        private void txtPrecioCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si no ingresa algo que no sea un numero no lo deja
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPrecioCliente.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtPagaCon_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Si no ingresa algo que no sea un numero no lo deja
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtPagaCon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void CalcularCambio()
        {
            if (txtTPProductoCliente.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txtTPProductoCliente.Text);

            if (txtPagaCon.Text.Trim() == "")
            {
                txtPagaCon.Text = "0,0.00";
            }
            // Guardar en esta variable
            if (decimal.TryParse(txtPagaCon.Text.Trim(), out pagacon))
            {
                if (pagacon < total)
                {
                    txtCambio.Text = "0,0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtCambio.Text = cambio.ToString("0,0.00");
                }
            }
        }

        private void txtPagaCon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                CalcularCambio();
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            if (txtDocumentoCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar el documento del cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtNombreCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar el nombre del cliente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgvListadoVenta.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos para la venta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DataTable detalle_venta = new DataTable();

            detalle_venta.Columns.Add("IdProducto", typeof(int));
            detalle_venta.Columns.Add("PrecioVenta", typeof(decimal));
            detalle_venta.Columns.Add("Cantidad", typeof(int));
            detalle_venta.Columns.Add("SubTotal", typeof(decimal));

            // No se le agrega la conversion a precioCompra y Venta porque ya lo tiene arriba
            foreach (DataGridViewRow fila in dgvListadoVenta.Rows)
            {
                detalle_venta.Rows.Add(new object[]
                {
                    Convert.ToInt32(fila.Cells["IdProducto"].Value.ToString()),
                    Convert.ToDecimal(fila.Cells["PrecioVenta"].Value.ToString()),
                    Convert.ToInt32(fila.Cells["Cantidad"].Value.ToString()),
                    Convert.ToDecimal(fila.Cells["SubTotal"].Value.ToString())
                });
            }

            int idcorrelativo = new CN_Venta().ObtenerCorrelativo();
            // Formato en el que registraran las compras en orden
            string FormatoDocumento = string.Format("{0:00000}", idcorrelativo);
            CalcularCambio();

            CE_Venta oVenta = new CE_Venta()
            {
                IdOUsuario = new CE_Usuario() { IdUsuario = _Usuario.IdUsuario },
                TipoDocumento = ((OpcionCombo)cbbTipoDocumentoCliente.SelectedItem).Texto,
                NumeroDocumento = FormatoDocumento,
                DocumentoCliente = txtDocumentoCliente.Text,
                NombreCliente = txtNombreCliente.Text,
                MontoPago = Convert.ToDecimal(txtPagaCon.Text),
                MontoCambio = Convert.ToDecimal(txtCambio.Text),
                MontoTotal = Convert.ToDecimal(txtTPProductoCliente.Text)
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Venta().Registrar(oVenta, detalle_venta, out mensaje);

            // Mensaje que aviso sobre el numero de compra generado
            if (respuesta)
            {
                var result = MessageBox.Show("Numero de compra generada:\n" + FormatoDocumento + "\n\nDesea copiar?", "Estado de registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                // si el usuario le da a si, se copia el numero
                if (result == DialogResult.Yes)
                {
                    Clipboard.SetText(FormatoDocumento);

                    txtDocumentoCliente.Text = "";
                    txtNombreCliente.Text = "";
                    dgvListadoVenta.Rows.Clear();
                    calcularTotal();
                    txtPagaCon.Text = "";
                    txtCambio.Text = "";
                }
                else
                {
                    MessageBox.Show("No se ha registrado la compra" + mensaje, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    }
}
