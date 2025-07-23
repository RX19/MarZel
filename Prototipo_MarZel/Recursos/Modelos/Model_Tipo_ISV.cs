using System.Data;

namespace Prototipo_MarZel
{
    public abstract class Tipo_ISV_Base
    {
        public static String Tabla = "TBL_TIPOS_ISV";

        public abstract DataTable Cargar_Tipos_ISV();
    }
}