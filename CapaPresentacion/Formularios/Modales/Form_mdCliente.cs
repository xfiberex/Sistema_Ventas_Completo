using CapaEntidad;
using CapaNegocio;
using CapaPresentacion.Utilidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaPresentacion.Formularios.Modales
{
    public partial class Form_mdCliente : Form
    {
        public CE_Cliente _Cliente { get; set; }

        public Form_mdCliente()
        {
            InitializeComponent();
        }

        private void Form_mdCliente_Load(object sender, EventArgs e)
        {
            // Para que recorre toda las columnas de dgvListadoCliente y la muestre en cbbBuscar
            foreach (DataGridViewColumn columna in dgvListadoClientes.Columns)
            {
                if (columna.Visible == true) // que no agregue la columna del boton
                {
                    cbbmdBuscarCliente.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            cbbmdBuscarCliente.DisplayMember = "Texto";
            cbbmdBuscarCliente.ValueMember = "Valor";
            cbbmdBuscarCliente.SelectedIndex = 0;

            // Mostrar todo los Clientes en el dgvListadoCliente
            List<CE_Cliente> listaCliente = new CN_Cliente().Listar();

            // Recorre la lista
            foreach (CE_Cliente item in listaCliente)
            {
                // Si el cliente tiene estado activo aparece
                if (item.Estado == true)
                {
                    dgvListadoClientes.Rows.Add(new object[]
                    {
                        item.Documento,
                        item.NombreCompleto
                    });
                }
            }
        }

        private void dgvListadoClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Esto es para que cuando se haga doble click en la fila, se cierre el form
            // Se capturen los datos y aparezca en el formulario compras

            int iFila = e.RowIndex;
            int iColumna = e.ColumnIndex;

            if (iFila >= 0 && iColumna >= 0)
            {
                _Cliente = new CE_Cliente()
                {
                    Documento = dgvListadoClientes.Rows[iFila].Cells["Documento"].Value.ToString(),
                    NombreCompleto = dgvListadoClientes.Rows[iFila].Cells["NombreCompleto"].Value.ToString()
                };

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnmdBuscarCliente_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbbmdBuscarCliente.SelectedItem).Valor.ToString();

            if (dgvListadoClientes.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvListadoClientes.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtmdBusquedaCliente.Text.Trim().ToUpper()))
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

        private void btnLimpiarmdCliente_Click(object sender, EventArgs e)
        {
            txtmdBusquedaCliente.Text = "";

            foreach (DataGridViewRow row in dgvListadoClientes.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
