using System.Data;

namespace Prototipo_MarZel
{
    public abstract class Producto_Base
    {
        public static String Tabla = "TBL_PRODUCTOS";

        public abstract DataTable ObtenerTodos();

        public abstract DataTable ObtenerProductos();

        public abstract DataTable ObtenerProducto(string filtro);

        public abstract void ModificarProducto(string codigo,string desc,int id,decimal PU, decimal PC);
        // Pendiente : Insertar, Actualizar, Eliminar...

        public abstract DataTable Cargar_Producto(string Codigo_Barra);

        public abstract int? Buscar_Id_Producto(string Codigo_Barra);

        public abstract void Agregar_Producto(string Codigo_Barra, string Descripcion, int Id_ISV, decimal Precio_Completo, 
            decimal Precio_Unitario, int Id_Categoria, int Existencia);

    }
}