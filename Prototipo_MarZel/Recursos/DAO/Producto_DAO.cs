using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prototipo_MarZel
{
    public class Producto_DAO : Producto_Base
    {
        public override DataTable ObtenerTodos()
        {
            ConexionBD conexion = new ConexionBD();
            string query = "SELECT * FROM " + Tabla;
            return conexion.EjecutarConsulta(query, null);
        }

        public override DataTable ObtenerProductos()
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"SELECT 
                                TBL_PRODUCTOS.DESCRIPCION AS PRODUCTO,
                                TBL_CATEGORIAS_PRODUCTO.DESCRIPCION AS CATEGORIA,
                                TBL_PRODUCTOS.EXISTENCIA
                            FROM TBL_PRODUCTOS  
                            INNER JOIN TBL_CATEGORIAS_PRODUCTO ON TBL_PRODUCTOS.ID_CATEGORIA = TBL_CATEGORIAS_PRODUCTO.ID_CATEGORIA";
            return conexion.EjecutarConsulta(query, null);
        }

        public override DataTable ObtenerProducto(string filtro)
        {
            ConexionBD conexion = new ConexionBD();

            string query = @"
                            SELECT 
                                P.CODIGO_BARRA,
                                P.DESCRIPCION,
                                C.DESCRIPCION AS CATEGORIA,
                                P.ID_ISV,
                                P.EXISTENCIA,
                                P.PRECIO_UNITARIO,
                                P.PRECIO_COMPLETO
                            FROM " + Tabla + @" P
                            INNER JOIN TBL_CATEGORIAS_PRODUCTO C ON P.ID_CATEGORIA = C.ID_CATEGORIA
                            WHERE P.DESCRIPCION LIKE " + "'" + filtro + "'" + " OR P.CODIGO_BARRA LIKE " + "'" + filtro + "'";

            return conexion.EjecutarConsulta(query, null);
        }

        public override void ModificarProducto(string codigo, string desc, int id, decimal PU, decimal PC)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"UPDATE " + Tabla + @"
                    SET [DESCRIPCION] = @desc,
                        [ID_CATEGORIA] = @id,
                        [PRECIO_UNITARIO] = @pu,
                        [PRECIO_COMPLETO] = @pc
                    WHERE CODIGO_BARRA = @codigo";

            SqlParameter[] parametros =
            {
                new SqlParameter("@desc", desc),
                new SqlParameter("@id", id),
                new SqlParameter("@pu", PU),
                new SqlParameter("@pc", PC),
                new SqlParameter("@codigo", codigo)
            };

            conexion.EjecutarComando(query, parametros);

        }

        public override DataTable Cargar_Producto(string Codigo_Barra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @$"
                SELECT  *
                FROM    TBL_PRODUCTOS
                WHERE   CODIGO_BARRA = @CODIGO_BARRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@CODIGO_BARRA", Codigo_Barra)
            };
            return conexion.EjecutarConsulta(query, parametros);
        }

        public override int? Buscar_Id_Producto(string Codigo_Barra)
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"SELECT ID_PRODUCTO 
                             FROM " + Tabla + 
                             " WHERE CODIGO_BARRA = @CODIGO_BARRA";
            SqlParameter[] parametros =
            {
                new SqlParameter("@CODIGO_BARRA", Codigo_Barra)
            };
            DataTable resultado = conexion.EjecutarConsulta(query, parametros);
            return resultado.Rows.Count > 0 ? Convert.ToInt32(resultado.Rows[0]["ID_PRODUCTO"]) : (int?)null;
        }
    }
}