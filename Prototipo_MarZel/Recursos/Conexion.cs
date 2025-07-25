using System;
using System.Data;
using System.Data.SqlClient;

namespace Prototipo_MarZel
{
    public class ConexionBD
    {
        //Cambiar Robber por servidor de la bd :v
        private readonly string cadenaConexion = "server=ROBBER\\SQLEXPRESS; database=MarZel; integrated security=true"; 
        
        public SqlConnection AbrirConexion()
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }

        /*public DataTable EjecutarConsulta(string query)
        {
            //Habilitar para debugar, acabo de perder 2 horas porque mandaba un query mal :v
            //MessageBox.Show(query, "Consulta SQL");
            using (SqlConnection conexion = AbrirConexion())
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }*/

        public DataTable EjecutarConsulta(string query, SqlParameter[]? parametros)
        {
            using (SqlConnection conexion = AbrirConexion())
            {
                SqlCommand comando = new SqlCommand(query, conexion);
                if (parametros != null)
                    comando.Parameters.AddRange(parametros);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        public int EjecutarComando(string query, SqlParameter[]? parametros)
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
