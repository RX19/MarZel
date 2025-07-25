using System.Data;

namespace Prototipo_MarZel
{
    public abstract class Login_Base
    {
        public static string Tabla = "TBL_LOGIN";

        public abstract DataTable Cargar_Logins();

        public abstract void Eliminar_Login(int Id_Login);

        public abstract DataTable Buscar_En_Logins(string filtro);

        public abstract void Agregar_Login(string Username, string Password);

        public abstract void Modificar_Login(int Id_Login, string Username, string Password);

        public abstract DataTable Cargar_Login(int Id_Login);

        public abstract DataTable Cargar_Login(string Username);

        public abstract bool Existe_Username(string Username);
    }
}