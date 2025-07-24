using System.Data;

namespace Prototipo_MarZel
{
    public abstract class Compra_Base
    {
        public static String Tabla = "TBL_COMPRAS";

        public abstract DataTable Cargar_Compras();

        public abstract void Guardar_Proveedor(int Id_Compra);

        public abstract void Guardar_Compra(int Id_Compra);

        public abstract void Procesar_Detalles(int Id_Compra);
    }
}