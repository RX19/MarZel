using System.Data;

namespace Prototipo_MarZel
{
    public abstract class ProductoBase
    {
        public static String Tabla = "TBL_Productos";
        public abstract DataTable ObtenerTodos();
        // Pendiente : Insertar, Actualizar, Eliminar...
    }
}
