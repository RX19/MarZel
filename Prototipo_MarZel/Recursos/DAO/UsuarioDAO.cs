using Prototipo_MarZel.Recursos.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_MarZel.Recursos.DAO
{
    public class UsuarioDAO
    {
        private ConexionBD conexion = new ConexionBD();

        public int Guardar(Model_Usuario u)
        {
            string query = @"
                INSERT INTO TBL_USUARIOS
                (IDENTIDAD, NOMBRE, CORREO, USUARIO, CONTRASENA, CELULAR, ID_TIPO, ID_ESTADO)
                VALUES (@Identidad, @Nombre, @Correo, @Usuario, @Contrasena, @Celular, @ID_Tipo_Usuario, @Estado)";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Identidad", u.IDENTIDAD),
                new SqlParameter("@Nombre", u.NOMBRE),
                new SqlParameter("@Correo", u.CORREO),
                new SqlParameter("@Usuario", u.USUARIO),
                new SqlParameter("@Contrasena", u.CONTRASENA),
                new SqlParameter("@Celular", u.CELULAR),
                new SqlParameter("@ID_Tipo_Usuario", u.ID_TIPO),
                new SqlParameter("@Estado", 1)
            };

            return conexion.EjecutarComando(query, parametros);

        }

        public DataTable Cargar_Usuarios()
        {
            string query = "SELECT * FROM TBL_USUARIOS";
            return conexion.EjecutarConsulta(query, null);
        }

        public int EliminarUsuario(int idUsuario)
        {
            string query = "DELETE FROM TBL_USUARIOS WHERE ID_USUARIO = @ID_USUARIO";
            SqlParameter[] parametros = { new SqlParameter("@ID_USUARIO", idUsuario) };
            return conexion.EjecutarComando(query, parametros);
        }
        public int ModificarUsuario(int idUsuario, string identidad, string nombre, string correo, string usuario, string contrasena, string celular, int idTipo)
        {
            string query = @"UPDATE TBL_USUARIOS
                             SET IDENTIDAD = @IDENTIDAD,
                                 NOMBRE = @NOMBRE,
                                 CORREO = @CORREO,
                                 USUARIO = @USUARIO,
                                 CONTRASENA = @CONTRASENA,
                                 CELULAR = @CELULAR,
                                 ID_TIPO = @ID_TIPO
                             WHERE ID_USUARIO = @ID_USUARIO";
            SqlParameter[] parametros = {
                new SqlParameter("@IDENTIDAD", identidad),
                new SqlParameter("@NOMBRE", nombre),
                new SqlParameter("@CORREO", correo),
                new SqlParameter("@USUARIO", usuario),
                new SqlParameter("@CONTRASENA", contrasena),
                new SqlParameter("@CELULAR", celular),
                new SqlParameter("@ID_TIPO", idTipo),
                new SqlParameter("@ID_USUARIO", idUsuario)
            };
            return conexion.EjecutarComando(query, parametros);
        }
    }
}
