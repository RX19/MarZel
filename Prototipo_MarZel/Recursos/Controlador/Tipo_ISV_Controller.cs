using Prototipo_MarZel.Recursos.Modelos;
using System.Data;

namespace Prototipo_MarZel
{
    public class Tipo_ISV_Controller
    {
        private Tipo_ISV_Base Tipo_ISV_DAO;

        public Tipo_ISV_Controller()
        {
            Tipo_ISV_DAO = new Tipo_ISV_DAO();
        }
        
        public DataTable Cargar_Tipos_ISV()
        {
            return Tipo_ISV_DAO.Cargar_Tipos_ISV();
        }

    }
}