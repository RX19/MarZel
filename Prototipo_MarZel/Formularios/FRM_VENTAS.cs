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
    public partial class FRM_VENTAS : MaterialSkin.Controls.MaterialForm
    {
        private readonly Venta_Controller Venta_Controller = new Venta_Controller();
        int Id_Usuario;
        string Nombre_Usuario;
        public FRM_VENTAS(int Id_Usuario, string Nombre_Usuario)
        {
            InitializeComponent();
            this.Id_Usuario = Id_Usuario;
            this.Nombre_Usuario = Nombre_Usuario;
        }

        public void Cargar_Ventas()
        {
            DataTable Ventas = Venta_Controller.Cargar_Ventas();
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = Ventas;
            dgvVentas.Columns["ID_VENTA"].Visible = false;
            dgvVentas.Columns["ID_CLIENTE"].Visible = false;
            dgvVentas.ClearSelection();
            txtBuscar.Clear();
        }

        private void FRM_VENTAS_Load(object sender, EventArgs e)
        {
            Cargar_Ventas();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(filtro))
            {
                Cargar_Ventas();
            }
            else
            {
                DataTable Resultados_De_Busqueda = Venta_Controller.Buscar_En_Ventas(filtro);
                dgvVentas.DataSource = null;
                dgvVentas.DataSource = Resultados_De_Busqueda;
                dgvVentas.Columns["ID_VENTA"].Visible = false;
                dgvVentas.Columns["ID_CLIENTE"].Visible = false;
                dgvVentas.ClearSelection();
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            FRM_GESTIONAR_VENTA frm_gestionar_venta = new FRM_GESTIONAR_VENTA(Id_Usuario, Nombre_Usuario);
            this.Hide();
            frm_gestionar_venta.ShowDialog();
            Cargar_Ventas();
        }

        private void btnEditarVenta_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow == null) return;

            int Id_Venta = Venta_Controller.Cargar_Ventas().Rows[dgvVentas.CurrentRow.Index].Field<int>("ID_VENTA");
            FRM_GESTIONAR_VENTA frm_gestionar_venta = new FRM_GESTIONAR_VENTA(Id_Usuario, Nombre_Usuario, Id_Venta);
            this.Hide();
            frm_gestionar_venta.ShowDialog();
            Cargar_Ventas();
        }
    }
}