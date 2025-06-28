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
    public partial class FRM_ADMINISTRADOR : MaterialSkin.Controls.MaterialForm
    {
        public FRM_ADMINISTRADOR()
        {
            InitializeComponent();
        }

        private void FRM_Administrador_Load(object sender, EventArgs e)
        {
            P_CREAR_USUARIO.Visible = false;
        }


        private void BTN_CREAR_Click(object sender, EventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(TXT_NOMBRE.Text) ||
                string.IsNullOrWhiteSpace(TXT_APELLIDO.Text) ||
                string.IsNullOrWhiteSpace(TXT_CORREO.Text) ||
                string.IsNullOrWhiteSpace(TXT_NOMBRE_USUARIO.Text) ||
                string.IsNullOrWhiteSpace(TXT_CONTRASEÑA.Text) ||
                string.IsNullOrWhiteSpace(TXT_CELULAR.Text) ||
                CB_TIPO_USUARIO.SelectedItem == null)
            {
                MessageBox.Show("Por favor completa todos los campos antes de continuar.", "Campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string nombre = TXT_NOMBRE.Text.Trim();
            string apellido = TXT_APELLIDO.Text.Trim();
            string correo = TXT_CORREO.Text.Trim();
            string nombreUsuario = TXT_NOMBRE_USUARIO.Text.Trim();
            string contraseña = TXT_CONTRASEÑA.Text.Trim();
            string celular = TXT_CELULAR.Text.Trim();

            string rol = CB_TIPO_USUARIO.Text;

            int idTipoUsuario = 0;
            if (rol == "Administrador")
                idTipoUsuario = 1;
            else if (rol == "Vendedor")
                idTipoUsuario = 2;

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nombre", nombre),
                new SqlParameter("@Apellido", apellido),
                new SqlParameter("@Correo", correo),
                new SqlParameter("@Usuario", nombreUsuario),
                new SqlParameter("@Contraseña", contraseña),
                new SqlParameter("@Celular", celular),
                new SqlParameter("@ID_Tipo_Usuario", idTipoUsuario),
                new SqlParameter("@Estado", 1)
            };

            string query = @"
            INSERT INTO TBL_Usuario 
            (Nombre, Apellido, Correo, Usuario, Contrasena, Celular, ID_Tipo_Usuario, Estado) 
            VALUES (@Nombre, @Apellido, @Correo, @Usuario, @Contraseña, @Celular, @ID_Tipo_Usuario, @Estado)";

            ConexionBD conexion = new ConexionBD();
            int resultado = conexion.EjecutarComando(query, parametros);

            if (resultado > 0)
            {
                MessageBox.Show("Usuario guardado correctamente.");
            }
            else
            {
                MessageBox.Show("Ocurrió un error al guardar el usuario.");
            }*/

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
