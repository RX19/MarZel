using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_MarZel.Formularios
{
    public partial class FRM_PROVEEDORES : MaterialSkin.Controls.MaterialForm
    {
        private List<Proveedor> listaProveedores = new List<Proveedor>();
        private readonly ProveedorController proveedorController = new ProveedorController();
        private List<Proveedor> listaResultadoProveedor = new List<Proveedor>();

        public FRM_PROVEEDORES()
        {
            InitializeComponent();
        }

        public void CargarProveedores()
        {
            listaProveedores = proveedorController.ObtenerProveedores();
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = listaProveedores;
            dgvProveedores.Columns["ID_PROVEEDOR"].Visible = false;
            dgvProveedores.ClearSelection();
            txtBuscar.Clear();
        }

        public void ResultadosProveedor(String texto)
        {
            listaResultadoProveedor = proveedorController.BuscarProveedor(texto);
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = listaResultadoProveedor;
            dgvProveedores.Columns["ID_PROVEEDOR"].Visible = false;
            dgvProveedores.ClearSelection();
        }

        private void FRM_PROVEEDORES_Load(object sender, EventArgs e)
        {
            CargarProveedores();

            //----------------------------------------------------------------
            //Diseño del formulario para diferentes tamaños de pantalla.
                int positionx = (this.Width-974)/2;
                dgvProveedores.Width = this.Width - 100;
                dgvProveedores.Height = this.Height - 250;
            
                dgvProveedores.Location = new Point(50, 200);
                lblBuscar.Location = new Point(positionx, 124);
                txtBuscar.Location = new Point(positionx+69, 108);
                btnAgregarProveedor.Location = new Point(positionx+434, 115);  
                btnEditarProveedor.Location = new Point(positionx+624, 115);
                btnEliminarProveedor.Location = new Point(positionx+798, 115);
            //----------------------------------------------------------------
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FRM_GESTIONAR_PROVEEDOR frm_gestionar_proveedor = new FRM_GESTIONAR_PROVEEDOR();

            if (frm_gestionar_proveedor.ShowDialog() == DialogResult.OK)
                CargarProveedores();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null) return;

            Proveedor proveedorSeleccionado = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
            FRM_GESTIONAR_PROVEEDOR frm_gestionar_proveedor = new FRM_GESTIONAR_PROVEEDOR(proveedorSeleccionado);

            if (frm_gestionar_proveedor.ShowDialog() == DialogResult.OK)
                CargarProveedores();

        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {

            if (dgvProveedores.CurrentRow == null) return;

            Proveedor proveedorSeleccionado = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
            DialogResult resultado = MessageBox.Show(
                $"¿Está seguro que desea eliminar al proveedor {proveedorSeleccionado.NOMBRE}?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                proveedorController.EliminarProveedor(proveedorSeleccionado.ID_PROVEEDOR);
                CargarProveedores();
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            
            if (string.IsNullOrEmpty(texto))
            {
                CargarProveedores();
            }
            else
            {
                ResultadosProveedor(texto);
            }
        }
    }
}
