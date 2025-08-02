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
    public partial class FRM_GESTIONAR_PROVEEDOR : MaterialSkin.Controls.MaterialForm
    {
        Proveedor_Controller Proveedor_Controller = new Proveedor_Controller();
        Temp_Compra_Controller Temp_Compra_Controller = new Temp_Compra_Controller();
        bool Elegir = false;
        int? Id_Proveedor = null;

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
        }

        public FRM_GESTIONAR_PROVEEDOR(string RTN)
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

        private void FRM_GESTIONAR_PROVEEDOR_Load(object sender, EventArgs e)
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
                if (Id_Proveedor == null)
                {
                    if (Proveedor_Controller.Existe_RTN(rtn))
                    {
                        MessageBox.Show("El R.T.N. ingresado ya existe. Por favor, ingrese un R.T.N. diferente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    DataTable Proveedor = Proveedor_Controller.Cargar_Proveedor(Id_Proveedor.Value);
                    if (Proveedor_Controller.Existe_RTN(rtn) && rtn != Proveedor.Rows[0]["RTN"].ToString())
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

            string RTN = txtRTN.Text.Trim();
            string Nombre = txtNombre.Text.Trim();
            string Direccion = txtDireccion.Text.Trim();
            string Celular = txtCelular.Text.Trim();

            if (!Elegir)
            {
                DialogResult result = MessageBox.Show(
                "¿Desea guardar los cambios?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes) return;

                if (Id_Proveedor == null)
                {
                    Proveedor_Controller.Agregar_Proveedor(RTN, Nombre, Direccion, Celular, 0, 0);
                }
                else
                {
                    Proveedor_Controller.Modificar_Proveedor(Id_Proveedor.Value, RTN, Nombre, Direccion, Celular);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show(
                "¿Desea cambiar de proveedor?", "Confirmación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result != DialogResult.Yes) return;

                DataTable Proveedor = Proveedor_Controller.Cargar_Proveedor(RTN);
                int? Id_Proveedor = null;
                if (Proveedor.Rows.Count > 0)
                    Id_Proveedor = Convert.ToInt32(Proveedor.Rows[0]["ID_PROVEEDOR"]);
                Temp_Compra_Controller.Modificar_Proveedor(Id_Proveedor, RTN, Nombre, Direccion, Celular);
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtRTN_TextChanged(object sender, EventArgs e)
        {
            if (!Elegir) return;
            string Rtn = txtRTN.Text.Trim();
            DataTable Proveedor;

            Proveedor = Proveedor_Controller.Cargar_Proveedor(Rtn);
            if (Proveedor.Rows.Count > 0)
            {
                txtNombre.Text = Proveedor.Rows[0]["NOMBRE"].ToString();
                txtDireccion.Text = Proveedor.Rows[0]["DIRECCION"].ToString();
                txtCelular.Text = Proveedor.Rows[0]["CELULAR"].ToString();
            }
            else
            {
                Proveedor = Temp_Compra_Controller.Cargar_Compra();
                if (Proveedor.Rows[0]["RTN"].ToString() == Rtn)
                {
                    txtNombre.Text = Proveedor.Rows[0]["NOMBRE"].ToString();
                    txtDireccion.Text = Proveedor.Rows[0]["DIRECCION"].ToString();
                    txtCelular.Text = Proveedor.Rows[0]["CELULAR"].ToString();
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