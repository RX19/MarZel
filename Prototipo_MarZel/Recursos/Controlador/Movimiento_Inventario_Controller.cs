using System.Data;
using Prototipo_MarZel.Recursos.Modelos;
using Prototipo_MarZel.Recursos.DAO;

namespace Prototipo_MarZel.Recursos.Controlador
{
    public class Movimiento_Inventario_Controller
    {
        private readonly Movimiento_Inventario_DAO Movimiento_DAO = new();
       

        public DataTable ObtenerMovimientos()
        {
            return Movimiento_DAO.ObtenerTodos();
        }

        // método para filtrar
        public DataTable FiltrarPorProducto(string nombreProducto)
        {
            return Movimiento_DAO.FiltrarPorProducto(nombreProducto);   
        }
    }
}