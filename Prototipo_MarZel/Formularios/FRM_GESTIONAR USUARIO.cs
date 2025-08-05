using Microsoft.VisualBasic;
using Prototipo_MarZel.Recursos.Controlador;
using Prototipo_MarZel.Recursos.Modelos;
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
    public partial class FRM_GESTIONAR_USUARIO : MaterialSkin.Controls.MaterialForm
    {
        public FRM_GESTIONAR_USUARIO()
        {
            InitializeComponent();

            this.ClientSize = this.GetPreferredSize(Size.Empty);

        }

        private void BTN_CREAR_Click(object sender, EventArgs e)
        {
            if (CB_TIPO_USUARIO.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un tipo de usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(TXT_CORREO.Text))
            {
                MessageBox.Show("Debe ingresar un correo para enviar el código de verificación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string codigoGenerado = new Random().Next(100000, 999999).ToString();
            CorreoHelper.EnviarCorreo("Su codigo es: "+codigoGenerado, TXT_CORREO.Text);
            string input = Interaction.InputBox("Ingrese el código enviado a su correo:", "Verificación", "");

            if (input != codigoGenerado)
            {
                MessageBox.Show("Código incorrecto. Intente nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int idTipoUsuario = Convert.ToInt32(CB_TIPO_USUARIO.SelectedValue);

            Model_Usuario nuevo = new()
            {
                IDENTIDAD = TXT_IDENTIDAD.Text.Trim(),
                NOMBRE = TXT_NOMBRE.Text.Trim(),
                CORREO = TXT_CORREO.Text.Trim(),
                USUARIO = TXT_NOMBRE_USUARIO.Text.Trim(),
                CONTRASENA = TXT_CONTRASEÑA.Text.Trim(),
                CELULAR = TXT_CELULAR.Text.Trim(),
                ID_TIPO = idTipoUsuario
            };

            UsuarioController ctrl = new UsuarioController();
            bool exito = ctrl.CrearUsuario(nuevo);

            MessageBox.Show(
                exito ? "Usuario creado exitosamente." : "Por favor, completa todos los campos correctamente.",
                exito ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                exito ? MessageBoxIcon.Information : MessageBoxIcon.Warning
            );
            this.Close();
            
        }
        private void FRM_GESTIONAR_USUARIO_Load(object sender, EventArgs e)
        {

            var p = this.GetPreferredSize(Size.Empty);
            this.ClientSize = new Size(p.Width + 20, p.Height + 20);

            var tiposUsuario = new[]
            {
                new { ID = 1, NOMBRE = "Administrador" },
                new { ID = 2, NOMBRE = "Cajero" }
            };
            CB_TIPO_USUARIO.DataSource = tiposUsuario;
            CB_TIPO_USUARIO.DisplayMember = "NOMBRE";
            CB_TIPO_USUARIO.ValueMember = "ID";
            CB_TIPO_USUARIO.SelectedIndex = -1;

        }
    }
}
