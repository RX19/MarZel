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

        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void FRM_LOGIN_Load(object sender, EventArgs e)
        {
            materialButton1.Focus();
        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string usuario = TXT_USUARIO.Text.Trim();
            string contrasena = TXT_PASSWORD.Text;

            bool loginExitoso = loginController.Login(usuario, contrasena);

            if (loginExitoso)
            {
                MessageBox.Show("Bienvenido, " + usuario, "Login Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
