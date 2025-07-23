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
    }

    public class Producto
    {
        public int ID_PRODUCTO { get; set; }

        public string CODIGO_BARRA { get; set; } = string.Empty;

        public String DESCRIPCION { get; set; } = string.Empty;

        public int ID_ISV { get; set; }

        public decimal PRECIO_COMPLETO { get; set; }

        public decimal PRECIO_UNITARIO { get; set; }

        public int ID_CATEGORIA { get; set; }

        public int EXISTENCIA { get; set; }
    }
}