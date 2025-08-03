using System.Data;
using System.Data.SqlClient;
using Prototipo_MarZel.Recursos.Modelos;

namespace Prototipo_MarZel.Recursos.DAO
{
    public class Movimiento_Inventario_DAO : Modelo_Movimiento_Inventario
    {
        public override DataTable ObtenerTodos()
        {
            ConexionBD conexion = new ConexionBD();
            string query = "SELECT * FROM " + Tabla;
            return conexion.EjecutarConsulta(query, null);
        }

        // método para filtrar por producto
        public DataTable FiltrarPorProducto(string nombreProducto)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"
                SELECT MI.*
                FROM TBL_MOVIMIENTOS_INVENTARIO MI
                INNER JOIN TBL_PRODUCTOS P ON MI.ID_PRODUCTO = P.ID_PRODUCTO
                WHERE P.DESCRIPCION LIKE @NombreProducto";
                SqlParameter[] parametros = {
                new SqlParameter("@NombreProducto", "%" + nombreProducto + "%")
            };
            return conexion.EjecutarConsulta(query, parametros);
        }


    }
}

