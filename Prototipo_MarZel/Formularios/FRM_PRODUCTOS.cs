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

    }
}
