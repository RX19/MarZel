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

        public FRM_GESTIONAR_PROVEEDOR()
        {
            InitializeComponent();
            this.Hide();
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

        private async void GESTIONAR_PROVEEDOR_Load(object sender, EventArgs e)
        {
            await FadeInAsync(this);
            this.Opacity = 1.0;
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
            else if (nombre == string.Empty) 
            {
                MessageBox.Show("El Campo Nombre es obligatorio. Por favor, complete el campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (proveedorController.VerificarRTN(rtn))
            {
                MessageBox.Show("El R.T.N. ingresado ya existe. Por favor, ingrese un R.T.N. diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (verificarCampos())
            {
                DialogResult result = MessageBox.Show(
                    "¿Desea guardar los cambios?", "Confirmación", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
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

                    MessageBox.Show("Proveedor guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    proveedorController.AgregarProveedor(nuevoProveedor);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            
        }
    }
}
