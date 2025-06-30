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

        public override DataTable ObtenerProductos()
        {
            ConexionBD conexion = new ConexionBD();
            string query = @"SELECT 
                                TBL_Productos.Descripcion as Producto,
                                TBL_Categoria_Producto.Descripcion as Categoria 
                            FROM TBL_Productos  
                            INNER JOIN TBL_Categoria_Producto ON TBL_Productos.ID_Categoria_Producto = TBL_Categoria_Producto.ID";
            return conexion.EjecutarConsulta(query);
        }
        public override DataTable ObtenerProducto(string filtro)
        {
            ConexionBD conexion = new ConexionBD();

            string query = @"
        SELECT 
            P.Codigo_Barra,
            P.Descripcion,
            C.Descripcion AS Categoria,
            P.ISV,
            P.Cantidad,
            P.Precio_Unitario,
            P.Precio_Completo
        FROM " + Tabla + @" P
        INNER JOIN TBL_Categoria_Producto C ON P.ID_Categoria_Producto = C.ID
        WHERE P.Descripcion = "+"'"+filtro+"'";
            return conexion.EjecutarConsulta(query);
        }

    }
}
