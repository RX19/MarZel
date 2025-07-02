using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prototipo_MarZel.Recursos.Controlador;

namespace Prototipo_MarZel.Formularios
{
    public partial class FRM_LOGIN : MaterialSkin.Controls.MaterialForm
    {
        private readonly LoginController loginController = new LoginController();
        public string usuario;
        private string contrasena;
        public FRM_LOGIN()
        {
            InitializeComponent();
        }


        private async void FRM_LOGIN_Load(object sender, EventArgs e)
        {

            //await Transiciones.FadeInAsync(this);
            materialButton1.Focus();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            usuario = TXT_USUARIO.Text.Trim();
            contrasena = TXT_PASSWORD.Text;

            bool loginExitoso = loginController.Login(usuario, contrasena);

            if (loginExitoso)
            {
                //MessageBox.Show("Bienvenido, " + usuario, "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.DialogResult = DialogResult.Cancel;
            }
        }

        private void materialCheckbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (materialCheckbox1.Checked)
                TXT_PASSWORD.PasswordChar = '\0';
            else
                TXT_PASSWORD.PasswordChar = '●';
        }
    }
}
