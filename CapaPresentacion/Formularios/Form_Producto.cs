using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Rectangle = System.Drawing.Rectangle;

namespace CapaPresentacion.Formularios
{
    public partial class Form_Producto : Form
    {
        public Form_Producto()
        {
            InitializeComponent();
        }

        private void Form_Producto_Load(object sender, EventArgs e)
        {
            // Los item que van a recibir los cbb
            cbbEstadoProd.Items.Add(new OpcionCombo()
            {
                Valor = 1,
                Texto = "Activo"
            });

            cbbEstadoProd.Items.Add(new OpcionCombo()
            {
                Valor = 0,
                Texto = "No Activo"
            });

            // Esto es para que le cbb pueda mostrar el texto y valor
            cbbEstadoProd.DisplayMember = "Texto";
            cbbEstadoProd.ValueMember = "Valor";
            cbbEstadoProd.SelectedIndex = 0;

            // Obtener la lista de las categorias
            List<CE_Categoria> listaCategoria = new CN_Categoria().Listar();

            // Recorre la lista
            foreach (CE_Categoria item in listaCategoria)
            {
                cbbCategoriaProd.Items.Add(new OpcionCombo()
                {
                    // Los muestra de esta forma con item
                    Valor = item.IdCategoria,
                    Texto = item.Descripcion
                });
            }

            // Mostra esto predeterminado
            cbbCategoriaProd.DisplayMember = "Texto";
            cbbCategoriaProd.ValueMember = "Valor";
            cbbCategoriaProd.SelectedIndex = 0;

            // Para que recorre toda las columnas de dgvListadoProducto y la muestre en cbbBuscar
            foreach (DataGridViewColumn columna in dgvListadoProductos.Columns)
            {
                if (columna.Visible == true && columna.Name != "btnSeleccionarProducto") // que no agregue la columna del boton
                {
                    cbbBuscarProd.Items.Add(new OpcionCombo()
                    {
                        Valor = columna.Name,
                        Texto = columna.HeaderText
                    });
                }
            }
            cbbBuscarProd.DisplayMember = "Texto";
            cbbBuscarProd.ValueMember = "Valor";
            cbbBuscarProd.SelectedIndex = 0;

            // Mostrar todo los Producto en el dgvListadoProducto
            List<CE_Producto> listaProducto = new CN_Producto().Listar();

            // Recorre la lista
            foreach (CE_Producto item in listaProducto)
            {
                dgvListadoProductos.Rows.Add(new object[] {"", item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.IdOCategoria.IdCategoria,
                    item.IdOCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta,
                    // En caso de que sea true que muestre un 1 o 0
                    item.Estado == true ? 1 : 0,
                    item.Estado == true ? "Activo" : "No Activo"
                });

            }
        }

