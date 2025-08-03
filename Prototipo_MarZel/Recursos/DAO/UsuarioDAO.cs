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
                VALUES (@Identidad, @Nombre, @Correo, @Usuario, @Contrasena, @Celular, @ID_Tipo, @Id_Estado)";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Identidad", u.IDENTIDAD),
                new SqlParameter("@Nombre", u.NOMBRE),
                new SqlParameter("@Correo", u.CORREO),
                new SqlParameter("@Usuario", u.USUARIO),
                new SqlParameter("@Contrasena", u.CONTRASENA),
                new SqlParameter("@Celular", u.CELULAR),
                new SqlParameter("@ID_Tipo_Usuario", u.ID_TIPO),
                new SqlParameter("@Estado", u.ID_ESTADO)
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
    }
}
