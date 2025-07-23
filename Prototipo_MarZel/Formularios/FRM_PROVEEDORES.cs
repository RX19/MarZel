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
        private readonly Proveedor_Controller Proveedor_Controller = new Proveedor_Controller();

        public FRM_PROVEEDORES()
        {
            InitializeComponent();
        }

        public void Cargar_Proveedores()
        {
            DataTable Proveedores = Proveedor_Controller.Cargar_Proveedores();
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = Proveedores;
            dgvProveedores.Columns["ID_PROVEEDOR"].Visible = false;
            dgvProveedores.ClearSelection();
            txtBuscar.Clear();
        }

        private void FRM_PROVEEDORES_Load(object sender, EventArgs e)
        {
            Cargar_Proveedores();

            //----------------------------------------------------------------
            //Diseño del formulario para diferentes tamaños de pantalla.
            int positionx = (this.Width - 974) / 2;
            dgvProveedores.Width = this.Width - 100;
            dgvProveedores.Height = this.Height - 250;

            dgvProveedores.Location = new Point(50, 200);
            lblBuscar.Location = new Point(positionx, 124);
            txtBuscar.Location = new Point(positionx + 69, 108);
            btnAgregarProveedor.Location = new Point(positionx + 434, 115);
            btnEditarProveedor.Location = new Point(positionx + 624, 115);
            btnEliminarProveedor.Location = new Point(positionx + 798, 115);
            //----------------------------------------------------------------
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            FRM_GESTIONAR_PROVEEDOR frm_gestionar_proveedor = new FRM_GESTIONAR_PROVEEDOR();

            if (frm_gestionar_proveedor.ShowDialog() == DialogResult.OK)
                Cargar_Proveedores();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null) return;

            int Id_Proveedor = Convert.ToInt32(dgvProveedores.CurrentRow.Cells["ID_PROVEEDOR"].Value);
            FRM_GESTIONAR_PROVEEDOR frm_gestionar_proveedor = new FRM_GESTIONAR_PROVEEDOR(Id_Proveedor);

            if (frm_gestionar_proveedor.ShowDialog() == DialogResult.OK)
                Cargar_Proveedores();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null) return;

            int Id_Proveedor = Convert.ToInt32(dgvProveedores.CurrentRow.Cells["ID_PROVEEDOR"].Value);
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea eliminar al proveedor?",
                "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                Proveedor_Controller.Eliminar_Proveedor(Id_Proveedor);
                Cargar_Proveedores();
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                Cargar_Proveedores();
            }
            else
            {
                DataTable Resultados_De_Busqueda = Proveedor_Controller.Buscar_En_Proveedores(filtro);
                dgvProveedores.DataSource = null;
                dgvProveedores.DataSource = Resultados_De_Busqueda;
                dgvProveedores.Columns["ID_PROVEEDOR"].Visible = false;
                dgvProveedores.ClearSelection();
            }
        }
    }
}