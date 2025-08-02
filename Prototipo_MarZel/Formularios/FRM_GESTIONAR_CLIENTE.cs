using Org.BouncyCastle.Asn1.X500;
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
    public partial class FRM_GESTIONAR_CLIENTE : MaterialSkin.Controls.MaterialForm
    {
        Cliente_Controller Cliente_Controller = new Cliente_Controller();
        Temp_Venta_Controller Temp_Venta_Controller = new Temp_Venta_Controller();
        bool Elegir = false;
        int? Id_Cliente = null;

        public FRM_GESTIONAR_CLIENTE()
        {
            InitializeComponent();
        }

        public FRM_GESTIONAR_CLIENTE(int Id_Cliente)
        {
            InitializeComponent();
            this.Id_Cliente = Id_Cliente;
            DataTable Cliente = Cliente_Controller.Cargar_Cliente(Id_Cliente);
            txtRTN.Text = Cliente.Rows[0]["RTN"].ToString();
            txtNombre.Text = Cliente.Rows[0]["NOMBRE"].ToString();
            txtDireccion.Text = Cliente.Rows[0]["DIRECCION"].ToString();
            txtCelular.Text = Cliente.Rows[0]["CELULAR"].ToString();
        }

        public FRM_GESTIONAR_CLIENTE(string RTN)
        {
            InitializeComponent();
            Elegir = true;
            if (RTN == "N/A")
            {
                chkSinRTN.Checked = true;
            }
            else
            {
                txtRTN.Text = RTN;
            }
        }

        private void FRM_GESTIONAR_CLIENTE_Load(object sender, EventArgs e)
        {
            if (Elegir) { btnGuardar.Text = "ELEGIR"; chkSinRTN.Visible = true; }
            else { btnGuardar.Text = "GUARDAR"; chkSinRTN.Visible = false; }
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

            if (!Elegir)
            {
                if (Id_Cliente == null)
                {
                    if (Cliente_Controller.Existe_RTN(rtn))
                    {
                        MessageBox.Show("El R.T.N. ingresado ya existe. Por favor, ingrese un R.T.N. diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    DataTable Cliente = Cliente_Controller.Cargar_Cliente(Id_Cliente.Value);
                    if (Cliente_Controller.Existe_RTN(rtn) && rtn != Cliente.Rows[0]["RTN"].ToString())
                    {
                        MessageBox.Show("El R.T.N. ingresado ya existe. Por favor, ingrese un R.T.N. diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!Verificar_Campos()) return;

            string Rtn = txtRTN.Text.Trim();
            string Nombre = txtNombre.Text.Trim();
            string Direccion = txtDireccion.Text.Trim();
            string Celular = txtCelular.Text.Trim();

            if (!Elegir)
            {
                DialogResult result = MessageBox.Show(
                "¿Desea guardar los cambios?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes) return;

                if (Id_Cliente == null)
                {
                    Cliente_Controller.Agregar_Cliente(Rtn, Nombre, Direccion, Celular, 0, 0);
                }
                else
                {
                    Cliente_Controller.Modificar_Cliente(Id_Cliente.Value, Rtn, Nombre, Direccion, Celular);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(
                "¿Desea cambiar de cliente?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes) return;

                DataTable Cliente = Cliente_Controller.Cargar_Cliente(Rtn);
                int? Id_Cliente = null;
                if (Cliente.Rows.Count > 0)
                    Id_Cliente = Convert.ToInt32(Cliente.Rows[0]["ID_CLIENTE"]);
                Temp_Venta_Controller.Modificar_Cliente(Id_Cliente, Rtn, Nombre, Direccion, Celular);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtRTN_TextChanged(object sender, EventArgs e)
        {
            if (!Elegir) return;
            string Rtn = txtRTN.Text.Trim();
            DataTable Cliente;

            Cliente = Cliente_Controller.Cargar_Cliente(Rtn);
            if (Cliente.Rows.Count > 0)
            {
                txtNombre.Text = Cliente.Rows[0]["NOMBRE"].ToString();
                txtDireccion.Text = Cliente.Rows[0]["DIRECCION"].ToString();
                txtCelular.Text = Cliente.Rows[0]["CELULAR"].ToString();
            }
            else
            {
                Cliente = Temp_Venta_Controller.Cargar_Venta();
                if (Cliente.Rows[0]["RTN"].ToString() == Rtn)
                {
                    txtNombre.Text = Cliente.Rows[0]["NOMBRE_CLIENTE"].ToString();
                    txtDireccion.Text = Cliente.Rows[0]["DIRECCION"].ToString();
                    txtCelular.Text = Cliente.Rows[0]["CELULAR"].ToString();
                }
                else
                {
                    txtNombre.Clear();
                    txtDireccion.Clear();
                    txtCelular.Clear();
                }
            }
        }

        private void chkSinRTN_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSinRTN.Checked)
            {
                txtRTN.Text = "N/A";
                txtNombre.Text = "N/A";
                txtDireccion.Text = "N/A";
                txtCelular.Text = "N/A";
                txtRTN.Enabled = false;
                txtNombre.Enabled = false;
                txtDireccion.Enabled = false;
                txtCelular.Enabled = false;
            }
            else
            {
                txtRTN.Clear();
                txtNombre.Clear();
                txtDireccion.Clear();
                txtCelular.Clear();
                txtRTN.Enabled = true;
                txtNombre.Enabled = true;
                txtDireccion.Enabled = true;
                txtCelular.Enabled = true;
            }
        }
    }
}