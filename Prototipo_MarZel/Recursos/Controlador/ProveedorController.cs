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

        public bool VerificarRTN(string rtn)
        {
            return dao.ExisteRTN(rtn);
        }

        public void AgregarProveedor(Proveedor proveedor)
        { 
            dao.AgregarProveedor(proveedor);
        }

        public void ActualizarProveedor(Proveedor proveedor)
        {
            dao.ActualizarProveedor(proveedor);
        }

        public void EliminarProveedor(int idProveedor)
        {
            dao.EliminarProveedor(idProveedor);
        }

    }
}
