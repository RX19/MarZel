using System.Data;
using Prototipo_MarZel.Recursos.DAO;

namespace Prototipo_MarZel.Recursos.Controlador
{
    public class Existencia_Controller
    {
        private readonly Existencia_DAO existenciaDAO = new Existencia_DAO();

        public DataTable ObtenerProductosBajaExistencia()
        {
            return existenciaDAO.ObtenerProductosBajaExistencia();
        }
    }
}