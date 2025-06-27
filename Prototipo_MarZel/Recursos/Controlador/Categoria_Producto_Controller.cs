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


    }
}
