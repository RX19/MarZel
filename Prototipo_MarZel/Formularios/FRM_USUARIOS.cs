using MaterialSkin;
using MaterialSkin.Controls;
using Prototipo_MarZel.Recursos.Controlador;
using Prototipo_MarZel.Recursos.Modelos;
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
    public partial class FRM_USUARIOS : MaterialSkin.Controls.MaterialForm
    {
        public FRM_USUARIOS()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //this.ControlBox = false;         // Quita los tres botones (cerrar, minimizar, maximizar)
            this.MaximizeBox = false;        // Impide maximizar
            this.Hide();
        }
        private async Task FadeOutAsync(Form form)
        {
            for (double i = 1.0; i >= 0; i -= 0.05)
            {
                form.Opacity = i;
                await Task.Delay(15);
            }
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
        private async void FRM_Administrador_Load(object sender, EventArgs e)
        {
            P_CREAR_USUARIO.Visible = false;
            await FadeInAsync(this);
            this.Opacity = 1.0;
        }

        private void FRM_Administrador_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Desea volver al menú principal?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }


        private void BTN_CREAR_Click(object sender, EventArgs e)
        {

            string rol = CB_TIPO_USUARIO.Text;
            int idTipoUsuario = rol == "Administrador" ? 1 : rol == "Vendedor" ? 2 : 0;

            Model_Usuario nuevo = new Model_Usuario
            {
                Nombre = TXT_NOMBRE.Text.Trim(),
                Apellido = TXT_APELLIDO.Text.Trim(),
                Correo = TXT_CORREO.Text.Trim(),
                NombreUsuario = TXT_NOMBRE_USUARIO.Text.Trim(),
                Contrasena = TXT_CONTRASEÑA.Text.Trim(),
                Celular = TXT_CELULAR.Text.Trim(),
                IdTipoUsuario = idTipoUsuario
            };

            UsuarioController ctrl = new UsuarioController();
            bool exito = ctrl.CrearUsuario(nuevo);

            MessageBox.Show(
                exito ? "Usuario creado exitosamente." : "Por favor, completa todos los campos correctamente.",
                exito ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                exito ? MessageBoxIcon.Information : MessageBoxIcon.Warning
            );


        }

        private void BTN_PANEL_CREAR_USUARIO_Click(object sender, EventArgs e)
        {
            P_CREAR_USUARIO.Visible = true;
        }
    }
}
