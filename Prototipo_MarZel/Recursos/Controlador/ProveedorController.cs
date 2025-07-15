using System.Data;

namespace Prototipo_MarZel
{
    public class ProveedorController
    {
        private readonly ProveedorDAO dao = new ProveedorDAO();

        public List<Proveedor> ObtenerProveedores()
        {
            return dao.ObtenerProveedores();
        }

    }
}
