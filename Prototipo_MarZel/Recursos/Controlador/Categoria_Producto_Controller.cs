using Prototipo_MarZel.Recursos.Modelos;
using System.Data;

namespace Prototipo_MarZel
{
    public class CategoriaController
    {
        private CategoriaBase CategoriaDAO;

        public CategoriaController()
        {
            CategoriaDAO = new CategoriaDAO();
        }

        public DataTable ObtenerProductos()
        {
            return CategoriaDAO.ObtenerTodos();
        }
        public DataTable ObtenerCategoriaPorId(string desc)
        {
            return CategoriaDAO.ObtenerPorId(desc);
        }


    }

    public class Categoria_Producto_Controller
    {
        private readonly Categoria_Producto_DAO dao = new Categoria_Producto_DAO();

        public List<Categoria_Producto> Cargar_Categorias()
        {
            return dao.Cargar_Categorias();
        }
    }
}