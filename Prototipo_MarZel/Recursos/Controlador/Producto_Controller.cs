using System.Data;

namespace Prototipo_MarZel
{
    public class Producto_Controller
    {
        private Producto_Base Producto_DAO;

        public Producto_Controller()
        {
            Producto_DAO = new Producto_DAO();
        }

        public DataTable ObtenerProductos()
        {
            return Producto_DAO.ObtenerTodos();
        }

        public DataTable ObtenerProductosPorDescripcion()
        {
            return Producto_DAO.ObtenerProductos();
        }

        public DataTable ObtenerProducto(string filtro)
        {
            return Producto_DAO.ObtenerProducto(filtro);
        }

        public void ModificarProducto(string codigo, string desc, int id, decimal PU, decimal PC)
        {
            Producto_DAO.ModificarProducto(codigo, desc, id, PU, PC);
        }

        public DataTable Cargar_Producto(string Codigo_Barra)
        {
            return Producto_DAO.Cargar_Producto(Codigo_Barra);
        }

        public int? Buscar_Id_Producto(string Codigo_Barra)
        {
            return Producto_DAO.Buscar_Id_Producto(Codigo_Barra);
        }

        public void Agregar_Producto(string Codigo_Barra, string Descripcion, int Id_ISV, decimal Precio_Completo,
            decimal Precio_Unitario, int Id_Categoria, int Existencia)
        {
            Producto_DAO.Agregar_Producto(Codigo_Barra, Descripcion, Id_ISV, Precio_Completo,
            Precio_Unitario, Id_Categoria, Existencia);
        }
    }
}