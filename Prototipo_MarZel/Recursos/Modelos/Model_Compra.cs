using System.Data;

namespace Prototipo_MarZel
{
    public abstract class Compra_Base
    {
        public static String Tabla = "TBL_COMPRAS";

        public abstract DataTable Cargar_Compras();

        public abstract DataTable Cargar_Compra(string Factura);

        public abstract DataTable Cargar_Compra(int Id_Compra);

        public abstract DataTable Cargar_Detalles(int Id_Compra);

        public abstract void Agregar_Detalle(int Id_Compra, int Id_Producto, int Cantidad, decimal Costo, decimal Descuento, decimal Importe);

        public abstract void Guardar_Proveedor();

        public abstract void Guardar_Compra();

        public abstract void Guardar_Detalles();

        public abstract void Eliminar_Detalles(int Id_Compra);

        public abstract bool Buscar_En_Detalles_Compra(string Codigo_Barra);

        public abstract void Actualizar_Proveedor(int Id_Compra);

        public abstract void Actualizar_Compra(int Id_Compra);

        public abstract void Actualizar_Detalles(int Id_Compra);
    }
}