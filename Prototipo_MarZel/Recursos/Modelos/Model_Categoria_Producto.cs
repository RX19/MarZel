using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_MarZel.Recursos.Modelos
{
    public abstract class Categoria_Producto_Base
    {
        public static String Tabla = "TBL_CATEGORIAS_PRODUCTO";
        
        public abstract DataTable Cargar_Categorias();
        
        public abstract DataTable ObtenerPorId(string id);
        // Pendiente : Insertar, Actualizar, Eliminar...
    }
}