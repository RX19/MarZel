using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Prototipo_MarZel.Formularios
{
    public partial class FRM_CLIENTES : MaterialSkin.Controls.MaterialForm
    {
        private readonly Cliente_Controller Cliente_Controller = new Cliente_Controller();

        public FRM_CLIENTES()
        {
            InitializeComponent();
        }
        public void Cargar_Clientes()
        {
            DataTable Clientes = Cliente_Controller.Cargar_Clientes();
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = Clientes;
            dgvClientes.Columns["ID_CLIENTE"].Visible = false;
            dgvClientes.ClearSelection();
            txtBuscar.Clear();
        }

        private void FRM_CLIENTES_Load(object sender, EventArgs e)
        {
            Cargar_Clientes();

            //----------------------------------------------------------------
            // Diseño del formulario para diferentes tamaños de pantalla.
            int positionx = (this.Width - 974) / 2;
            dgvClientes.Width = this.Width - 100;
            dgvClientes.Height = this.Height - 250;

            dgvClientes.Location = new Point(50, 200);
            lblBuscar.Location = new Point(positionx, 124);
            txtBuscar.Location = new Point(positionx + 69, 108);
            btnAgregarCliente.Location = new Point(positionx + 434, 115);
            btnEditarCliente.Location = new Point(positionx + 624, 115);
            btnEliminarCliente.Location = new Point(positionx + 798, 115);
            //----------------------------------------------------------------
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            FRM_GESTIONAR_CLIENTE frm_gestionar_cliente = new FRM_GESTIONAR_CLIENTE();

            if (frm_gestionar_cliente.ShowDialog() == DialogResult.OK)
                Cargar_Clientes();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null) return;

            int Id_Cliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ID_CLIENTE"].Value);
            FRM_GESTIONAR_CLIENTE frm_gestionar_cliente = new FRM_GESTIONAR_CLIENTE(Id_Cliente);

            if (frm_gestionar_cliente.ShowDialog() == DialogResult.OK)
                Cargar_Clientes();
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dgvClientes.CurrentRow == null) return;

            int Id_Cliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells["ID_CLIENTE"].Value);
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea eliminar al cliente?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Cliente_Controller.Eliminar_Cliente(Id_Cliente);
                Cargar_Clientes();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                Cargar_Clientes();
            }
            else
            {
                DataTable Resultados_De_Busqueda = Cliente_Controller.Buscar_En_Clientes(filtro);
                dgvClientes.DataSource = null;
                dgvClientes.DataSource = Resultados_De_Busqueda;
                dgvClientes.Columns["ID_CLIENTE"].Visible = false;
                dgvClientes.ClearSelection();
            }
        }

        private void FRM_CLIENTES_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea volver al menú principal?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}