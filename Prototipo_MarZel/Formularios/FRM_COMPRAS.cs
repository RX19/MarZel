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
        private List<Compra> listaCompras = new List<Compra>();
        private readonly CompraController compraController = new CompraController();

        public FRM_COMPRAS()
        {
            InitializeComponent();
        }

        public void CargarCompras()
        {
            listaCompras = compraController.ObtenerCompras();
            dgvCompras.DataSource = null;
            dgvCompras.DataSource = listaCompras;
            dgvCompras.Columns["ID_COMPRA"].Visible = false;
            dgvCompras.Columns["ID_PROVEEDOR"].Visible = false;
            dgvCompras.Columns["SUBTOTAL"].Visible = false;
            dgvCompras.Columns["FECHA"].DisplayIndex = 0;
            dgvCompras.ClearSelection();
            txtBuscar.Clear();
        }

        private void FRM_COMPRAS_Load(object sender, EventArgs e)
        {
            CargarCompras();

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
    }
}
