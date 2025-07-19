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
        private List<Proveedor> lista_Proveedores = new List<Proveedor>();
        private readonly Proveedor_Controller Proveedor_Controller = new Proveedor_Controller();
        private List<Proveedor> lista_Resultado_Proveedor = new List<Proveedor>();

        public FRM_PROVEEDORES()
        {
            InitializeComponent();
        }

        public void Cargar_Proveedores()
        {
            lista_Proveedores = Proveedor_Controller.Obtener_Proveedores();
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = lista_Proveedores;
            dgvProveedores.Columns["ID_PROVEEDOR"].Visible = false;
            dgvProveedores.ClearSelection();
            txtBuscar.Clear();
        }

        public void Resultados_Proveedor(String texto)
        {
            lista_Resultado_Proveedor = Proveedor_Controller.Buscar_Proveedor(texto);
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = lista_Resultado_Proveedor;
            dgvProveedores.Columns["ID_PROVEEDOR"].Visible = false;
            dgvProveedores.ClearSelection();
        }

        private void FRM_PROVEEDORES_Load(object sender, EventArgs e)
        {
            Cargar_Proveedores();

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
                Cargar_Proveedores();
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvProveedores.CurrentRow == null) return;

            Proveedor proveedorSeleccionado = (Proveedor)dgvProveedores.CurrentRow.DataBoundItem;
            FRM_GESTIONAR_PROVEEDOR frm_gestionar_proveedor = new FRM_GESTIONAR_PROVEEDOR(proveedorSeleccionado);

            if (frm_gestionar_proveedor.ShowDialog() == DialogResult.OK)
                Cargar_Proveedores();
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
                Proveedor_Controller.Eliminar_Proveedor(proveedorSeleccionado.ID_PROVEEDOR);
                Cargar_Proveedores();
            }

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();
            
            if (string.IsNullOrEmpty(texto))
            {
                Cargar_Proveedores();
            }
            else
            {
                Resultados_Proveedor(texto);
            }
        }
    }
}