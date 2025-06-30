using Prototipo_MarZel.Recursos.Modelos;
using System.Data;

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
}