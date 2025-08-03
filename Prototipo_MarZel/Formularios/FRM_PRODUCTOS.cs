using Prototipo_MarZel.Recursos.Controlador;
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
        Producto_Controller Producto_Controller = new Producto_Controller();
        Categoria_Producto_Controller Categoria_Producto_Controller = new Categoria_Producto_Controller();
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

        public void CargarDatos()
        {
            try
            {
                // Obtener y filtrar productos
                DataTable tablaCompleta = Producto_Controller.ObtenerProductosPorDescripcion();
                DataTable soloProductos = new DataTable();
                soloProductos.Columns.Add("PRODUCTO", typeof(string));
                soloProductos.Columns.Add("EXISTENCIA", typeof(int));
                foreach (DataRow row in tablaCompleta.Rows)
                {
                    soloProductos.Rows.Add(row["PRODUCTO"], row["EXISTENCIA"]);
                }
                DVC_PRODUCTOS.DataSource = soloProductos;
                // Obtener categorías para el ComboBox
                List<String> soloCategoria = new List<string>();
                foreach (DataRow row in tablaCompleta.Rows)
                {
                    soloCategoria.Add(row["CATEGORIA"].ToString());
                }
                CBX_CATEGORIA.DataSource = soloCategoria.Distinct().ToList();
                CBX_CATEGORIA.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void FRM_PRODUCTOS_Load(object sender, EventArgs e)
        {
            await FadeInAsync(this);
            this.Opacity = 1.0;
            CargarDatos();
            DVC_PRODUCTOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void FRM_PRODUCTOS_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea volver al menú principal?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }
        public void LimpiarCampos()
        {
            TXT_CODIGO_B.Text = string.Empty;
            TXT_DESC.Text = string.Empty;
            TXT_ISV.Text = string.Empty;
            TXT_CANTIDAD.Text = string.Empty;
            TXT_PU.Text = string.Empty;
            TXT_PC.Text = string.Empty;
            TXT_BUSCA.Text = string.Empty;
            CBX_CATEGORIA.SelectedIndex = -1;
            CBX_CATEGORIA.Invalidate();
            CBX_CATEGORIA.Update();

        }

        private async void DVC_PRODUCTOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarCampos();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = DVC_PRODUCTOS.Rows[e.RowIndex];
                string nombreProducto = fila.Cells["PRODUCTO"].Value?.ToString();
                DataTable tabla_express = Producto_Controller.ObtenerProducto(nombreProducto);
                DataRow datos = tabla_express.Rows[0];
                TXT_CODIGO_B.Text = datos["CODIGO_BARRA"].ToString();
                TXT_DESC.Text = datos["DESCRIPCION"].ToString();
                TXT_ISV.Text = datos["ID_ISV"].ToString();
                TXT_CANTIDAD.Text = datos["EXISTENCIA"].ToString();
                TXT_PU.Text = datos["PRECIO_UNITARIO"].ToString();
                TXT_PC.Text = datos["PRECIO_COMPLETO"].ToString();
                string categoria = datos["CATEGORIA"].ToString();
                if (tabla_express.Rows.Count > 0)
                {
                    int index = CBX_CATEGORIA.FindStringExact(categoria.Trim());
                    //:v
                    //MessageBox.Show("qwerty "+index);
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

                    CBX_CATEGORIA.Invalidate();
                    CBX_CATEGORIA.Update();

                }
            }
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BTN_WARD_Click(object sender, EventArgs e)
        {
            DataTable dt = Categoria_Producto_Controller.ObtenerCategoriaPorId(CBX_CATEGORIA.Text);
            if (dt.Rows.Count > 0)
            {
                string idCategoria = dt.Rows[0]["ID_PRODUCTO"].ToString();

                Producto_Controller.ModificarProducto(
                    TXT_CODIGO_B.Text,
                    TXT_DESC.Text,
                    Convert.ToInt32(idCategoria),
                    Convert.ToDecimal(TXT_PU.Text),
                    Convert.ToDecimal(TXT_PC.Text)
                );

                CargarDatos();
                LimpiarCampos();
                MessageBox.Show("Producto modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor seleccione datos correctos");
            }
        }

        private void TXT_BUSCA_TextChanged(object sender, EventArgs e)
        {
            string textoBusquedaP = TXT_BUSCA.Text.Trim();
            if (string.IsNullOrWhiteSpace(textoBusquedaP))
            {
                LimpiarCampos();
                return;
            }

            DataTable tabla_express = Producto_Controller.ObtenerProducto(textoBusquedaP);

            if (tabla_express != null && tabla_express.Rows.Count > 0)
            {
                DataRow datos = tabla_express.Rows[0];
                TXT_CODIGO_B.Text = datos["CODIGO_BARRA"].ToString();
                TXT_DESC.Text = datos["DESCRIPCION"].ToString();
                TXT_ISV.Text = datos["ID_ISV"].ToString();
                TXT_CANTIDAD.Text = datos["EXISTENCIA"].ToString();
                TXT_PU.Text = datos["PRECIO_UNITARIO"].ToString();
                TXT_PC.Text = datos["PRECIO_COMPLETO"].ToString();

                string categoria = datos["CATEGORIA"].ToString();
                int index = CBX_CATEGORIA.FindStringExact(categoria.Trim());
                CBX_CATEGORIA.SelectedIndex = index >= 0 ? index : -1;
                CBX_CATEGORIA.Invalidate();
                CBX_CATEGORIA.Update();
            }
            else
            {
                LimpiarCampos();
            }
        }



        private Movimiento_Inventario_Controller movimientoController = new Movimiento_Inventario_Controller();

        private void CargarHistorialMovimientos()
        {
            try
            {
                DataTable movimientos = movimientoController.ObtenerMovimientos();
                DVC_HISTORIAL.DataSource = movimientos;
                DVC_HISTORIAL.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el historial de movimientos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MTBC_MENU_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (MTBC_MENU.SelectedTab == TP_HISTORIAL)
            {
                CargarHistorialMovimientos();
            }
        }

        private void BTN_FILTRAR_Click(object sender, EventArgs e)
        {
            string filtro = TXT_FILTRO_PRODUCTO.Text.Trim();
            DataTable movimientosFiltrados = movimientoController.FiltrarPorProducto(filtro);
            DVC_HISTORIAL.DataSource = movimientosFiltrados;
        }


        private void TXT_FILTRO_PRODUCTO_TextChanged(object sender, EventArgs e)
        {
            string filtro = TXT_FILTRO_PRODUCTO.Text.Trim();
            DataTable movimientosFiltrados = movimientoController.FiltrarPorProducto(filtro);
            DVC_HISTORIAL.DataSource = movimientosFiltrados;
        }
    }
}
