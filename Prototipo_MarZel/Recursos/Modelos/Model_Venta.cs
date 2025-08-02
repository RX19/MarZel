using System.Data;

namespace Prototipo_MarZel
{
    public abstract class Venta_Base
    {
        public static String Tabla = "TBL_VENTAS";

        public abstract DataTable Cargar_Ventas();

        public abstract DataTable Buscar_En_Ventas(string filtro);

        public abstract void Guardar_Cliente();

        public abstract void Guardar_Venta();

        public abstract DataTable Cargar_Venta(string Factura);

        public abstract void Guardar_Detalles();

        public abstract void Agregar_Detalle(int Id_Venta, int Id_Producto, int Cantidad, decimal Precio, decimal Descuento, decimal Importe);

        public abstract void Actualizar_Cliente(int Id_Venta);
        
        public abstract DataTable Cargar_Venta(int Id_Venta);

        public abstract void Actualizar_Venta(int Id_Venta);

        public abstract void Actualizar_Detalles(int Id_Venta);

        public abstract DataTable Cargar_Detalles(int Id_Venta);
        
        public abstract void Eliminar_Detalles(int Id_Venta);

        public abstract void Eliminar_Venta(int Id_Venta);
    }
}