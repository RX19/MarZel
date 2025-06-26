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

 
    }
}
