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
                // Obtener y filtrar productos
                DataTable tablaCompleta = productoController.ObtenerProductosPorDescripcion();
                DataTable soloProductos = new DataTable();
                soloProductos.Columns.Add("Producto", typeof(string));
                foreach (DataRow row in tablaCompleta.Rows)
                {
                    soloProductos.Rows.Add(row["Producto"]);
                }
                DVC_PRODUCTOS.DataSource = soloProductos;
                // Obtener categorías para el ComboBox
                List<String> soloCategoria = new List<string>();
                foreach (DataRow row in tablaCompleta.Rows)
                {
                    soloCategoria.Add(row["Categoria"].ToString());
                }
                CBX_CATEGORIA.DataSource = soloCategoria.Distinct().ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DVC_PRODUCTOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void DVC_PRODUCTOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DVC_PRODUCTOS.Rows[e.RowIndex];
                string nombreProducto = fila.Cells["Producto"].Value?.ToString();
                DataTable tabla_express = productoController.ObtenerProducto(nombreProducto);

                if (tabla_express.Rows.Count > 0)
                {
                    DataRow datos = tabla_express.Rows[0];
                    TXT_CODIGO_B.Text = datos["Codigo_Barra"].ToString();
                    TXT_DESC.Text = datos["Descripcion"].ToString();
                    TXT_ISV.Text = datos["ISV"].ToString();
                    TXT_CANTIDAD.Text = datos["Cantidad"].ToString();
                    TXT_PU.Text = datos["Precio_Unitario"].ToString();
                    TXT_PC.Text = datos["Precio_Completo"].ToString();
                    string categoria = datos["Categoria"].ToString();
                    int index = CBX_CATEGORIA.FindStringExact(categoria.Trim());
                    if (index >= 0)
                    {
                        CBX_CATEGORIA.SelectedIndex = index;
                        //debugado de panas :v
                        //MessageBox.Show("Categoria seleccionada: " + categoria, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CBX_CATEGORIA.SelectedIndex = -1;
                    }
                    //debugado de panas 2 :v
                    /*
                    DataTable dt = CategoriaController.ObtenerCategoriaPorId(CBX_CATEGORIA.Text);

                    if (dt.Rows.Count > 0)
                    {
                        string idCategoria = dt.Rows[0]["ID"].ToString();
                        MessageBox.Show("ID de categoría: " + idCategoria);
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la categoría.");
                    }
                    */

                }
            }
        }

    }
}
