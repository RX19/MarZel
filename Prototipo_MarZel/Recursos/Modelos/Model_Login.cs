using System.Data;

namespace Prototipo_MarZel.Recursos.Modelos
{
    public abstract class Login_Base
    {
        public static string Tabla = "TBL_USUARIOS";

        public abstract bool ValidarUsuario(string usuario, string contrasena);

        public abstract DataTable ObtenerInformacionUsuario(string usuario);
    }

    public class Model_Login
    {
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
    }
}