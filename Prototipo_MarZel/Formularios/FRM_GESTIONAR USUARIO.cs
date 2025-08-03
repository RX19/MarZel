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

            string rol = CB_TIPO_USUARIO.Text;
            int idTipoUsuario = rol == "Administrador" ? 1 : rol == "Vendedor" ? 2 : 0;

            Model_Usuario nuevo = new Model_Usuario
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
        }
        private void FRM_GESTIONAR_USUARIO_Load(object sender, EventArgs e)
        {

            var p = this.GetPreferredSize(Size.Empty);
            this.ClientSize = new Size(p.Width + 20, p.Height + 20);

        }

    }
}
