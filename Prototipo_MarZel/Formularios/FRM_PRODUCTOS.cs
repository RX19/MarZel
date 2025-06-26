using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prototipo_MarZel
{
    public partial class FRM_PRODUCTOS : MaterialSkin.Controls.MaterialForm
    {
        public FRM_PRODUCTOS()
        {
            InitializeComponent();
            dgv_productos.DefaultCellStyle.ForeColor = Color.DarkSlateGray;
            dgv_productos.ColumnHeadersDefaultCellStyle.ForeColor = Color.DarkSlateGray;

        }

        private void FRM_PRODUCTOS_Load(object sender, EventArgs e)
        {
            try
            {
                ConexionBD conexionBD = new ConexionBD();
                DataTable tabla = conexionBD.EjecutarConsulta("SELECT * FROM TBL_Productos");
                dgv_productos.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.ControlBox = false;
        }

        private void dgv_productos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgv_productos.Rows[e.RowIndex];

                TXT_CODIGO_BARRA.Text = fila.Cells["Codigo_Barra"].Value?.ToString();
                TXT_DESC.Text = fila.Cells["Descripcion"].Value?.ToString();
                TXT_ISV.Text = fila.Cells["ISV"].Value?.ToString();
                TXT_PU.Text = fila.Cells["Precio_Unitario"].Value?.ToString();
                TXT_PC.Text = fila.Cells["Precio_Completo"].Value?.ToString();
                TXT_CANTIDAD.Text = fila.Cells["Cantidad"].Value?.ToString();
            }
        }
    }
}
