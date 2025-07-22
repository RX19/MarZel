using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototipo_MarZel.Formularios
{
    public partial class FRM_GESTIONAR_PROVEEDOR : MaterialSkin.Controls.MaterialForm
    {
        Proveedor_Controller Proveedor_Controller = new Proveedor_Controller();
        Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();

        private Proveedor? proveedorActual = null;
        private Temp_Compra? compraActual = null;
        private Proveedor? proveedorSeleccionado = null;

        public FRM_GESTIONAR_PROVEEDOR()
        {
            InitializeComponent();
        }

        public FRM_GESTIONAR_PROVEEDOR(Proveedor proveedor)
        {
            InitializeComponent();
            proveedorActual = proveedor;
            txtRTN.Text = proveedor.RTN;
            txtNombre.Text = proveedor.NOMBRE;
            txtDireccion.Text = proveedor.DIRECCION;
            txtCelular.Text = proveedor.CELULAR;
        }

        public FRM_GESTIONAR_PROVEEDOR(Temp_Compra Compra)
        {
            InitializeComponent();
            compraActual = Compra;
            txtRTN.Text = Compra.RTN;
            txtNombre.Text = Compra.NOMBRE;
            txtDireccion.Text = Compra.DIRECCION;
            txtCelular.Text = Compra.CELULAR;
        }

        private bool Verificar_Campos()
        {

            string rtn = txtRTN.Text.Trim();
            string nombre = txtNombre.Text.Trim();

            if (rtn == string.Empty)
            {
                MessageBox.Show("El Campo R.T.N. es obligatorio. Por favor, complete el campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nombre == string.Empty)
            {
                MessageBox.Show("El Campo Nombre es obligatorio. Por favor, complete el campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (proveedorActual == null && compraActual == null)
            {
                if (Proveedor_Controller.Existe_RTN(rtn))
                {
                    MessageBox.Show("El R.T.N. ingresado ya existe. Por favor, ingrese un R.T.N. diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                if ((rtn != null || rtn != proveedorSeleccionado.RTN) && Proveedor_Controller.Existe_RTN(rtn))
                {
                    MessageBox.Show("El R.T.N. ingresado ya existe. Por favor, ingrese un R.T.N. diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Verificar_Campos()) return;

            if (compraActual == null)
            {
                DialogResult result = MessageBox.Show(
                "¿Desea guardar los cambios?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes) return;

                if (proveedorActual == null)
                {
                    Proveedor nuevoProveedor = new Proveedor
                    {
                        RTN = txtRTN.Text.Trim(),
                        NOMBRE = txtNombre.Text.Trim(),
                        DIRECCION = txtDireccion.Text.Trim(),
                        CELULAR = txtCelular.Text.Trim(),
                        CANT_COMPRAS = 0,
                        IMPORTE = 0.00m
                    };

                    Proveedor_Controller.Agregar_Proveedor(nuevoProveedor);

                }
                else
                {

                    proveedorActual.RTN = txtRTN.Text.Trim();
                    proveedorActual.NOMBRE = txtNombre.Text.Trim();
                    proveedorActual.DIRECCION = txtDireccion.Text.Trim();
                    proveedorActual.CELULAR = txtCelular.Text.Trim();

                    Proveedor_Controller.Actualizar_Proveedor(proveedorActual);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(
                "¿Desea cambiar de proveedor?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes) return; 
                
                Temp_Compra compra = new Temp_Compra
                {
                    ID_PROVEEDOR = proveedorSeleccionado?.ID_PROVEEDOR,
                    RTN = txtRTN.Text.Trim(),
                    NOMBRE = txtNombre.Text.Trim(),
                    DIRECCION = txtDireccion.Text.Trim(),
                    CELULAR = txtCelular.Text.Trim()
                };
                Temp_Compra_Controller.Actualizar_Proveedor(compra);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Limpiar_Campos()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCelular.Clear();
        }

        private void txtRTN_TextChanged(object sender, EventArgs e)
        {
            if (compraActual == null) return;

            proveedorSeleccionado = Proveedor_Controller.Cargar_Proveedor(txtRTN.Text.Trim());

            if (proveedorSeleccionado != null)
            {
                txtNombre.Text = proveedorSeleccionado.NOMBRE;
                txtDireccion.Text = proveedorSeleccionado.DIRECCION;
                txtCelular.Text = proveedorSeleccionado.CELULAR;
            }
            else
            {
                Limpiar_Campos();
            }
        }

        private void FRM_GESTIONAR_PROVEEDOR_Load(object sender, EventArgs e)
        {
            if (compraActual == null)
            {
               btnGuardar.Text = "GUARDAR";
            }
            else
            {
                btnGuardar.Text = "ELEGIR";
            }
        }
    }
}
