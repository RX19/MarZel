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
    public partial class FRM_GESTIONAR_VENTA : MaterialSkin.Controls.MaterialForm
    {
        Temp_Venta_Controller Temp_Venta_Controller = new Temp_Venta_Controller();
        Producto_Controller Producto_Controller = new Producto_Controller();
        Venta_Controller Venta_Controller = new Venta_Controller();
        int Id_Venta;
        int Id_Usuario;
        string Nombre_Usuario;

        public FRM_GESTIONAR_VENTA(int Id_Usuario, string Nombre_Usuario)
        {
            InitializeComponent();
            this.Id_Usuario = Id_Usuario;
            this.Nombre_Usuario = Nombre_Usuario;
        }

        public FRM_GESTIONAR_VENTA(int Id_Usuario, string Nombre_Usuario, int Id_Venta)
        {
            InitializeComponent();
            this.Id_Venta = Id_Venta;
            this.Id_Usuario = Id_Usuario;
            this.Nombre_Usuario = Nombre_Usuario;
        }

        public void Cargar_Datos_Venta()
        {
            //Actualiza los detalles de la compra.
            DataTable Detalles_Venta = Temp_Venta_Controller.Cargar_Detalles();
            dgvDetallesVenta.DataSource = null;
            dgvDetallesVenta.DataSource = Detalles_Venta;
            dgvDetallesVenta.Columns["ID_VENTA"].Visible = false;
            dgvDetallesVenta.Columns["ID_PRODUCTO"].Visible = false;
            dgvDetallesVenta.Columns["PRECIO_COMPLETO"].Visible = false;
            dgvDetallesVenta.Columns["PRECIO_UNITARIO"].Visible = false;
            dgvDetallesVenta.Columns["ID_ISV"].Visible = false;
            dgvDetallesVenta.Columns["FECHA_CREACION"].Visible = false;
            dgvDetallesVenta.ClearSelection();

            //Actualiza los resultados finales.
            DataTable Venta = Temp_Venta_Controller.Cargar_Venta();
            txtSubtotal.Text = Venta.Rows[0]["SUBTOTAL"].ToString();
            txtGravado.Text = Venta.Rows[0]["GRAVADO"].ToString();
            txtISV.Text = Venta.Rows[0]["ISV"].ToString();
            txtExento.Text = Venta.Rows[0]["EXENTO"].ToString();
            txtTotal.Text = Venta.Rows[0]["TOTAL"].ToString();

            //Actualiza el proveedor y demas campos.
            txtRTN.Text = Venta.Rows[0]["RTN"].ToString();
            txtNombre.Text = Venta.Rows[0]["NOMBRE_CLIENTE"].ToString();
            txtFactura.Text = Venta.Rows[0]["FACTURA"].ToString();
            dtpFecha.Value = Convert.ToDateTime(Venta.Rows[0]["FECHA"]);
            txtCodigoBarra.Clear();
            txtCodigoBarra.Focus();
        }

        private void Inicializar_Venta()
        {
            Temp_Venta_Controller Temp_Venta_Controller = new Temp_Venta_Controller();
            Temp_Venta_Controller.Eliminar_Registros_Temporales();
            Temp_Venta_Controller.Agregar_Venta(Id_Usuario, Nombre_Usuario, Id_Venta);
            Temp_Venta_Controller.Capturar_Detalles(Id_Venta);
            Cargar_Datos_Venta();

            if (Id_Venta == 0) btnEliminar.Visible = false;
            else btnEliminar.Visible = true;
        }

        private void FRM_GESTIONAR_VENTA_Load(object sender, EventArgs e)
        {
            Inicializar_Venta();
        }

        private void txtCodigoBarra_TextChanged(object sender, EventArgs e)
        {
            string Codigo_Barra = txtCodigoBarra.Text.Trim();
            if (Temp_Venta_Controller.Buscar_En_Detalles_Venta(Codigo_Barra))
            {
                DataTable Producto = Temp_Venta_Controller.Cargar_Producto(Codigo_Barra);
                int Existencia = Producto.Rows[0].Field<int>("EXISTENCIA");

                if (Existencia <= 0)
                {
                    MessageBox.Show("El producto esta agotado.", "Sin Existencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoBarra.Clear();
                    txtCodigoBarra.Focus();
                }
                else
                {
                    int Cantidad = Producto.Rows[0].Field<int>("CANTIDAD") + 1;
                    decimal Precio = Producto.Rows[0].Field<decimal>("PRECIO");
                    decimal Descuento = 0m;
                    decimal Importe = (Precio * Cantidad) - Descuento;
                    Existencia -= 1;
                    DateTime Fecha_Creacion = DateTime.Now;

                    Temp_Venta_Controller.Actualizar_Detalle(Codigo_Barra, Cantidad, Precio, Descuento, Importe, Existencia, Fecha_Creacion);
                }
            }
            else
            {

                if (!Temp_Venta_Controller.Buscar_En_Productos(Codigo_Barra)) return;

                DataTable Producto = Producto_Controller.Cargar_Producto(Codigo_Barra);
                int Existencia = Producto.Rows[0].Field<int>("EXISTENCIA");

                if (Existencia <= 0)
                {
                    MessageBox.Show("El producto esta agotado.", "Sin Existencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoBarra.Clear();
                    txtCodigoBarra.Focus();
                }
                else
                {
                    int Id_Producto = Producto.Rows[0].Field<int>("ID_PRODUCTO");
                    string Descripcion = Producto.Rows[0].Field<string>("DESCRIPCION") ?? "";
                    int Cantidad = 1;
                    decimal Precio_Unitario = Producto.Rows[0].Field<decimal>("PRECIO_UNITARIO");
                    decimal Precio = Precio_Unitario;
                    decimal Precio_Completo = Producto.Rows[0].Field<decimal>("PRECIO_COMPLETO");
                    int Id_ISV = Producto.Rows[0].Field<int>("ID_ISV");
                    decimal Descuento = 0m;
                    decimal Importe = (Precio * Cantidad) - Descuento;
                    Existencia -= 1;
                    DateTime Fecha_Creacion = DateTime.Now;

                    Temp_Venta_Controller.Agregar_Detalle(
                        Id_Venta, Id_Producto, Codigo_Barra, Descripcion, Cantidad, Precio, Precio_Completo,
                        Precio_Unitario, Id_ISV, Descuento, Importe, Existencia, Fecha_Creacion
                    );
                }
            }
            Cargar_Datos_Venta();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Temp_Venta_Controller.Completar_Venta();

            if (Id_Venta == 0)
            {
                Venta_Controller.Guardar_Venta();
            }
            else
            {
                Venta_Controller.Actualizar_Venta(Id_Venta);
            }
            this.Close();
        }

        private void btnRTN_Click(object sender, EventArgs e)
        {
            DataTable Cliente = Temp_Venta_Controller.Cargar_Venta();
            string Rtn = Cliente.Rows[0]["RTN"].ToString() ?? "";

            FRM_GESTIONAR_CLIENTE frm_gestionar_cliente = new FRM_GESTIONAR_CLIENTE(Rtn);
            if (frm_gestionar_cliente.ShowDialog() == DialogResult.OK)
                Cargar_Datos_Venta();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Desea eliminar esta venta?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;
            Venta_Controller.Eliminar_Venta(Id_Venta);
            this.Close();
        }

        private void dgvDetallesVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetallesVenta.Columns[e.ColumnIndex].Name == "Editar" && e.RowIndex >= 0)
            {
                string CodigoBarra = dgvDetallesVenta.Rows[e.RowIndex].Cells["CODIGO_BARRA"].Value.ToString() ?? "";
                FRM_GESTIONAR_PRODUCTO_VENTA frm_gestionar_producto_venta = new FRM_GESTIONAR_PRODUCTO_VENTA(CodigoBarra, Id_Venta);
                frm_gestionar_producto_venta.ShowDialog();
                Cargar_Datos_Venta();
            }
        }
    }
}
