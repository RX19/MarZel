using System.Data;
using System.Data.SqlClient;

namespace Prototipo_MarZel
{
    public class Tipo_ISV_DAO : Tipo_ISV_Base
    {
        public override DataTable Cargar_Tipos_ISV()
        {
            ConexionBD conexion = new ConexionBD();
            string query = $"SELECT * FROM {Tabla}";
            return conexion.EjecutarConsulta(query, null);
        }
    }
}