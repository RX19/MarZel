using Prototipo_MarZel.Recursos.Modelos;
using System.Data;

namespace Prototipo_MarZel
{
    public class Categoria_Producto_Controller
    {
        private Categoria_Producto_Base Categoria_Producto_DAO;

        public Categoria_Producto_Controller()
        {
            Categoria_Producto_DAO = new Categoria_Producto_DAO();
        }

        public DataTable Cargar_Categorias()
        {
            return Categoria_Producto_DAO.Cargar_Categorias();
        }

        public DataTable ObtenerCategoriaPorId(string desc)
        {
            return Categoria_Producto_DAO.ObtenerPorId(desc);
        }
    }
}