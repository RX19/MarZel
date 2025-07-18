using System.Data;

namespace Prototipo_MarZel
{
    public class CompraController
    {
        private readonly CompraDAO dao = new CompraDAO();

        public List<Compra> ObtenerCompras()
        {
            return dao.ObtenerCompras();
        }

    }
}
