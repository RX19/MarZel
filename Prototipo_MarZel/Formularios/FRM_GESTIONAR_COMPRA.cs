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
        private Compra CompraActual = new Compra { ID_COMPRA = 0 };

        private readonly Categoria_Producto_Controller Categoria_Producto_Controller = new Categoria_Producto_Controller();
        private List<Categoria_Producto> Categorias = new List<Categoria_Producto>();

        private readonly Tipo_ISV_Controller Tipo_ISV_Controller = new Tipo_ISV_Controller();
        private List<Tipo_ISV> Tipos_ISV = new List<Tipo_ISV>();

        private readonly Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();
        private List<Temp_Detalle_Compra> Detalles_Compra = new List<Temp_Detalle_Compra>();

        private readonly Producto_Controller Producto_controller = new Producto_Controller();

        public FRM_GESTIONAR_COMPRA()
        {
            InitializeComponent();
        }

        public FRM_GESTIONAR_COMPRA(Compra Compra)
        {
            InitializeComponent();
            CompraActual = Compra;
        }

        private void Cargar_Categorias()
        {
            Categorias = Categoria_Producto_Controller.Cargar_Categorias();
            cmbCategorias.DataSource = null;
            Categorias.Insert(0, new Categoria_Producto { ID_CATEGORIA = 0, DESCRIPCION = "-- Seleccionar categoría --" });
            cmbCategorias.DataSource = Categorias;
            cmbCategorias.DisplayMember = "DESCRIPCION";
            cmbCategorias.ValueMember = "ID_CATEGORIA";
            cmbCategorias.SelectedIndex = 0;
        }

        private void Cargar_Tipos_ISV()
        {
            Tipos_ISV = Tipo_ISV_Controller.Cargar_Tipos_ISV();
            cmbTiposISV.DataSource = null;
            Tipos_ISV.Insert(0, new Tipo_ISV { ID_TIPO = 0, DESCRIPCION = "-- Seleccionar categoría --" });
            cmbTiposISV.DataSource = Tipos_ISV;
            cmbTiposISV.DisplayMember = "DESCRIPCION";
            cmbTiposISV.ValueMember = "ID_TIPO";
            cmbTiposISV.SelectedIndex = 0;
        }

        public void Cargar_Detalles(int Id_Compra)
        {
            Detalles_Compra = Temp_Compra_Controller.Cargar_Detalles(Id_Compra);
            dgvDetallesCompra.DataSource = null;
            dgvDetallesCompra.DataSource = Detalles_Compra;
            dgvDetallesCompra.ClearSelection();
        }

        public void Mostrar_Calculos(int Id_Compra)
        {
            Temp_Compra Compra = Temp_Compra_Controller.Mostrar_Calculos(Id_Compra);

            if (Compra != null)
            {
                txtSubtotal.Text = Compra.SUBTOTAL.ToString();
                txtGravado.Text = Compra.GRAVADO.ToString();
                txtISV.Text = Compra.ISV.ToString();
                txtExento.Text = Compra.EXENTO.ToString();
                txtTotal.Text = Compra.TOTAL.ToString();
            }
        }

        private void FRM_GESTIONAR_COMPRA_Load(object sender, EventArgs e)
        {
            Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();
            Temp_Compra_Controller.Eliminar_Registros_Temporales();
            Cargar_Categorias();
            Cargar_Tipos_ISV();
            Temp_Compra_Controller.Agregar_Compra(CompraActual);
            Temp_Compra_Controller.Capturar_Detalles(CompraActual.ID_COMPRA);
            Cargar_Detalles(CompraActual.ID_COMPRA);
            Mostrar_Calculos(CompraActual.ID_COMPRA);
            txtDescuento.Text = "0.00";
            txtImporte.Text = "0.00";
            txtCodigoBarra.Focus();
        }

        


        









        private void Limpiar_Campos()
        {
            txtDescripcion.Clear();
            txtCantidad.Clear();
            txtCosto.Clear();
            txtDescuento.Text = "0.00";
            txtImporte.Text = "0.00";
            cmbTiposISV.SelectedIndex = 0;
            txtPrecioCompleto.Clear();
            txtPrecioUnitario.Clear();
            cmbCategorias.SelectedIndex = 0;
            dgvDetallesCompra.ClearSelection();
            txtCodigoBarra.Focus();
        }

        private void txtCodigoBarra_TextChanged(object sender, EventArgs e)
        {
            if (Temp_Compra_Controller.Buscar_En_Detalles_Compra(txtCodigoBarra.Text))
            {
                Temp_Detalle_Compra Producto = Temp_Compra_Controller.Cargar_Producto(txtCodigoBarra.Text);

                if (Producto != null)
                {
                    txtDescripcion.Text = Producto.DESCRIPCION;
                    txtCosto.Text = Producto.COSTO.ToString();
                    cmbTiposISV.SelectedValue = Producto.ID_ISV;
                    txtPrecioCompleto.Text = Producto.PRECIO_COMPLETO.ToString();
                    txtPrecioUnitario.Text = Producto.PRECIO_UNITARIO.ToString();
                    cmbCategorias.SelectedValue = Producto.ID_CATEGORIA;
                }
            }
            else
            {

                if (Temp_Compra_Controller.Buscar_En_Productos(txtCodigoBarra.Text))
                {
                    Producto Producto = Producto_controller.Cargar_Producto(txtCodigoBarra.Text);

                    if (Producto != null)
                    {
                        txtDescripcion.Text = Producto.DESCRIPCION;
                        cmbTiposISV.SelectedValue = Producto.ID_ISV;
                        txtPrecioCompleto.Text = Producto.PRECIO_COMPLETO.ToString();
                        txtPrecioUnitario.Text = Producto.PRECIO_UNITARIO.ToString();
                        cmbCategorias.SelectedValue = Producto.ID_CATEGORIA;
                    }
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

        private bool Verificar_Campos()
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
            if (!Verificar_Campos()) return;

            if (Temp_Compra_Controller.Buscar_En_Detalles_Compra(txtCodigoBarra.Text))
            {
                MessageBox.Show("Esta en Temp.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {

                if (Temp_Compra_Controller.Buscar_En_Productos(txtCodigoBarra.Text))
                {
                    MessageBox.Show("No esta en Temp pero, si en Productos ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                   Temp_Detalle_Compra Detalle_Compra = new Temp_Detalle_Compra
                    {
                        ID_COMPRA = 0,
                        ID_PRODUCTO = null,
                        CODIGO_BARRA = txtCodigoBarra.Text,
                        DESCRIPCION = txtDescripcion.Text,
                        CANTIDAD = int.Parse(txtCantidad.Text),
                        COSTO = decimal.Parse(txtCosto.Text),
                        ID_ISV = (cmbTiposISV.SelectedItem as Tipo_ISV).ID_TIPO,
                        DESCUENTO = decimal.Parse(txtDescuento.Text),
                        IMPORTE = decimal.Parse(txtImporte.Text),
                        PRECIO_COMPLETO = decimal.Parse(txtPrecioCompleto.Text),
                        PRECIO_UNITARIO = decimal.Parse(txtPrecioUnitario.Text),
                        ID_CATEGORIA = (cmbCategorias.SelectedItem as Categoria_Producto).ID_CATEGORIA,
                        FECHA_CREACION = DateTime.Now
                    };
                    Temp_Compra_Controller.Agregar_Nuevo_Detalle(Detalle_Compra);
                    Cargar_Detalles(CompraActual.ID_COMPRA);
                    txtCodigoBarra.Clear();
                    Limpiar_Campos();
                }
            }
        }
    }
}