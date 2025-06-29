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
            string query = "select TBL_Productos.Descripcion as Producto from TBL_Productos " +
                "inner join TBL_Categoria_Producto on " +
                "TBL_Productos.ID_Categoria_Producto = TBL_Categoria_Producto.ID";
            return conexion.EjecutarConsulta(query);
        }
        public override DataTable ObtenerProducto(string filtro)
        {
            ConexionBD conexion = new ConexionBD();
            string query = "Select Codigo_Barra,Descripcion,ID_Categoria_Producto" +
                ", ISV,Cantidad,Precio_Unitario,Precio_Completo from "+Tabla+" where Descripcion = "+"'"+filtro+"'";
            return conexion.EjecutarConsulta(query);
        }
    }
}
