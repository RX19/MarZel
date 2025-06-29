using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;


namespace Prototipo_MarZel
{

    public partial class FRM_PRODUCTOS : MaterialSkin.Controls.MaterialForm
    {
        ProductoController productoController = new ProductoController();
        CategoriaController CategoriaController = new CategoriaController();
        public FRM_PRODUCTOS()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //this.ControlBox = false;         // Quita los tres botones (cerrar, minimizar, maximizar)
            this.MaximizeBox = false;        // Impide maximizar
            this.Hide();
            try
            {
                DataTable categoria = CategoriaController.ObtenerProductos();

                foreach (DataRow fila in categoria.Rows)
                {
                    CBX_CATEGORIA.Items.Add(fila["Descripcion"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private async Task FadeOutAsync(Form form)
        {
            for (double i = 1.0; i >= 0; i -= 0.05)
            {
                form.Opacity = i;
                await Task.Delay(15);
            }
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

        private async void FRM_PRODUCTOS_Load(object sender, EventArgs e)
        {
            await FadeInAsync(this);
            this.Opacity = 1.0;
            try
            {
                DataTable tabla = productoController.ObtenerProductosPorDescripcion();
                DataTable lista = CategoriaController.ObtenerProductos();
                DVC_PRODUCTOS.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DVC_PRODUCTOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void DVC_PRODUCTOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = DVC_PRODUCTOS.Rows[e.RowIndex];
            DataTable tabla_express = productoController.ObtenerProducto(fila.Cells["Producto"].Value?.ToString());
            TXT_CODIGO_B.Text = tabla_express.Rows[0]["Codigo_Barra"].ToString();
            TXT_DESC.Text = tabla_express.Rows[0]["Descripcion"].ToString();
            TXT_ISV.Text = tabla_express.Rows[0]["ISV"].ToString();
            TXT_CANTIDAD.Text = tabla_express.Rows[0]["Cantidad"].ToString();
            TXT_PU.Text = tabla_express.Rows[0]["Precio_Unitario"].ToString();
            TXT_PC.Text = tabla_express.Rows[0]["Precio_Completo"].ToString();
        }
    }
}
