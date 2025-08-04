using Prototipo_MarZel.Recursos.Controlador;
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
    public partial class FRM_EDITAR_USUARIO : MaterialSkin.Controls.MaterialForm
    {
        private int idUsuario;
        public FRM_EDITAR_USUARIO()
        {
            InitializeComponent();
        }

        // Constructor que recibe los datos del usuario
        public FRM_EDITAR_USUARIO(int idUsuario, string identidad, string nombre, string correo, string usuario, string contraseña, string celular, int idTipo)
            : this()
        {
            // Asigna los valores a los controles del formulario
            this.idUsuario = idUsuario;
            TXT_EDITAR_IDENTIDAD.Text = identidad;
            TXT_EDITAR_NOMBRE.Text = nombre;
            TXT_EDITAR_CORREO.Text = correo;
            TXT_EDITAR_NOMBRE_USUARIO.Text = usuario;
            TXT_EDITAR_CELULAR.Text = celular;
            TXT_EDITAR_CONTRASEÑA.Text = contraseña;
            CB_EDITAR_TIPO_USUARIO.SelectedValue = idTipo; // O usa SelectedIndex si corresponde
        }


        private void BTN_EDITAR_Click(object sender, EventArgs e)
        {
            string identidad = TXT_EDITAR_IDENTIDAD.Text.Trim();
            string nombre = TXT_EDITAR_NOMBRE.Text.Trim();
            string correo = TXT_EDITAR_CORREO.Text.Trim();
            string usuario = TXT_EDITAR_NOMBRE_USUARIO.Text.Trim();
            string contrasena = TXT_EDITAR_CONTRASEÑA.Text.Trim();
            string celular = TXT_EDITAR_CELULAR.Text.Trim();
            int idTipo = Convert.ToInt32(CB_EDITAR_TIPO_USUARIO.SelectedValue);

            UsuarioController ctrl = new UsuarioController();
            bool exito = ctrl.ModificarUsuario(idUsuario, identidad, nombre, correo, usuario, contrasena, celular, idTipo);

            MessageBox.Show(
                exito ? "Usuario editado correctamente." : "No se pudo editar el usuario.",
                exito ? "Éxito" : "Error",
                MessageBoxButtons.OK,
                exito ? MessageBoxIcon.Information : MessageBoxIcon.Error
            );

            if (exito)
                this.Close();
        }

    }
}
