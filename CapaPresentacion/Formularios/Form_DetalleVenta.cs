using CapaEntidad;
using CapaNegocio;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class Form_DetalleVenta : Form
    {
        public Form_DetalleVenta()
        {
            InitializeComponent();
        }

        private void Form_DetalleVenta_Load(object sender, System.EventArgs e)
        {
            txtBusquedaDocumento.Focus();
        }

        private void btnBuscarDocumento_Click(object sender, System.EventArgs e)
        {
            // Verifica si el campo de búsqueda de documento está vacío
            if (string.IsNullOrWhiteSpace(txtBusquedaDocumento.Text))
            {
                MessageBox.Show("El campo de búsqueda está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CE_Venta oVenta = new CN_Venta().ObtenerVenta(txtBusquedaDocumento.Text);

            if (oVenta.IdVenta != 0)
            {
                txtnumerodocumento.Text = oVenta.NumeroDocumento;

                txtFechaVenta.Text = oVenta.FechaRegistro;
                txtTipoDocumentoVenta.Text = oVenta.TipoDocumento;
                txtUsuarioVenta.Text = oVenta.IdOUsuario.NombreCompleto;
                txtNDocClienteVenta.Text = oVenta.DocumentoCliente;
                txtNombreCliente.Text = oVenta.NombreCliente;

                dgvListadoDetalleVenta.Rows.Clear();

                foreach (CE_DetalleVenta dv in oVenta.oDetalleVenta)
                {
                    dgvListadoDetalleVenta.Rows.Add(new object[]
                    {
                        dv.IdOProducto.Nombre,
                        dv.oDescripcion.Descripcion,
                        dv.PrecioVenta,
                        dv.Cantidad,
                        dv.SubTotal
                    });

                }

                txtMontoTotalVenta.Text = oVenta.MontoTotal.ToString("0,0.00");
                txtMontoPago.Text = oVenta.MontoPago.ToString("0,0.00");
                txtMontoCambio.Text = oVenta.MontoCambio.ToString("0,0.00");
            }
            else
            {
                MessageBox.Show("No se encuentra el numero de documento", "Estado de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnLimpiarBusquedaDocumento_Click(object sender, System.EventArgs e)
        {
            limpiarDatalleVenta();
        }

        private void txtBusquedaDocumento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                // Verifica si el campo de búsqueda de documento está vacío
                if (string.IsNullOrWhiteSpace(txtBusquedaDocumento.Text))
                {
                    MessageBox.Show("El campo de búsqueda está vacío.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Realiza las acciones que deseas cuando se presiona Enter
                string numeroDocumento = txtBusquedaDocumento.Text;
                CE_Venta oVenta = new CN_Venta().ObtenerVenta(numeroDocumento);

                if (oVenta != null && oVenta.NumeroDocumento == numeroDocumento)
                {
                    txtBusquedaDocumento.BackColor = Color.Honeydew;
                    txtFechaVenta.Text = oVenta.FechaRegistro;
                    txtTipoDocumentoVenta.Text = oVenta.TipoDocumento;
                    txtUsuarioVenta.Text = oVenta.IdOUsuario.NombreCompleto;
                    txtNDocClienteVenta.Text = oVenta.DocumentoCliente;
                    txtNombreCliente.Text = oVenta.NombreCliente;
                    txtnumerodocumento.Text = numeroDocumento.ToString();
                    dgvListadoDetalleVenta.Rows.Clear();

                    foreach (CE_DetalleVenta dv in oVenta.oDetalleVenta)
                    {
                        dgvListadoDetalleVenta.Rows.Add(new object[]
                        {
                            dv.IdOProducto.Nombre,
                            dv.oDescripcion.Descripcion,
                            dv.PrecioVenta,
                            dv.Cantidad,
                            dv.SubTotal
                        });

                    }

                    txtMontoTotalVenta.Text = oVenta.MontoTotal.ToString("0,0.00");
                    txtMontoPago.Text = oVenta.MontoPago.ToString("0,0.00");
                    txtMontoCambio.Text = oVenta.MontoCambio.ToString("0,0.00");
                    txtBusquedaDocumento.Focus();
                }
                else
                {
                    txtBusquedaDocumento.BackColor = Color.MistyRose;
                    txtFechaVenta.Text = "";
                    txtTipoDocumentoVenta.Text = "";
                    txtUsuarioVenta.Text = "";
                    txtNDocClienteVenta.Text = "";
                    txtNombreCliente.Text = "";
                    txtnumerodocumento.Text = "";
                    dgvListadoDetalleVenta.Rows.Clear();
                    txtMontoTotalVenta.Text = "0";
                    txtMontoPago.Text = "0";
                    txtMontoCambio.Text = "0";
                    txtBusquedaDocumento.Focus();
                }

                // Evita que el evento se propague más allá del control actual
                e.Handled = true;
            }
        }

        private void limpiarDatalleVenta()
        {
            txtBusquedaDocumento.Text = "";
            txtFechaVenta.Text = "";
            txtTipoDocumentoVenta.Text = "";
            txtUsuarioVenta.Text = "";
            txtNDocClienteVenta.Text = "";
            txtNombreCliente.Text = "";
            txtnumerodocumento.Text = "";
            dgvListadoDetalleVenta.Rows.Clear();
            txtMontoTotalVenta.Text = "0";
            txtMontoPago.Text = "0";
            txtMontoCambio.Text = "0";
            txtBusquedaDocumento.BackColor = Color.FromArgb(239, 244, 249);
        }

        private void btnPDFDetalleVenta_Click(object sender, System.EventArgs e)
        {
            if (txtTipoDocumentoVenta.Text == "")
            {
                MessageBox.Show("No se encontrarón resultados", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Uitliza plantilla y cambiar el texto por texto de html

            string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
            CE_Negocio oDatos = new CN_Negocio().ObtenerDatos();

            Texto_Html = Texto_Html.Replace("@nombrenegocio", oDatos.Nombre.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", oDatos.RNC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", oDatos.Direccion);

            Texto_Html = Texto_Html.Replace("@tipodocumento", txtTipoDocumentoVenta.Text.ToUpper());
            Texto_Html = Texto_Html.Replace("@numerodocumento", txtnumerodocumento.Text);

            Texto_Html = Texto_Html.Replace("@doccliente", txtNDocClienteVenta.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtNombreCliente.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtFechaVenta.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtUsuarioVenta.Text);

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvListadoDetalleVenta.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Producto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioVenta"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["SubTotal"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", txtMontoTotalVenta.Text);
            Texto_Html = Texto_Html.Replace("@pagocon", txtMontoPago.Text);
            Texto_Html = Texto_Html.Replace("@cambio", txtMontoCambio.Text);

            // Ventana que te pregunta donde quieres guardar el archivo
            // Guardarlo con un formato y que filtre solo archivos de excel
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("Venta_{0}.pdf", txtnumerodocumento.Text);
            saveFile.Filter = "PDF Files | *.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    bool obtenido = true;
                    byte[] byteImage = new CN_Negocio().ObtenerLogo(out obtenido);

                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteImage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento generado", "Estado de documento", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
