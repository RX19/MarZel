using System.Data;

namespace Prototipo_MarZel
{
    public abstract class Temp_Venta_Base
    {
        public abstract void Eliminar_Registros_Temporales();

        public abstract void Agregar_Venta(int Id_Usuario, string Nombre_Usuario, int Id_Venta);

        public abstract void Capturar_Detalles(int Id_Venta);

        public abstract DataTable Cargar_Detalles();

        public abstract DataTable Cargar_Venta();

        public abstract bool Buscar_En_Detalles_Venta(string Codigo_Barra);

        public abstract bool Buscar_En_Productos(string Codigo_Barra);

        public abstract void Agregar_Detalle(int Id_Venta, int Id_Producto, string Codigo_Barra, 
            string Descripcion, int Cantidad, decimal Precio, decimal Precio_Completo, decimal Precio_Unitario, 
            int Id_ISV, decimal Descuento, decimal Importe, int Existencia, DateTime Fecha_Creacion);

        public abstract DataTable Cargar_Producto(string Codigo_Barra);

        public abstract void Actualizar_Detalle(string Codigo_Barra, int Cantidad, decimal Precio, 
            decimal Descuento, decimal Importe, int Existencia, DateTime Fecha_Creacion);

        public abstract void Completar_Venta();

        public abstract void Asignar_Id_Cliente(int Id_Cliente);

        public abstract void Asignar_Id_Venta(int Id_Venta);

        public abstract void Modificar_Cliente(int? Id_Cliente, string Rtn, string Nombre, string Direccion, string Celular);

        public abstract void Modificar_Detalle(int Id_Venta, int Id_Producto, int Cantidad, decimal Precio, decimal Descuento, 
            decimal Importe, int Existencia, DateTime Fecha_Creacion);

        public abstract void Eliminar_Detalle(string Codigo_Barra);
        
        
        /*public abstract bool Existe_Factura(string Factura);

        public abstract void Completar_Venta(int Id_Venta, string Factura, DateTime Fecha);

        public abstract void Asignar_ID_Producto(int Id_Producto, string Codigo_Barra);


        public abstract void Modificar_Detalle(int Id_Venta, int? Id_Producto, string Codigo_Barra_1, string Codigo_Barra, string Descripcion, int Cantidad,
            decimal Costo, decimal Descuento, decimal Importe, int Id_ISV, decimal Precio_Completo, decimal Precio_Unitario,
            int Id_Categoria, DateTime Fecha_Creacion);
        */
    }
}