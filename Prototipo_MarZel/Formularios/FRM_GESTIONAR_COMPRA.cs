using Org.BouncyCastle.Asn1.X500;
using Prototipo_MarZel.Recursos.Modelos;
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
    public partial class FRM_GESTIONAR_COMPRA : MaterialSkin.Controls.MaterialForm
    {
        private int Id_Compra = 0;

        private readonly Categoria_Producto_Controller Categoria_Producto_Controller = new Categoria_Producto_Controller();
        private readonly Tipo_ISV_Controller Tipo_ISV_Controller = new Tipo_ISV_Controller();
        private readonly Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();
        private readonly Producto_Controller Producto_Controller = new Producto_Controller();
        private readonly Compra_Controller Compra_Controller = new Compra_Controller();

        public FRM_GESTIONAR_COMPRA()
        {
            InitializeComponent();
        }

        public FRM_GESTIONAR_COMPRA(int Id_Compra)
        {
            InitializeComponent();
            this.Id_Compra = Id_Compra;
        }

        private void Cargar_Categorias()
        {
            DataTable Categorias = Categoria_Producto_Controller.Cargar_Categorias();
            DataRow row = Categorias.NewRow();
            row["ID_CATEGORIA"] = 0;
            row["DESCRIPCION"] = "-- Seleccionar categoría --";
            Categorias.Rows.InsertAt(row, 0);
            cmbCategorias.DataSource = null;
            cmbCategorias.DataSource = Categorias;
            cmbCategorias.DisplayMember = "DESCRIPCION";
            cmbCategorias.ValueMember = "ID_CATEGORIA";
            cmbCategorias.SelectedIndex = 0;
        }

        private void Cargar_Tipos_ISV()
        {
            DataTable Tipos_ISV = Tipo_ISV_Controller.Cargar_Tipos_ISV();
            DataRow row = Tipos_ISV.NewRow();
            row["ID_ISV"] = 0;
            row["DESCRIPCION"] = "-- Seleccionar categoría --";
            Tipos_ISV.Rows.InsertAt(row, 0);
            cmbTiposISV.DataSource = null;
            cmbTiposISV.DataSource = Tipos_ISV;
            cmbTiposISV.DisplayMember = "DESCRIPCION";
            cmbTiposISV.ValueMember = "ID_ISV";
            cmbTiposISV.SelectedIndex = 0;
        }

        private void Limpiar_Campos()
        {
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtCosto.Clear();
            txtDescuento.Text = "0.00";
            txtImporte.Text = "0.00";
            cmbTiposISV.SelectedIndex = 0;
            cmbTiposISV.Invalidate();
            txtPrecioCompleto.Clear();
            txtPrecioUnitario.Clear();
            cmbCategorias.SelectedIndex = 0;
            cmbCategorias.Invalidate();
            dgvDetallesCompra.ClearSelection();
            txtCodigoBarra.Focus();
        }

        public void Cargar_Datos_Compra()
        {
            //Actualiza los detalles de la compra.
            DataTable Detalles_Compra = Temp_Compra_Controller.Cargar_Detalles();
            dgvDetallesCompra.DataSource = null;
            dgvDetallesCompra.DataSource = Detalles_Compra;
            dgvDetallesCompra.ClearSelection();

            //Actualiza los resultados finales.
            DataTable compra = Temp_Compra_Controller.Cargar_Compra();
            txtSubtotal.Text = compra.Rows[0]["SUBTOTAL"].ToString();
            txtGravado.Text = compra.Rows[0]["GRAVADO"].ToString();
            txtISV.Text = compra.Rows[0]["ISV"].ToString();
            txtExento.Text = compra.Rows[0]["EXENTO"].ToString();
            txtTotal.Text = compra.Rows[0]["TOTAL"].ToString();

            //Actualiza el proveedor y demas campos.

            txtNombre.Text = compra.Rows[0]["NOMBRE"].ToString();
            txtFactura.Text = compra.Rows[0]["FACTURA"].ToString();
            dtpFecha.Value = Convert.ToDateTime(compra.Rows[0]["FECHA"]);
            txtCodigoBarra.Clear();
            Limpiar_Campos();
        }

        private void Inicializar_Compra()
        {
            Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();
            Temp_Compra_Controller.Eliminar_Registros_Temporales();
            Temp_Compra_Controller.Agregar_Compra(Id_Compra);
            Temp_Compra_Controller.Capturar_Detalles(Id_Compra);
            Cargar_Categorias();
            Cargar_Tipos_ISV();
            Cargar_Datos_Compra();
        }

        private void FRM_GESTIONAR_COMPRA_Load(object sender, EventArgs e)
        {
            Inicializar_Compra();
        }

        private void txtCodigoBarra_TextChanged(object sender, EventArgs e)
        {
            string Codigo_Barra = txtCodigoBarra.Text.Trim();
            if (Temp_Compra_Controller.Buscar_En_Detalles_Compra(Codigo_Barra))
            {
                DataTable Producto = Temp_Compra_Controller.Cargar_Producto(Codigo_Barra);
                txtDescripcion.Text = Producto.Rows[0]["DESCRIPCION"].ToString();
                txtCosto.Text = Producto.Rows[0]["COSTO"].ToString();
                cmbTiposISV.SelectedValue = Producto.Rows[0]["ID_ISV"];
                cmbTiposISV.Invalidate();
                txtPrecioCompleto.Text = Producto.Rows[0]["PRECIO_COMPLETO"].ToString();
                txtPrecioUnitario.Text = Producto.Rows[0]["PRECIO_UNITARIO"].ToString();
                cmbCategorias.SelectedValue = Producto.Rows[0]["ID_CATEGORIA"];
                cmbCategorias.Invalidate();
            }
            else
            {

                if (Temp_Compra_Controller.Buscar_En_Productos(Codigo_Barra))
                {
                    DataTable Producto = Producto_Controller.Cargar_Producto(Codigo_Barra);
                    txtDescripcion.Text = Producto.Rows[0]["DESCRIPCION"].ToString();
                    cmbTiposISV.SelectedValue = Producto.Rows[0]["ID_ISV"];
                    cmbTiposISV.Invalidate();
                    txtPrecioCompleto.Text = Producto.Rows[0]["PRECIO_COMPLETO"].ToString();
                    txtPrecioUnitario.Text = Producto.Rows[0]["PRECIO_UNITARIO"].ToString();
                    cmbCategorias.SelectedValue = Producto.Rows[0]["ID_CATEGORIA"];
                    cmbCategorias.Invalidate();
                }
                else
                {
                    Limpiar_Campos();
                }
            }
        }

        private void Calcular_Importe()
        {
            if (decimal.TryParse(txtCosto.Text, out decimal costo)
            && decimal.TryParse(txtDescuento.Text, out decimal descuento)
            && int.TryParse(txtCantidad.Text, out int cantidad))
            {
                decimal importe = (costo * cantidad) - descuento;
                txtImporte.Text = importe.ToString("0.00");
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Calcular_Importe();
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            Calcular_Importe();
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            Calcular_Importe();
        }

        private bool Verificar_Campos_Detalles()
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

            if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out int cantidad) || cantidad == 0)
            {
                MessageBox.Show("Debe ingresar una cantidad válida mayor a 0 y que sea un número entero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCantidad.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCosto.Text) || !decimal.TryParse(txtCosto.Text, out decimal costo) || costo == 0)
            {
                MessageBox.Show("Debe ingresar un costo válido mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCosto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDescuento.Text) || !decimal.TryParse(txtDescuento.Text, out _))
            {
                MessageBox.Show("Debe ingresar un descuento válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescuento.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtImporte.Text) || !decimal.TryParse(txtImporte.Text, out decimal importe) || importe == 0)
            {
                MessageBox.Show("Debe ingresar un importe válido mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtImporte.Focus();
                return false;
            }

            if (cmbTiposISV.SelectedIndex <= 0)
            {
                MessageBox.Show("Debe seleccionar un tipo de ISV.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbTiposISV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioCompleto.Text) || !decimal.TryParse(txtPrecioCompleto.Text, out decimal precio_comp) || precio_comp == 0)
            {
                MessageBox.Show("Debe ingresar un precio completo válido mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioCompleto.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPrecioUnitario.Text) || !decimal.TryParse(txtPrecioUnitario.Text, out decimal precio_unit) || precio_unit == 0)
            {
                MessageBox.Show("Debe ingresar un precio unitario válido mayor a 0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecioUnitario.Focus();
                return false;
            }

            if (cmbCategorias.SelectedIndex <= 0)
            {
                MessageBox.Show("Debe seleccionar una categoría.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCategorias.Focus();
                return false;
            }

            return true;
        }

        private void txtAgregarDetalle_Click(object sender, EventArgs e)
        {
            if (!Verificar_Campos_Detalles()) return;

            string Codigo_Barra = txtCodigoBarra.Text.Trim();
            int? Id_Producto = Producto_Controller.Buscar_Id_Producto(Codigo_Barra);
            string Descripcion = txtDescripcion.Text.Trim();
            int Cantidad = int.Parse(txtCantidad.Text.Trim());
            decimal Costo = decimal.Parse(txtCosto.Text.Trim());
            decimal Descuento = decimal.Parse(txtDescuento.Text.Trim());
            decimal Importe = decimal.Parse(txtImporte.Text.Trim());
            int Id_ISV = Convert.ToInt32(cmbTiposISV.SelectedValue);
            decimal Precio_Completo = decimal.Parse(txtPrecioCompleto.Text.Trim());
            decimal Precio_Unitario = decimal.Parse(txtPrecioUnitario.Text.Trim());
            int Id_Categoria = Convert.ToInt32(cmbCategorias.SelectedValue);
            DateTime Fecha_Creacion = DateTime.Now;

            Temp_Compra_Controller.Agregar_Detalle(
                Id_Compra, Id_Producto, Codigo_Barra, Descripcion, Cantidad, Costo, Descuento,
                Importe, Id_ISV, Precio_Completo, Precio_Unitario, Id_Categoria, Fecha_Creacion
            );

            Cargar_Datos_Compra();

        }

        private void btnRTN_Click(object sender, EventArgs e)
        {
            DataTable Proveedor = Temp_Compra_Controller.Cargar_Compra();
            string rtn = Proveedor.Rows[0]["RTN"].ToString() ?? "";

            FRM_GESTIONAR_PROVEEDOR frm_gestionar_proveedor = new FRM_GESTIONAR_PROVEEDOR(rtn);
            if (frm_gestionar_proveedor.ShowDialog() == DialogResult.OK)
                Cargar_Datos_Compra();
        }

        private bool Verificar_Campos_Compra()
        {
            string Nombre = txtNombre.Text.Trim();
            string Factura = txtFactura.Text.Trim();

            DataTable Detalles = Temp_Compra_Controller.Cargar_Detalles();
            if (Detalles.Rows.Count == 0)
            {
                MessageBox.Show("Debe ingresar al menos un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBarra.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(Nombre))
            {
                MessageBox.Show("Debe ingresar un Proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FRM_GESTIONAR_PROVEEDOR frm_gestionar_proveedor = new FRM_GESTIONAR_PROVEEDOR(string.Empty);
                if (frm_gestionar_proveedor.ShowDialog() == DialogResult.OK)
                    Cargar_Datos_Compra();
                return false;
            }

            if (string.IsNullOrWhiteSpace(Factura))
            {
                MessageBox.Show("Debe ingresar un número de factura.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFactura.Focus();
                return false;
            }

            if (Id_Compra == 0)
            {
                if (Temp_Compra_Controller.Existe_Factura(Factura))
                {
                    MessageBox.Show("La factura ingresada ya existe. Por favor, ingrese una factura diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFactura.Focus();
                    return false;
                }
            }
            else
            {
                DataTable Compra = Temp_Compra_Controller.Cargar_Compra();
                if (Temp_Compra_Controller.Existe_Factura(Factura) && Factura != Compra.Rows[0]["Factura"].ToString())
                {
                    MessageBox.Show("La factura ingresada ya existe. Por favor, ingrese una factura diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtFactura.Focus();
                    return false;
                }
            }


            return true;
        }

        private void Completar_Compra()
        {
            string Factura = txtFactura.Text;
            DateTime Fecha = dtpFecha.Value;
            Temp_Compra_Controller.Completar_Compra(Id_Compra, Factura, Fecha);
            Cargar_Datos_Compra();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Verificar_Campos_Compra()) return;
            Completar_Compra();

            if (Id_Compra == 0)
            {
                Compra_Controller.Agregar_Compra();
            }
            else
            {
                Compra_Controller.Actualizar_Compra(Id_Compra);
            }
            this.Close();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            Completar_Compra();
        }
    }
}