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
        ProveedorController proveedorController = new ProveedorController();
        private Proveedor? proveedorActual = null; 
        
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

        private bool verificarCampos()
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

            if (proveedorActual == null)
            {
                if (proveedorController.VerificarRTN(rtn))
                {
                    MessageBox.Show("El R.T.N. ingresado ya existe. Por favor, ingrese un R.T.N. diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }      
            } 
            else
            {
                if (rtn != proveedorActual.RTN && proveedorController.VerificarRTN(rtn))
                {
                    MessageBox.Show("El R.T.N. ingresado ya existe. Por favor, ingrese un R.T.N. diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!verificarCampos()) return;
            
            DialogResult result = MessageBox.Show(
                "¿Desea guardar los cambios?", "Confirmación", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes)return;

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

                proveedorController.AgregarProveedor(nuevoProveedor);

            } else {

                proveedorActual.RTN = txtRTN.Text.Trim();
                proveedorActual.NOMBRE = txtNombre.Text.Trim();
                proveedorActual.DIRECCION = txtDireccion.Text.Trim();
                proveedorActual.CELULAR = txtCelular.Text.Trim();
                    
                proveedorController.ActualizarProveedor(proveedorActual);

            }
                
            this.DialogResult = DialogResult.OK;
            this.Close();
                
        }

    }
}
