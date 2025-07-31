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
    public partial class FRM_GESTIONAR_PRODUCTO_VENTA : MaterialSkin.Controls.MaterialForm
    {
        Tipo_ISV_Controller Tipo_ISV_Controller = new Tipo_ISV_Controller();
        Temp_Venta_Controller Temp_Venta_Controller = new Temp_Venta_Controller();
        string Codigo_Barra = string.Empty;
        int Id_Venta, Id_Producto, Existencia;

        public FRM_GESTIONAR_PRODUCTO_VENTA(string Codigo_Barra, int Id_Venta)
        {
            InitializeComponent();
            this.Codigo_Barra = Codigo_Barra;
            this.Id_Venta = Id_Venta;
        }

        private void Cargar_Tipos_ISV()
        {
            DataTable Tipos_ISV = Tipo_ISV_Controller.Cargar_Tipos_ISV();
            cmbTiposISV.DataSource = null;
            cmbTiposISV.DataSource = Tipos_ISV;
            cmbTiposISV.DisplayMember = "DESCRIPCION";
            cmbTiposISV.ValueMember = "ID_ISV";
        }

        private void Capturar_Valores_Originales()
        {
            Cargar_Tipos_ISV();
            DataTable Producto = Temp_Venta_Controller.Cargar_Producto(Codigo_Barra);
            Id_Producto = Convert.ToInt32(Producto.Rows[0]["ID_PRODUCTO"]);
            txtCodigoBarra.Text = Producto.Rows[0]["Codigo_Barra"].ToString();
            txtDescripcion.Text = Producto.Rows[0]["Descripcion"].ToString();
            txtPrecio.Text = Convert.ToDecimal(Producto.Rows[0]["Precio"]).ToString("0.00");
            txtCantidad.Text = Convert.ToInt32(Producto.Rows[0]["Cantidad"]).ToString();
            txtDescuento.Text = Convert.ToDecimal(Producto.Rows[0]["Descuento"]).ToString("0.00");
            txtImporte.Text = Convert.ToDecimal(Producto.Rows[0]["Importe"]).ToString("0.00");
            cmbTiposISV.SelectedValue = Convert.ToInt32(Producto.Rows[0]["ID_ISV"]);
            cmbTiposISV.Invalidate();
            Existencia = Convert.ToInt32(Producto.Rows[0]["Existencia"]) + Convert.ToInt32(Producto.Rows[0]["Cantidad"]);

            decimal precio = Convert.ToDecimal(Producto.Rows[0]["Precio"]);
            decimal precioUnitario = Convert.ToDecimal(Producto.Rows[0]["Precio_Unitario"]);
            if (precio == precioUnitario)
            {
                optPrecioUnitario.Checked = true;
            }
            else
            {
                optPrecioCompleto.Checked = true;
            }
        }

        private void FRM_GESTIONAR_PRODUCTO_VENTA_Load(object sender, EventArgs e)
        {
            Capturar_Valores_Originales();
        }

        private void Calcular_Importe(decimal precio)
        {
            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                txtImporte.Text = "0.00";
                return;
            }

            int cantidad = Convert.ToInt32(txtCantidad.Text);
            decimal descuento = Convert.ToDecimal(txtDescuento.Text);
            txtPrecio.Text = precio.ToString("0.00");
            txtImporte.Text = ((cantidad * precio) - descuento).ToString("0.00");
        }

        private void optPrecioUnitario_CheckedChanged(object sender, EventArgs e)
        {
            DataTable Producto = Temp_Venta_Controller.Cargar_Producto(Codigo_Barra);
            decimal precio = Convert.ToDecimal(Producto.Rows[0]["Precio_Unitario"]);
            Calcular_Importe(precio);
        }

        private void optPrecioCompleto_CheckedChanged(object sender, EventArgs e)
        {
            DataTable Producto = Temp_Venta_Controller.Cargar_Producto(Codigo_Barra);
            decimal precio = Convert.ToDecimal(Producto.Rows[0]["Precio_Completo"]);
            Calcular_Importe(precio);
        }

        private bool Verificar_Campos_Detalles()
        {

            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out int cantidad) || cantidad == 0)
            {
                MessageBox.Show("Debe ingresar una cantidad válida mayor a 0 y que sea un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescuento.Text) || !decimal.TryParse(txtDescuento.Text, out decimal descuento) || descuento < 0)
            {
                MessageBox.Show("Debe ingresar un descuento válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescuento.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtImporte.Text) || !decimal.TryParse(txtImporte.Text, out decimal importe) || importe < 0)
            {
                MessageBox.Show("Debe ingresar un importe válido mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtImporte.Focus();
                return false;
            }

            if (Existencia < cantidad)
            {
                MessageBox.Show($"No hay suficiente existencia. Cantidad Máxima: {Existencia}", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Verificar_Campos_Detalles()) return;

            int Cantidad = int.Parse(txtCantidad.Text.Trim());
            decimal Precio = decimal.Parse(txtPrecio.Text.Trim());
            decimal Descuento = decimal.Parse(txtDescuento.Text.Trim());
            decimal Importe = decimal.Parse(txtImporte.Text.Trim());
            Existencia -= Cantidad;

            Temp_Venta_Controller.Modificar_Detalle(Id_Venta, Id_Producto, Cantidad, Precio,
                Descuento, Importe, Existencia, DateTime.Now);
            this.Close();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Calcular_Importe(Convert.ToDecimal(txtPrecio.Text));
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            Calcular_Importe(Convert.ToDecimal(txtPrecio.Text));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Desea eliminar este producto?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;
            Temp_Venta_Controller.Eliminar_Detalle(Codigo_Barra);
            this.Close();
        }
    }
}
