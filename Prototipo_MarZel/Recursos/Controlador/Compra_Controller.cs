using Prototipo_MarZel.Recursos.Modelos;
using System.Data;

namespace Prototipo_MarZel
{
    public class Compra_Controller
    {
        private Compra_Base Compra_DAO;

        public Compra_Controller()
        {
            Compra_DAO = new Compra_DAO();
        }

        public DataTable Cargar_Compras()
        {
            return Compra_DAO.Cargar_Compras();
        }

        public void Agregar_Compra(int Id_Compra)
        {
            Compra_DAO.Guardar_Proveedor(Id_Compra);
            Compra_DAO.Guardar_Compra(Id_Compra);
            Compra_DAO.Procesar_Detalles(Id_Compra);
        }
    }
}