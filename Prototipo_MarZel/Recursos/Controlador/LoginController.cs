using Prototipo_MarZel.Recursos.DAO;

namespace Prototipo_MarZel.Recursos.Controlador
{
    public class LoginController
    {
        private readonly LoginDAO loginDAO = new LoginDAO();

        public bool Login(string nombreUsuario, string contrasena)
        {
            return loginDAO.ValidarUsuario(nombreUsuario, contrasena);
        }
    }
}