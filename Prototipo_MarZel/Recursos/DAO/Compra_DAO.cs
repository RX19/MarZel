using System.Data;
using System.Data.SqlClient;

namespace Prototipo_MarZel
{
    public class Compra_DAO : Compra_Base
    {
        public override DataTable Cargar_Compras()
        {
            ConexionBD conexion = new ConexionBD();
            string query = $"SELECT * FROM {Tabla}";
            return conexion.EjecutarConsulta(query, null);
        }
    }
}