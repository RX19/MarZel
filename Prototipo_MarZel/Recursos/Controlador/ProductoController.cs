using System.Data;

namespace Prototipo_MarZel
{
    public class ProductoController
    {
        private ProductoBase productoDAO;

        public ProductoController()
        {
            productoDAO = new ProductoDAO(); 
        }

        public DataTable ObtenerProductos()
        {
            return productoDAO.ObtenerTodos();
        }
        public DataTable ObtenerProductosPorDescripcion()
        {
            return productoDAO.ObtenerProductos();
        }
        public DataTable ObtenerProducto(string filtro)
        {
            return productoDAO.ObtenerProducto(filtro);
        }
        public void ModificarProducto(string codigo, string desc, int id, decimal PU, decimal PC)
        {
            productoDAO.ModificarProducto(codigo, desc, id, PU, PC);
        }

    }
}
