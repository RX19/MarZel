using System.Data;
using Prototipo_MarZel.Recursos.Modelos;
using Prototipo_MarZel.Recursos.DAO;

namespace Prototipo_MarZel.Recursos.Controlador
{
    public class Movimiento_Inventario_Controller
    {
        private Movimiento_Inventario_Base Movimiento_DAO;

        public Movimiento_Inventario_Controller()
        {
            Movimiento_DAO = new Movimiento_Inventario_DAO();
        }

        public DataTable ObtenerMovimientos()
        {
            return Movimiento_DAO.ObtenerTodos();
        }
    }
}