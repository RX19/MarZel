using System.Data.SqlClient;

namespace Prototipo_MarZel.Recursos.DAO
{
    public class LoginDAO
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public bool ValidarUsuario(string nombreUsuario, string contrasena)
        {
            string query = "SELECT COUNT(*) FROM TBL_Usuario WHERE Usuario = @usuario AND Contrasena = @contrasena";
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
    }
}