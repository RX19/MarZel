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
        int? Id_Proveedor = null;
        //Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();
        //private Proveedor? proveedorActual = null;
        //private Temp_Compra? compraActual = null;
        //private Proveedor? proveedorSeleccionado = null;*/

        public FRM_GESTIONAR_PROVEEDOR()
        {
            InitializeComponent();
        }

        public FRM_GESTIONAR_PROVEEDOR(int Id_Proveedor)
        {
            InitializeComponent();
            this.Id_Proveedor = Id_Proveedor;
            DataTable Proveedor = Proveedor_Controller.Cargar_Proveedor(Id_Proveedor);
            txtRTN.Text = Proveedor.Rows[0]["RTN"].ToString();
            txtNombre.Text = Proveedor.Rows[0]["NOMBRE"].ToString();
            txtDireccion.Text = Proveedor.Rows[0]["DIRECCION"].ToString();
            txtCelular.Text = Proveedor.Rows[0]["CELULAR"].ToString();

            //DataTable Proveedor = Proveedor_Controller.Cargar_Proveedor(rtn);
        }

        public FRM_GESTIONAR_PROVEEDOR(string rtn)
        {
            InitializeComponent();
            //DataTable Proveedor = Proveedor_Controller.Cargar_Proveedor(rtn);
        }

        private void FRM_GESTIONAR_PROVEEDOR_Load(object sender, EventArgs e)
        {
            /*if (elegir) { btnGuardar.Text = "ELEGIR"; }
            else { btnGuardar.Text = "GUARDAR"; }*/
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

            /*if (proveedorActual == null && compraActual == null)
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
            }*/

            return true;
        }
   
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Verificar_Campos()) return;

            DialogResult result = MessageBox.Show(
            "¿Desea guardar los cambios?", "Confirmación",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            string RTN = txtRTN.Text.Trim();
            string Nombre = txtNombre.Text.Trim();
            string Direccion = txtDireccion.Text.Trim();
            string Celular = txtCelular.Text.Trim();

            if (Id_Proveedor == null)
            {
                Proveedor_Controller.Agregar_Proveedor(RTN, Nombre, Direccion, Celular, 0, 0);
            }
            else
            {
                Proveedor_Controller.Modificar_Proveedor(Id_Proveedor.Value, RTN, Nombre, Direccion, Celular);
            }
            /*}
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
            }*/
            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        /*
        private void Limpiar_Campos()
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCelular.Clear();
        }

        private void txtRTN_TextChanged(object sender, EventArgs e)
        {
            /*if (compraActual == null) return;

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
        */
        }
    }