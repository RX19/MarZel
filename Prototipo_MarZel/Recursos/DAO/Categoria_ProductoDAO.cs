using Prototipo_MarZel.Recursos.Modelos;
using System.Data;
using System.Data.SqlClient;

namespace Prototipo_MarZel
{
    public class Categoria_Producto_DAO : Categoria_Producto_Base
    {
        public override DataTable Cargar_Categorias()
        {
            ConexionBD conexion = new ConexionBD();
            string query = $"SELECT * FROM {Tabla}";
            return conexion.EjecutarConsulta(query, null);
        }

        public override DataTable ObtenerPorId(string desc)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"SELECT ID 
                             FROM " + Tabla + 
                             " WHERE Descripcion = "+"'"+desc+"'";
            return conexion.EjecutarConsulta(query, null);
        }
    }
}