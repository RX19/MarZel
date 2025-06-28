using Prototipo_MarZel.Recursos.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_MarZel.Recursos.Modelos;
using Prototipo_MarZel.Recursos.DAO;

namespace Prototipo_MarZel.Recursos.Controlador
{
    public class UsuarioController
    {
        private UsuarioDAO dao = new UsuarioDAO();

        public bool CrearUsuario(Model_Usuario u)
        {
            if (string.IsNullOrWhiteSpace(u.Nombre) ||
                string.IsNullOrWhiteSpace(u.Apellido) ||
                string.IsNullOrWhiteSpace(u.Correo) ||
                string.IsNullOrWhiteSpace(u.NombreUsuario) ||
                string.IsNullOrWhiteSpace(u.Contrasena) ||
                string.IsNullOrWhiteSpace(u.Celular) ||
                u.IdTipoUsuario == 0)
            {
                return false;
            }

            return dao.Guardar(u) > 0;
        }

    }
}
