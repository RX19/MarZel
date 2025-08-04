using Prototipo_MarZel.Recursos.DAO;
using Prototipo_MarZel.Recursos.DAO;
using Prototipo_MarZel.Recursos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                u.ID_TIPO == 0 /*||
                u.ID_ESTADO == 0*/)
            {
                return false;
            }

            return dao.Guardar(u) > 0;
        }

        public DataTable Cargar_Usuarios()
        {
            return dao.Cargar_Usuarios();
        }

        public bool EliminarUsuario(int idUsuario)
        {
            return dao.EliminarUsuario(idUsuario) > 0;
        }

        public bool ModificarUsuario(int idUsuario, string identidad, string nombre, string correo, string usuario, string contrasena, string celular, int idTipo)
        {
            return dao.ModificarUsuario(idUsuario, identidad, nombre, correo, usuario, contrasena, celular, idTipo) > 0;
        }

        public DataTable ObtenerUsuarioPorId(int idUsuario)
        {
            return dao.ObtenerUsuarioPorId(idUsuario);
        }
    }
}
