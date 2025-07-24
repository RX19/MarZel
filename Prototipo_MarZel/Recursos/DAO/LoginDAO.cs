using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prototipo_MarZel.Recursos.DAO
{
    public class LoginDAO
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public bool ValidarUsuario(string nombreUsuario, string contrasena)
        {
            string query = "SELECT COUNT(*) FROM TBL_USUARIOS WHERE USUARIO = @usuario AND CONTRASENA = @contrasena";
            using (SqlConnection conn = conexion.AbrirConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@usuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@contrasena", contrasena);

                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }

        }

        public DataTable ObtenerInformacionUsuario(string nombreUsuario)
        {
            string query = "SELECT Nombre, Correo FROM TBL_Usuarios WHERE Usuario = "+"'"+nombreUsuario+"'";
            return conexion.EjecutarConsulta(query, null);
            
        }
    }
}