        private void LimpiarControles()
        {
            txtIndiceProd.Text = "-1";
            txtIdProducto.Text = "0";
            txtCodigoProd.Text = string.Empty;
            txtNombreProd.Text = string.Empty;
            txtDescripcionProd.Text = string.Empty;
            cbbCategoriaProd.SelectedIndex = 0;
            cbbEstadoProd.SelectedIndex = 0;
            // Le pone focus
            txtCodigoProd.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            CE_Producto objProducto = new CE_Producto()
            {
                IdProducto = Convert.ToInt32(txtIdProducto.Text),
                Codigo = txtCodigoProd.Text,
                Nombre = txtNombreProd.Text,
                Descripcion = txtDescripcionProd.Text,
                IdOCategoria = new CE_Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbbCategoriaProd.SelectedItem).Valor) },
                // Si es igual a 1 sea true y si no false
                Estado = Convert.ToInt32(((OpcionCombo)cbbEstadoProd.SelectedItem).Valor) == 1 ? true : false
            };

            // Verifica si el IdProducto es 0, con esto se sabe si es para guardar o editar
            // Si el IdProducto es igual a 0, es un Producto nuevo, y si es otro, es para editar el Producto seleccionado
            if (objProducto.IdProducto == 0)
            {
                int idProductogenerado = new CN_Producto().Registrar(objProducto, out mensaje);

                // Si idProducto es diferente de 0 agrega los datos
                if (idProductogenerado != 0)
                {
                    // Agrega los datos de las caja de texto y los convierte para mostrarlo en el dgvListadoProducto
                    dgvListadoProductos.Rows.Add(new object[] {"", idProductogenerado,txtCodigoProd.Text,txtNombreProd.Text,txtDescripcionProd.Text,
                        ((OpcionCombo)cbbCategoriaProd.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cbbCategoriaProd.SelectedItem).Texto.ToString(),
                        
                        // Formato con el que se van a guardar los numeros
                        "0",
                        "0,0.00",
                        "0,0.00",

                        ((OpcionCombo)cbbEstadoProd.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)cbbEstadoProd.SelectedItem).Texto.ToString()
                    });

                    // Despues de almacenar los datos que limpie
                    LimpiarControles();
                }
                else
                {
                    MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Si el IdProducto no es 0, utliza Editar
                bool resultado = new CN_Producto().Editar(objProducto, out mensaje);

                if (resultado)
                {
                    DataGridViewRow row = dgvListadoProductos.Rows[Convert.ToInt32(txtIndiceProd.Text)];
                    row.Cells["IdProducto"].Value = txtIdProducto.Text;
                    row.Cells["Codigo"].Value = txtCodigoProd.Text;
                    row.Cells["Nombre"].Value = txtNombreProd.Text;
                    row.Cells["Descripcion"].Value = txtDescripcionProd.Text;
                    row.Cells["IdCategoria"].Value = ((OpcionCombo)cbbCategoriaProd.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)cbbCategoriaProd.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)cbbEstadoProd.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)cbbEstadoProd.SelectedItem).Texto.ToString();
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
            if (Convert.ToInt32(txtIdProducto.Text) != 0)
            {
                // Ventana que confirma la accion de si o no para eliminar
                if (MessageBox.Show("Desea eliminar este Producto?\n\n" +
                                    "Codigo: " + txtCodigoProd.Text + "\n" +
                                    "Nombre: " + txtNombreProd.Text + "\n\n" +
                                    "Descripcion: " + txtDescripcionProd.Text, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    CE_Producto objProducto = new CE_Producto()
                    {
                        IdProducto = Convert.ToInt32(txtIdProducto.Text),
                    };

                    bool respuesta = new CN_Producto().Eliminar(objProducto, out mensaje);

                    if (respuesta)
                    {
                        dgvListadoProductos.Rows.RemoveAt(Convert.ToInt32(txtIndiceProd.Text));
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
            string columnaFiltro = ((OpcionCombo)cbbBuscarProd.SelectedItem).Valor.ToString();

            if (dgvListadoProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListadoProductos.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtBusquedaProd.Text.Trim().ToUpper()))
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
            txtBusquedaProd.Text = "";

            foreach (DataGridViewRow row in dgvListadoProductos.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvListadoProducto_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void dgvListadoProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoProductos.Columns[e.ColumnIndex].Name == "btnSeleccionarProducto")
            {
                int indice = e.RowIndex;

                if (indice >= 0)
                {
                    txtIndiceProd.Text = indice.ToString();
                    txtIdProducto.Text = dgvListadoProductos.Rows[indice].Cells["IdProducto"].Value.ToString();
                    txtCodigoProd.Text = dgvListadoProductos.Rows[indice].Cells["Codigo"].Value.ToString();
                    txtNombreProd.Text = dgvListadoProductos.Rows[indice].Cells["Nombre"].Value.ToString();
                    txtDescripcionProd.Text = dgvListadoProductos.Rows[indice].Cells["Descripcion"].Value.ToString();

                    // Para que capture la categoria desde el dgvListadoProducto y lo muestre en cbbCategoriaProd
                    foreach (OpcionCombo oc in cbbCategoriaProd.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvListadoProductos.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indiceCombo = cbbCategoriaProd.Items.IndexOf(oc);
                            cbbCategoriaProd.SelectedIndex = indiceCombo;
                            break;
                        }
                    }

                    // Para que capture el estado desde el dgvListadoProducto y lo muestre en txtEstado
                    foreach (OpcionCombo oc in cbbEstadoProd.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvListadoProductos.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indiceCombo = cbbEstadoProd.Items.IndexOf(oc);
                            cbbEstadoProd.SelectedIndex = indiceCombo;
                            break;
                        }
                    }
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            // Logica para exportar en excel
            // Primero verifica las filas
            if (dgvListadoProductos.Rows.Count < 1)
            {
                MessageBox.Show("No hay datos para reportar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                // Llamamos datatable y recorremos todas las columnas con encabezados
                foreach (DataGridViewColumn columna in dgvListadoProductos.Columns)
                {
                    if (columna.HeaderText != string.Empty && columna.Visible)
                    {
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                    }
                }

                // Hacer el recorrido de todas las columnas
                foreach (DataGridViewRow fila in dgvListadoProductos.Rows)
                {
                    if (fila.Visible)
                    {
                        dt.Rows.Add(new object[]
                        {
                            // Fijarse en cuales son las filas que se van a mostrar partiendo
                            // Desde 0
                            fila.Cells[2].Value.ToString(),
                            fila.Cells[3].Value.ToString(),
                            fila.Cells[4].Value.ToString(),
                            fila.Cells[6].Value.ToString(),
                            fila.Cells[7].Value.ToString(),
                            fila.Cells[8].Value.ToString(),
                            fila.Cells[9].Value.ToString(),
                            fila.Cells[11].Value.ToString(),
                        });
                    }
                }
                // Ventana que te pregunta donde quieres guardar el archivo
                // Guardarlo con un formato y que filtre solo archivos de excel
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("Reporte de Productos_{0}.xlsx", DateTime.Now.ToString("dd-MM-yyyy -- hh-mm-ss tt").ToUpper());
                saveFile.Filter = "Excel Files | *.xlsx";

                // Si le das a aceptar para guardar
                // Llamara al paquete closedXML.Excel
                // Guardar el reporte en la ubicación seleccionada
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show("Reporte generado correctamente", "Estado del reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al generar reporte", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            /*if (dgvListadoProductos.Rows.Count < 1)
            {
                MessageBox.Show("No se encontrarón los productos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }*/

            // Uitliza plantilla y cambiar el texto por texto de html

            string Texto_Html = Properties.Resources.PlantillaProducto.ToString();
            CE_Negocio oDatos = new CN_Negocio().ObtenerDatos();
            string titulo = "Lista de Productos";
            string mensaje = "Hola";

            Texto_Html = Texto_Html.Replace("@titulo", titulo);
            Texto_Html = Texto_Html.Replace("@docnegocio", oDatos.RNC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", oDatos.Direccion);
            Texto_Html = Texto_Html.Replace("@nombrenegocio", oDatos.Nombre);
            Texto_Html = Texto_Html.Replace("@fecharegistro", DateTime.Now.ToString("dd-MM-yyyy -- hh-mm-ss tt").ToUpper());

            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvListadoProductos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Codigo"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Nombre"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Descripcion"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Categoria"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Stock"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioCompra"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioVenta"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@Mensaje", mensaje);

            // Ventana que te pregunta donde quieres guardar el archivo
            // Guardarlo con un formato y que filtre solo archivos de excel
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = string.Format("Lista de Productos_{0}.pdf", DateTime.Now.ToString("dd-MM-yyyy -- hh-mm-ss tt").ToUpper());
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