using System.Data;
using System.Data.SqlClient;
using Prototipo_MarZel.Recursos.Modelos;

namespace Prototipo_MarZel.Recursos.DAO
{
    public class Movimiento_Inventario_DAO : Movimiento_Inventario_Base
    {
        public override DataTable ObtenerTodos()
        {
            ConexionBD conexion = new ConexionBD();
            string query = "SELECT * FROM " + Tabla;
            return conexion.EjecutarConsulta(query, null);
        }
    }
}