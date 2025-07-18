using System.Data;

namespace Prototipo_MarZel
{
    public class Proveedor_Controller
    {
        private readonly Proveedor_DAO dao = new Proveedor_DAO();

        public List<Proveedor> Obtener_Proveedores()
        {
            return dao.Obtener_Proveedores();
        }

        public bool Existe_RTN(string rtn)
        {
            return dao.Existe_RTN(rtn);
        }

        public void Agregar_Proveedor(Proveedor proveedor)
        { 
            dao.Agregar_Proveedor(proveedor);
        }

        public void Actualizar_Proveedor(Proveedor proveedor)
        {
            dao.Actualizar_Proveedor(proveedor);
        }

        public void Eliminar_Proveedor(int id_proveedor)
        {
            dao.Eliminar_Proveedor(id_proveedor);
        }

        public List<Proveedor> Buscar_Proveedor(string texto)
        {
            return dao.Buscar_Proveedor(texto);
        }
    }
}