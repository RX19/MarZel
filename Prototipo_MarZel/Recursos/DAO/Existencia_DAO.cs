using System.Data;

namespace Prototipo_MarZel.Recursos.DAO
{
    public class Existencia_DAO
    {
        public DataTable ObtenerProductosBajaExistencia()
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"SELECT 
                                DESCRIPCION AS PRODUCTO,
                                EXISTENCIA
                             FROM TBL_PRODUCTOS
                             WHERE EXISTENCIA < 10";
            return conexion.EjecutarConsulta(query, null);
        }
    }
}