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
        Tipo_ISV_Controller Tipo_ISV_Controller = new Tipo_ISV_Controller();
        int Id_Producto;

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

        private void Cargar_Categorias()
        {
            DataTable Categorias = Categoria_Producto_Controller.Cargar_Categorias();
            CBX_CATEGORIA.DataSource = null;
            CBX_CATEGORIA.DataSource = Categorias;
            CBX_CATEGORIA.DisplayMember = "DESCRIPCION";
            CBX_CATEGORIA.ValueMember = "ID_CATEGORIA";
            CBX_CATEGORIA.SelectedIndex = -1;
        }

        private void Cargar_Tipos_ISV()
        {
            DataTable Tipos_ISV = Tipo_ISV_Controller.Cargar_Tipos_ISV();
            CBX_TIPOISV.DataSource = null;
            CBX_TIPOISV.DataSource = Tipos_ISV;
            CBX_TIPOISV.DisplayMember = "DESCRIPCION";
            CBX_TIPOISV.ValueMember = "ID_ISV";
            CBX_TIPOISV.SelectedIndex = -1;
        }

        public void CargarDatos()
        {
            try
            {
                // Obtener y filtrar productos
                DataTable productos = Producto_Controller.ObtenerProductos();
                DVC_PRODUCTOS.DataSource = null;
                DVC_PRODUCTOS.DataSource = productos;
                DVC_PRODUCTOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DVC_PRODUCTOS.Columns["ID_PRODUCTO"].Visible = false;
                DVC_PRODUCTOS.ClearSelection();
                Cargar_Categorias();
                Cargar_Tipos_ISV();
                TXT_CODIGO_B.Enabled = false;
                TXT_DESC.Enabled = false;
                CBX_CATEGORIA.Enabled = false;
                CBX_TIPOISV.Enabled = false;
                TXT_EXISTENCIA.Enabled = false;
                TXT_PU.Enabled = false;
                TXT_PC.Enabled = false;
                LimpiarCampos();
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
            TXT_EXISTENCIA.Text = string.Empty;
            TXT_PU.Text = string.Empty;
            TXT_PC.Text = string.Empty;
            CBX_CATEGORIA.SelectedIndex = -1;
            CBX_CATEGORIA.Invalidate();
            CBX_TIPOISV.SelectedIndex = -1;
            CBX_TIPOISV.Invalidate();
        }

        private void BTN_CANCEL_Click(object sender, EventArgs e)
        {
            TXT_BUSCA.Text = string.Empty;
            DVC_PRODUCTOS.ClearSelection();
            LimpiarCampos();
        }

        private bool verificar()
        {
            if (string.IsNullOrWhiteSpace(TXT_CODIGO_B.Text))
            {
                MessageBox.Show("Debe ingresar un código de barra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBarra.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TXT_DESC.Text))
            {
                MessageBox.Show("Debe ingresar una descripción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }

            if (CBX_TIPOISV.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de ISV.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBX_TIPOISV.Focus();
                return false;
            }

            if (CBX_CATEGORIA.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBX_CATEGORIA.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TXT_PU.Text) || !decimal.TryParse(TXT_PU.Text, out decimal precio_unit) || precio_unit < 0)
            {
                MessageBox.Show("Debe ingresar un precio unitario válido mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_PU.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(TXT_PC.Text) || !decimal.TryParse(TXT_PC.Text, out decimal precio_comp) || precio_comp < 0)
            {
                MessageBox.Show("Debe ingresar un precio completo válido mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXT_PC.Focus();
                return false;
            }

            return true;
        }

        private void BTN_WARD_Click(object sender, EventArgs e)
        {
            if (!verificar()) return;

            Producto_Controller.Modificar_Producto(
                Id_Producto,
                TXT_CODIGO_B.Text,
                TXT_DESC.Text,
                Convert.ToInt32(CBX_TIPOISV.SelectedValue),
                Convert.ToDecimal(TXT_PC.Text),
                Convert.ToDecimal(TXT_PU.Text),
                Convert.ToInt32(CBX_CATEGORIA.SelectedValue),
                Convert.ToInt32(TXT_EXISTENCIA.Text)
            );

            CargarDatos();
            TXT_BUSCA.Text = string.Empty;
            LimpiarCampos();
            MessageBox.Show("Producto modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TXT_BUSCA_TextChanged(object sender, EventArgs e)
        {
            string textoBusquedaP = TXT_BUSCA.Text.Trim();
            DVC_PRODUCTOS.ClearSelection();
            LimpiarCampos();
            DataTable tabla_express = Producto_Controller.Cargar_Producto(textoBusquedaP);

            if (tabla_express != null && tabla_express.Rows.Count > 0)
            {
                DataRow datos = tabla_express.Rows[0];
                TXT_CODIGO_B.Text = datos["CODIGO_BARRA"].ToString();
                TXT_DESC.Text = datos["DESCRIPCION"].ToString();
                TXT_EXISTENCIA.Text = datos["EXISTENCIA"].ToString();
                TXT_PU.Text = datos["PRECIO_UNITARIO"].ToString();
                TXT_PC.Text = datos["PRECIO_COMPLETO"].ToString();
                CBX_CATEGORIA.SelectedValue = datos["ID_CATEGORIA"];
                CBX_CATEGORIA.Invalidate();
                CBX_TIPOISV.SelectedValue = datos["ID_ISV"];
                CBX_TIPOISV.Invalidate();
                TXT_CODIGO_B.Enabled = true;
                TXT_DESC.Enabled = true;
                CBX_CATEGORIA.Enabled = true;
                CBX_TIPOISV.Enabled = true;
                TXT_PU.Enabled = true;
                TXT_PC.Enabled = true;
            }
            else
            {
                TXT_CODIGO_B.Enabled = false;
                TXT_DESC.Enabled = false;
                CBX_CATEGORIA.Enabled = false;
                CBX_TIPOISV.Enabled = false;
                TXT_PU.Enabled = false;
                TXT_PC.Enabled = false;
            }
        }

        private void DVC_HISTORIAL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            else if (MTBC_MENU.SelectedTab == TP_INSERTAR)
            {
                CargarCategorias();
                CargarTipos_ISV();
            }
        }

        private void BTN_FILTRAR_Click(object sender, EventArgs e)
        {
            string filtro = TXT_FILTRO_PRODUCTO.Text.Trim();
            DataTable movimientosFiltrados = movimientoController.FiltrarPorProducto(filtro);
            DVC_HISTORIAL.DataSource = movimientosFiltrados;
        }

        private bool verificar_nuevo()
        {
            if (string.IsNullOrWhiteSpace(txtCodigoBarra.Text))
            {
                MessageBox.Show("Debe ingresar un código de barra.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBarra.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Debe ingresar una descripción.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescripcion.Focus();
                return false;
            }

            if (cmbTiposISV.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de ISV.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBX_TIPOISV.Focus();
                return false;
            }

            if (cmbCaregorias.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CBX_CATEGORIA.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioUnitario.Text) || !decimal.TryParse(txtPrecioUnitario.Text, out decimal precio_unit) || precio_unit < 0)
            {
                MessageBox.Show("Debe ingresar un precio unitario válido mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioUnitario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioCompleto.Text) || !decimal.TryParse(txtPrecioCompleto.Text, out decimal precio_comp) || precio_comp < 0)
            {
                MessageBox.Show("Debe ingresar un precio completo válido mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCompleto.Focus();
                return false;
            }

            if (Producto_Controller.existeProducto(txtCodigoBarra.Text))
            {
                MessageBox.Show("El código de barra ya existe. Por favor, ingrese uno diferente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBarra.Focus();
                return false;
            }

            return true;
        }

        private void CargarCategorias()
        {
            DataTable Categorias = Categoria_Producto_Controller.Cargar_Categorias();
            cmbCaregorias.DataSource = null;
            cmbCaregorias.DataSource = Categorias;
            cmbCaregorias.DisplayMember = "DESCRIPCION";
            cmbCaregorias.ValueMember = "ID_CATEGORIA";
            cmbCaregorias.SelectedIndex = -1;
        }

        private void CargarTipos_ISV()
        {
            DataTable Tipos_ISV = Tipo_ISV_Controller.Cargar_Tipos_ISV();
            cmbTiposISV.DataSource = null;
            cmbTiposISV.DataSource = Tipos_ISV;
            cmbTiposISV.DisplayMember = "DESCRIPCION";
            cmbTiposISV.ValueMember = "ID_ISV";
            cmbTiposISV.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!verificar_nuevo()) return;

            Producto_Controller.Agregar_Producto(
                txtCodigoBarra.Text,
                txtDescripcion.Text,
                Convert.ToInt32(cmbTiposISV.SelectedValue),
                Convert.ToDecimal(txtPrecioCompleto.Text),
                Convert.ToDecimal(txtPrecioUnitario.Text),
                Convert.ToInt32(cmbCaregorias.SelectedValue),
                Convert.ToInt32(txtExistencia.Text)
            );

            CargarDatos();
            MTBC_MENU.SelectedTab = TP_MODIFICAR;
        }

        private void DVC_PRODUCTOS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarCampos();
            Id_Producto = Convert.ToInt32(DVC_PRODUCTOS.CurrentRow.Cells["ID_PRODUCTO"].Value);
            MessageBox.Show($"{Id_Producto}");
            DataTable tabla_express = Producto_Controller.Cargar_Producto(Id_Producto);
            TXT_CODIGO_B.Text = tabla_express.Rows[0]["CODIGO_BARRA"].ToString() ?? "";
            TXT_DESC.Text = tabla_express.Rows[0]["DESCRIPCION"].ToString() ?? "";
            TXT_EXISTENCIA.Text = tabla_express.Rows[0]["EXISTENCIA"].ToString() ?? "0";
            TXT_PU.Text = tabla_express.Rows[0]["PRECIO_UNITARIO"].ToString() ?? "0.00";
            TXT_PC.Text = tabla_express.Rows[0]["PRECIO_COMPLETO"].ToString() ?? "0.00";
            CBX_CATEGORIA.SelectedValue = tabla_express.Rows[0]["ID_CATEGORIA"];
            CBX_CATEGORIA.Invalidate();
            CBX_TIPOISV.SelectedValue = tabla_express.Rows[0]["ID_ISV"];
            CBX_TIPOISV.Invalidate();
            TXT_CODIGO_B.Enabled = true;
            TXT_DESC.Enabled = true;
            CBX_CATEGORIA.Enabled = true;
            CBX_TIPOISV.Enabled = true;
            TXT_PU.Enabled = true;
            TXT_PC.Enabled = true;
        }
    }
}
