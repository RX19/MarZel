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
        SqlConnection   conexion = new SqlConnection("server=ROBBER\\SQLEXPRESS; database=MarZel; integrated security=true");
        private void FRM_PRODUCTOS_Load(object sender, EventArgs e)
        {
            try
            {
                conexion.Open();
                string query = "SELECT * FROM Productos";
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dgv_productos.DataSource = tabla;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
