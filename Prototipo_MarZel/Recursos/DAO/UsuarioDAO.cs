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
            string query = @"SELECT
                                u.ID_USUARIO,
                                u.IDENTIDAD,
                                u.NOMBRE,
                                u.CORREO,
                                u.USUARIO,
                                u.CONTRASENA,
                                u.CELULAR,
                                t.DESCRIPCION    AS 'TIPO DE USUARIO',
                                e.DESCRIPCION    AS ESTADO
                            FROM dbo.TBL_USUARIOS AS u
                            JOIN dbo.TBL_TIPOS_USUARIO     AS t ON u.ID_TIPO   = t.ID_TIPO
                            JOIN dbo.TBL_ESTADOS_USUARIO   AS e ON u.ID_ESTADO = e.ID_ESTADO;";
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

        public DataTable ObtenerUsuarioPorId(int idUsuario)
        {
            string query = "SELECT * FROM TBL_USUARIOS WHERE ID_USUARIO = @ID_USUARIO";
            SqlParameter[] parametros = { new SqlParameter("@ID_USUARIO", idUsuario) };
            return conexion.EjecutarConsulta(query, parametros);
        }
    }
}
