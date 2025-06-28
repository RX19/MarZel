using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototipo_MarZel.Recursos.Modelos;

namespace Prototipo_MarZel.Recursos.DAO
{
    public class UsuarioDAO
    {
        private ConexionBD conexion = new ConexionBD();

        public int Guardar(Model_Usuario u)
        {
            string query = @"
                INSERT INTO TBL_Usuario 
                (Nombre, Apellido, Correo, Usuario, Contrasena, Celular, ID_Tipo_Usuario, Estado)
                VALUES (@Nombre, @Apellido, @Correo, @Usuario, @Contrasena, @Celular, @ID_Tipo_Usuario, @Estado)";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nombre", u.Nombre),
                new SqlParameter("@Apellido", u.Apellido),
                new SqlParameter("@Correo", u.Correo),
                new SqlParameter("@Usuario", u.NombreUsuario),
                new SqlParameter("@Contrasena", u.Contrasena),
                new SqlParameter("@Celular", u.Celular),
                new SqlParameter("@ID_Tipo_Usuario", u.IdTipoUsuario),
                new SqlParameter("@Estado", u.Estado)
            };

            return conexion.EjecutarComando(query, parametros);

        }
    }
}
