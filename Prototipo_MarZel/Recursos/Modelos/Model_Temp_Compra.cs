using System.Data;

namespace Prototipo_MarZel
{
    public abstract class Temp_Compra_Base
    {
        public abstract void Eliminar_Registros_Temporales();

        public abstract void Agregar_Compra(int Id_Compra);

        public abstract void Capturar_Detalles(int Id_Compra);

        public abstract DataTable Cargar_Detalles();

        public abstract DataTable Cargar_Compra();

        public abstract bool Buscar_En_Detalles_Compra(string Codigo_Barra);

        public abstract DataTable Cargar_Producto(string Codigo_Barra);

        public abstract bool Buscar_En_Productos(string Codigo_Barra);

        public abstract void Agregar_Detalle(int Id_Compra, int? Id_Producto, string Codigo_Barra, string Descripcion, int Cantidad,
            decimal Costo, decimal Descuento, decimal Importe, int Id_ISV, decimal Precio_Completo, decimal Precio_Unitario,
            int Id_Categoria, DateTime Fecha_Creacion);

        public abstract void Modificar_Proveedor(int? Id_Proveedor, string RTN, string Nombre, string Direccion, string Celular);

        public abstract bool Existe_Factura(string Factura);

        public abstract void Completar_Compra(int Id_Compra, string Factura, DateTime Fecha);

        public abstract void Asignar_ID_Proveedor(int Id_Proveedor);

        public abstract void Asignar_ID_Compra(int Id_Compra);

        public abstract void Asignar_ID_Producto(int Id_Producto, string Codigo_Barra);

        public abstract void Modificar_Detalle(int Id_Compra, int? Id_Producto, string Codigo_Barra, string Descripcion, int Cantidad,
            decimal Costo, decimal Descuento, decimal Importe, int Id_ISV, decimal Precio_Completo, decimal Precio_Unitario,
            int Id_Categoria, DateTime Fecha_Creacion);
    }
}