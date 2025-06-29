using System.Data;

namespace Prototipo_MarZel
{
    public abstract class ProductoBase
    {
        public static String Tabla = "TBL_Productos";
        public abstract DataTable ObtenerTodos();
        public abstract DataTable ObtenerProductos();
        public abstract DataTable ObtenerProducto(string filtro);
        // Pendiente : Insertar, Actualizar, Eliminar...
    }
}
