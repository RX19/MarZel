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
        private readonly ProveedorController proveedorController = new ProveedorController();
        private List<Proveedor> listaProveedores = new List<Proveedor>();

        public FRM_PROVEEDORES()
        {
            InitializeComponent();
        }

        public void CargarProveedores()
        {
            listaProveedores = proveedorController.ObtenerProveedores();
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = listaProveedores;
        }

        private void FRM_PROVEEDORES_Load(object sender, EventArgs e)
        {
            CargarProveedores();
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

    }
}
