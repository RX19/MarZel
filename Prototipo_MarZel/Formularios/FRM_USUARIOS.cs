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




        private void BTN_PANEL_CREAR_USUARIO_Click(object sender, EventArgs e)
        {
            using (var frmGestionarUsuario = new FRM_GESTIONAR_USUARIO())
            {
                frmGestionarUsuario.ShowDialog();
            }
        }

        private readonly UsuarioController usuarioController = new UsuarioController();

        public void Cargar_Usuarios()
        {
            DataTable usuarios = usuarioController.Cargar_Usuarios();
            DVC_USUARIOS.DataSource = null;
            DVC_USUARIOS.DataSource = usuarios;
            if (DVC_USUARIOS.Columns.Contains("ID_USUARIO"))
                DVC_USUARIOS.Columns["ID_USUARIO"].Visible = false;
            DVC_USUARIOS.ClearSelection();

        }

        private async void FRM_Usuarios_Load(object sender, EventArgs e)
        {
            await FadeInAsync(this);
            this.Opacity = 1.0;

            Cargar_Usuarios();
        }

        private void BTN_PANEL_ELIMINAR_USUARIO_Click(object sender, EventArgs e)
        {
            if (DVC_USUARIOS.CurrentRow == null)
            {
                MessageBox.Show("Por favor, seleccione un usuario para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idUsuario = Convert.ToInt32(DVC_USUARIOS.CurrentRow.Cells["ID_USUARIO"].Value);

            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea eliminar este usuario?",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                bool exito = usuarioController.EliminarUsuario(idUsuario);
                if (exito)
                {
                    MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cargar_Usuarios();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
