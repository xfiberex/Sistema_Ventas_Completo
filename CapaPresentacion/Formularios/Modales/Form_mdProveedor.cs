using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Modales
{
    public partial class Form_mdProveedor : Form
    {
        public CE_Proveedor _Proveedor { get; set; }

        public Form_mdProveedor()
        {
            InitializeComponent();
        }

        private void Form_mdProveedor_Load(object sender, EventArgs e)
        {
            // Para que recorre toda las columnas de dgvListadoProveedor y la muestre en cbbBuscar
            foreach (DataGridViewColumn columna in dgvListadoMdProv.Columns)
            {
                if (columna.Visible == true) // que no agregue la columna del boton
                {
                    cbbBuscarProv.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
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
                dgvListadoMdProv.Rows.Add(new object[]
                {
                    item.IdProveedor,
                    item.Documento,
                    item.RazonSocial
                });

            }
        }

        private void dgvListadoMdProv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Esto es para que cuando se haga doble click en la fila, se cierre el form
            // Se capturen los datos y aparezca en el formulario compras

            int iFila = e.RowIndex;
            int iColumna = e.ColumnIndex;

            if (iFila >= 0 && iColumna >= 0)
            {
                _Proveedor = new CE_Proveedor()
                {
                    IdProveedor = Convert.ToInt32(dgvListadoMdProv.Rows[iFila].Cells["IdProveedor"].Value.ToString()),
                    Documento = dgvListadoMdProv.Rows[iFila].Cells["Documento"].Value.ToString(),
                    RazonSocial = dgvListadoMdProv.Rows[iFila].Cells["RazonSocial"].Value.ToString()
                };
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnBuscarProv_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbBuscarProv.SelectedItem).Valor.ToString();

            if (dgvListadoMdProv.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListadoMdProv.Rows)
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

            foreach (DataGridViewRow row in dgvListadoMdProv.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
