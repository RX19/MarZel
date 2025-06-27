using System;
using System.Data;
using System.Data.SqlClient;

namespace Prototipo_MarZel
{
    public class ConexionBD
    {
        //Cambiar Robber por servidor de la bd :v
        private readonly string cadenaConexion = "server=DESKTOP-BV60K7U\\SQLEXPRESS; database=MarZel; integrated security=true";

        public SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        public DataTable EjecutarConsulta(string query)
        {
            using (SqlConnection conexion = AbrirConexion())
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        public int EjecutarComando(string query, SqlParameter[] parametros)
        {
            using (SqlConnection conexion = AbrirConexion())
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                if (parametros != null)
                    comando.Parameters.AddRange(parametros);
                return comando.ExecuteNonQuery(); 
            }
        }
    }
}
