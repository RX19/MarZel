using System.Data;

namespace Prototipo_MarZel
{
    public abstract class Compra_Base
    {
        public static String Tabla = "TBL_COMPRAS";

        public abstract DataTable Cargar_Compras();

        public abstract DataTable Cargar_Compra(string Factura);

        public abstract void Agregar_Detalle(int Id_Compra, int Id_Producto, int Cantidad, decimal Costo, decimal Descuento, decimal Importe);

        public abstract void Guardar_Proveedor();

        public abstract void Guardar_Compra();

        public abstract void Procesar_Detalles();
    }
}