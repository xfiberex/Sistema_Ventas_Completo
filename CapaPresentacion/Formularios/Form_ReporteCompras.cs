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
    public partial class Form_ReporteCompras : Form
    {
        public Form_ReporteCompras()
        {
            InitializeComponent();
        }

        private void Form_ReporteCompras_Load(object sender, System.EventArgs e)
        {
            // Obtener la lista de las categorias
            List<CE_Proveedor> listaProveedor = new CN_Proveedor().Listar();

            // Permite exportar todas la compras en caso de que el proveedor sea = 0
            cbbProveedor.Items.Add(new OpcionCombo() { Valor = 0, Texto = "TODOS" });

            // Recorre la lista
            foreach (CE_Proveedor item in listaProveedor)
            {
                cbbProveedor.Items.Add(new OpcionCombo() { Valor = item.IdProveedor, Texto = item.RazonSocial });
            }

            // Mostra esto predeterminado
            cbbProveedor.DisplayMember = "Texto";
            cbbProveedor.ValueMember = "Valor";
            cbbProveedor.SelectedIndex = 0;

            // Para cbbBuscar, recorre todas las columnas y muestra sus encabezados
            foreach (DataGridViewColumn columna in dgvListadoReporteCP.Columns)
            {
                cbbBuscar.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            cbbBuscar.DisplayMember = "Texto";
            cbbBuscar.ValueMember = "Valor";
            cbbBuscar.SelectedIndex = 0;
        }

        private void btnBuscarProveedor_Click(object sender, System.EventArgs e)
        {
            int idproveedor = Convert.ToInt32(((OpcionCombo)cbbProveedor.SelectedItem).Valor.ToString());

            List<CE_ReporteCompra> lista = new List<CE_ReporteCompra>();

            lista = new CN_Reporte().Compra(dtpFechaInicio.Value.ToString(), dtpFechaFin.Value.ToString(), idproveedor);

            dgvListadoReporteCP.Rows.Clear();

            foreach (CE_ReporteCompra rc in lista)
            {
                dgvListadoReporteCP.Rows.Add(new object[]
                {
                    rc.FechaRegistro,
                    rc.TipoDocumento,
                    rc.NumeroDocumento,
                    rc.MontoTotal,
                    rc.UsuarioRegistro,
                    rc.DocumentoProveedor,
                    rc.RazonSocial,
                    rc.CodigoProducto,
                    rc.NombreProducto,
                    rc.Descripcion,
                    rc.Categoria,
                    rc.PrecioCompra,
                    rc.PrecioVenta,
                    rc.Cantidad,
                    rc.SubTotal
                });
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvListadoReporteCP.Rows.Count < 1)
            {
                MessageBox.Show("No hay registros para exportar", "Estado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                // Llamamos datatable y recorremos todas las columnas con encabezados
                foreach (DataGridViewColumn columna in dgvListadoReporteCP.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                // Hacer el recorrido de todas las columnas
                foreach (DataGridViewRow fila in dgvListadoReporteCP.Rows)
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
                            fila.Cells[13].Value.ToString(),
                            fila.Cells[14].Value.ToString()
                        });
                    }
                }
                // Ventana que te pregunta donde quieres guardar el archivo
                // Guardarlo con un formato y que filtre solo archivos de excel
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("Reporte de Compras_{0}.xlsx", DateTime.Now.ToString("dd-MM-yyyy -- hh-mm-ss tt").ToUpper());
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

            if (dgvListadoReporteCP.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListadoReporteCP.Rows)
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

            foreach (DataGridViewRow row in dgvListadoReporteCP.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
