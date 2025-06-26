using System.Data;

namespace Prototipo_MarZel
{
    public class ProductoDAO : ProductoBase
    {
        public override DataTable ObtenerTodos()
        {
            ConexionBD conexion = new ConexionBD();
            string query = "SELECT * FROM "+Tabla;
            return conexion.EjecutarConsulta(query);
        }
    }
}
