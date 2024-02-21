using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Modales
{
    public partial class Form_mdProducto : Form
    {
        public CE_Producto _Producto { get; set; }

        public Form_mdProducto()
        {
            InitializeComponent();
        }

        private void Form_mdProducto_Load(object sender, EventArgs e)
        {
            // Para que recorre toda las columnas de dgvListadoProducto y la muestre en cbbBuscar
            foreach (DataGridViewColumn columna in dgvListadoMdProducto.Columns)
            {
                if (columna.Visible == true) // que no agregue la columna del boton
                {
                    cbbmdBuscarProducto.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbbmdBuscarProducto.DisplayMember = "Texto";
            cbbmdBuscarProducto.ValueMember = "Valor";
            cbbmdBuscarProducto.SelectedIndex = 0;

            // Mostrar todo los Productos en el dgvListadoProducto
            List<CE_Producto> listaProducto = new CN_Producto().Listar();

            // Recorre la lista
            foreach (CE_Producto item in listaProducto)
            {
                dgvListadoMdProducto.Rows.Add(new object[]
                {
                    item.IdProducto,
                    item.Codigo,
                    item.Nombre,
                    item.Descripcion,
                    item.IdOCategoria.Descripcion,
                    item.Stock,
                    item.PrecioCompra,
                    item.PrecioVenta
                });

            }
        }

        private void dgvListadoMdProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Esto es para que cuando se haga doble click en la fila, se cierre el form
            // Se capturen los datos y aparezca en el formulario compras

            int iFila = e.RowIndex;
            int iColumna = e.ColumnIndex;

            if (iFila >= 0 && iColumna >= 0)
            {
                _Producto = new CE_Producto()
                {
                    IdProducto = Convert.ToInt32(dgvListadoMdProducto.Rows[iFila].Cells["IdmdProducto"].Value.ToString()),
                    Codigo = dgvListadoMdProducto.Rows[iFila].Cells["Codigo"].Value.ToString(),
                    Nombre = dgvListadoMdProducto.Rows[iFila].Cells["Nombre"].Value.ToString(),
                    Descripcion = dgvListadoMdProducto.Rows[iFila].Cells["Descripcion"].Value.ToString(),
                    Stock = Convert.ToInt32(dgvListadoMdProducto.Rows[iFila].Cells["Stock"].Value.ToString()),
                    PrecioCompra = Convert.ToDecimal(dgvListadoMdProducto.Rows[iFila].Cells["PrecioCompra"].Value.ToString()),
                    PrecioVenta = Convert.ToDecimal(dgvListadoMdProducto.Rows[iFila].Cells["PrecioVenta"].Value.ToString()),
                };

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnmdBuscarProducto_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbmdBuscarProducto.SelectedItem).Valor.ToString();

            if (dgvListadoMdProducto.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListadoMdProducto.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtmdBusquedaProducto.Text.Trim().ToUpper()))
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

        private void btnmdLimpiarBusquedaProducto_Click(object sender, EventArgs e)
        {
            txtmdBusquedaProducto.Text = "";

            foreach (DataGridViewRow row in dgvListadoMdProducto.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
