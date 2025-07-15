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
        FRM_GESTIONAR_PROVEEDOR frm_gestionar_proveedor = new FRM_GESTIONAR_PROVEEDOR();
        
        private readonly ProveedorController proveedorController = new ProveedorController();
        private List<Proveedor> listaProveedores = new List<Proveedor>();
        public FRM_PROVEEDORES()
        {
            InitializeComponent();
            this.Hide();
        }

        private async Task FadeInAsync(Form form)
        {
            form.Opacity = 0;
            for (double i = 0; i <= 1.0; i += 0.05)
            {
                form.Opacity = i;
                await Task.Delay(15);
            }
        }

        public void CargarProveedores()
        {
            listaProveedores = proveedorController.ObtenerProveedores();
            dgvProveedores.DataSource = null;
            dgvProveedores.DataSource = listaProveedores;
        }

        private async void FRM_PROVEEDORES_Load(object sender, EventArgs e)
        {
            await FadeInAsync(this);
            this.Opacity = 1.0;
            CargarProveedores();
        }

        private async void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            for (double i = 1.0; i >= 0.2; i -= 0.05)
            {
                this.Opacity = i;
                await Task.Delay(15);
            }
            this.Visible = false;
            frm_gestionar_proveedor.ShowDialog();
            this.Visible = true;
            for (double i = 0.2; i <= 1.0; i += 0.05)
            {
                this.Opacity = i;
                await Task.Delay(15);
            }
            this.Opacity = 1.0;

            if (frm_gestionar_proveedor.DialogResult == DialogResult.OK)
            {
                CargarProveedores();
            }
        }
    }
}
