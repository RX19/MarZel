using System.Data;

namespace Prototipo_MarZel
{
    public class Compra_Controller
    {
        private readonly Compra_DAO dao = new Compra_DAO();

        public List<Compra> Obtener_Compras()
        {
            return dao.Obtener_Compras();
        }
    }
}