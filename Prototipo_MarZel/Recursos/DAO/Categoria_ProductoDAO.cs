using Prototipo_MarZel.Recursos.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace Prototipo_MarZel
{
    public class CategoriaDAO : CategoriaBase
    {
        public override DataTable ObtenerTodos()
        {
            ConexionBD conexion = new ConexionBD();
            string query = "SELECT Descripcion FROM " + Tabla;
            return conexion.EjecutarConsulta(query);
        }
        public override DataTable ObtenerPorId(string desc)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"SELECT ID 
                             FROM " + Tabla + 
                             " WHERE Descripcion = "+"'"+desc+"'";
            return conexion.EjecutarConsulta(query);
        }
    }

    public class Categoria_Producto_DAO
    {
        private readonly ConexionBD conexion = new ConexionBD();

        public List<Categoria_Producto> Cargar_Categorias()
        {
            List<Categoria_Producto> lista_categorias = new();
            using SqlConnection con = conexion.AbrirConexion();
            string query = @"SELECT  * 
                             FROM    TBL_CATEGORIAS_PRODUCTO";
            using SqlCommand cmd = new SqlCommand(query, con);
            using SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var categoria = new Categoria_Producto
                {
                    ID_CATEGORIA = dr.GetInt32(dr.GetOrdinal("ID_CATEGORIA")),
                    DESCRIPCION = dr.GetString(dr.GetOrdinal("DESCRIPCION"))
                };

                lista_categorias.Add(categoria);
            }
            return lista_categorias;
        }
    }
}