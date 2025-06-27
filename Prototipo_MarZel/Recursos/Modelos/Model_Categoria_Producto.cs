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
        public static String Tabla = "TBL_Categoria_Producto";
        public abstract DataTable ObtenerTodos();
        // Pendiente : Insertar, Actualizar, Eliminar...
    }
}
