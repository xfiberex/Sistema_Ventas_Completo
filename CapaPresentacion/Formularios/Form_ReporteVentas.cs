using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios
{
    public partial class Form_ReporteVentas : Form
    {
        public Form_ReporteVentas()
        {
            InitializeComponent();
        }

        private void Form_ReporteVentas_Load(object sender, System.EventArgs e)
        {
            // Para cbbBuscar, recorre todas las columnas y muestra sus encabezados
            foreach (DataGridViewColumn columna in dgvListadoReporteVT.Columns)
            {
                cbbBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            cbbBuscar.DisplayMember = "Texto";
            cbbBuscar.ValueMember = "Valor";
            cbbBuscar.SelectedIndex = 0;
        }

        private void btnBuscarReporteVT_Click(object sender, System.EventArgs e)
        {
            List<CE_ReporteVenta> lista = new List<CE_ReporteVenta>();

            lista = new CN_Reporte().Venta(dtpFechaInicio.Value.ToString(), dtpFechaFin.Value.ToString());

            dgvListadoReporteVT.Rows.Clear();

            foreach (CE_ReporteVenta rv in lista)
            {
                dgvListadoReporteVT.Rows.Add(new object[]
                {
                    rv.FechaRegistro,
                    rv.TipoDocumento,
                    rv.NumeroDocumento,
                    rv.MontoTotal,
                    rv.UsuarioRegistro,
                    rv.DocumentoCliente,
                    rv.NombreCliente,
                    rv.CodigoProducto,
                    rv.NombreProducto,
                    rv.Descripcion,
                    rv.Categoria,
                    rv.PrecioVenta,
                    rv.Cantidad,
                    rv.SubTotal
                });
            }
        }

        private void btnExcel_Click(object sender, System.EventArgs e)
        {
            if (dgvListadoReporteVT.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                // Llamamos datatable y recorremos todas las columnas con encabezados
                foreach (DataGridViewColumn columna in dgvListadoReporteVT.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                // Hacer el recorrido de todas las columnas
                foreach (DataGridViewRow fila in dgvListadoReporteVT.Rows)
                {
                    if (fila.Visible)
                    {
                        dt.Rows.Add(new object[]
                        {
                            // Fijarse en cuales son las filas que se van a mostrar partiendo
                            // Desde 0
                            fila.Cells[0].Value.ToString(),
                            fila.Cells[1].Value.ToString(),
                            fila.Cells[2].Value.ToString(),
                            fila.Cells[3].Value.ToString(),
                            fila.Cells[4].Value.ToString(),
                            fila.Cells[5].Value.ToString(),
                            fila.Cells[6].Value.ToString(),
                            fila.Cells[7].Value.ToString(),
                            fila.Cells[8].Value.ToString(),
                            fila.Cells[9].Value.ToString(),
                            fila.Cells[10].Value.ToString(),
                            fila.Cells[11].Value.ToString(),
                            fila.Cells[12].Value.ToString(),
                            fila.Cells[13].Value.ToString()
                        });
                    }
                }
                // Ventana que te pregunta donde quieres guardar el archivo
                // Guardarlo con un formato y que filtre solo archivos de excel
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("Reporte de Ventas_{0}.xlsx", DateTime.Now.ToString("dd-MM-yyyy -- hh-mm-ss tt").ToUpper());
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

        private void btnBuscarPor_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBuscar.SelectedItem).Valor.ToString();

            if (dgvListadoReporteVT.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListadoReporteVT.Rows)
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

            foreach (DataGridViewRow row in dgvListadoReporteVT.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
