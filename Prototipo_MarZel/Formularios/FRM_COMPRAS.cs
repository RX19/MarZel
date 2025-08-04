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
    public partial class FRM_COMPRAS : MaterialSkin.Controls.MaterialForm
    {
        private readonly Compra_Controller Compra_Controller = new Compra_Controller();

        public FRM_COMPRAS()
        {
            InitializeComponent();
        }

        public void Cargar_Compras()
        {
            DataTable compras = Compra_Controller.Cargar_Compras();
            dgvCompras.DataSource = null;
            dgvCompras.DataSource = compras;
            dgvCompras.Columns["ID_COMPRA"].Visible = false;
            dgvCompras.Columns["ID_PROVEEDOR"].Visible = false;
            dgvCompras.ClearSelection();
            txtBuscar.Clear();
        }

        private void FRM_COMPRAS_Load(object sender, EventArgs e)
        {
            Cargar_Compras();

            //----------------------------------------------------------------
            //Diseño del formulario para diferentes tamaños de pantalla.
            int positionx = (this.Width - 738) / 2;
            dgvCompras.Width = this.Width - 100;
            dgvCompras.Height = this.Height - 250;

            dgvCompras.Location = new Point(50, 200);
            lblBuscar.Location = new Point(positionx, 124);
            txtBuscar.Location = new Point(positionx + 69, 108);
            btnAgregarCompra.Location = new Point(positionx + 434, 115);
            btnEditarCompra.Location = new Point(positionx + 601, 115);
            //----------------------------------------------------------------
        }

        private void btnAgregarCompra_Click(object sender, EventArgs e)
        {
            FRM_GESTIONAR_COMPRA frm_gestionar_compra = new FRM_GESTIONAR_COMPRA();
            this.Hide();
            frm_gestionar_compra.ShowDialog();
            Cargar_Compras();
        }

        private void btnEditarCompra_Click(object sender, EventArgs e)
        {
            if (dgvCompras.CurrentRow == null) return;

            int ID_Compra = Compra_Controller.Cargar_Compras().Rows[dgvCompras.CurrentRow.Index].Field<int>("ID_COMPRA");
            FRM_GESTIONAR_COMPRA frm_gestionar_compra = new FRM_GESTIONAR_COMPRA(ID_Compra);
            this.Hide();
            frm_gestionar_compra.ShowDialog();
            Cargar_Compras();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                Cargar_Compras();
            }
            else
            {
                DataTable Resultados_De_Busqueda = Compra_Controller.Buscar_En_Compras(filtro);
                dgvCompras.DataSource = null;
                dgvCompras.DataSource = Resultados_De_Busqueda;
                dgvCompras.Columns["ID_COMPRA"].Visible = false;
                dgvCompras.Columns["ID_PROVEEDOR"].Visible = false;
                dgvCompras.ClearSelection();
            }
        }
    }
}
