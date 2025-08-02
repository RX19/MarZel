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
            if (string.IsNullOrWhiteSpace(u.IDENTIDAD) ||
                string.IsNullOrWhiteSpace(u.NOMBRE) ||
                string.IsNullOrWhiteSpace(u.CORREO) ||
                string.IsNullOrWhiteSpace(u.USUARIO) ||
                string.IsNullOrWhiteSpace(u.CONTRASENA) ||
                string.IsNullOrWhiteSpace(u.CELULAR) ||
                u.ID_TIPO == 0 ||
                u.ID_ESTADO == 0)
            {
                return false;
            }

            return dao.Guardar(u) > 0;
        }

    }
}
