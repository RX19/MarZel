using System.Data;

namespace Prototipo_MarZel
{
    public abstract class Compra_Base
    {
        public static String Tabla = "TBL_COMPRAS";

        public abstract DataTable Cargar_Compras();
    }
}