using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_MarZel.Recursos.Modelos
{
    public abstract class CategoriaBase
    {
        public static String Tabla = "TBL_CategoriasProducto";
        public abstract DataTable ObtenerTodos();
        public abstract DataTable ObtenerPorId(string id);
        // Pendiente : Insertar, Actualizar, Eliminar...
    }

    public class Categoria_Producto
    {
        public int ID_CATEGORIA { get; set; }

        public string DESCRIPCION { get; set; } = string.Empty;
    }
}
