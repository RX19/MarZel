using System.Data;

namespace Prototipo_MarZel
{
    public class Tipo_ISV_Controller
    {
        private readonly Tipo_ISV_DAO dao = new Tipo_ISV_DAO();

        public List<Tipo_ISV> Cargar_Tipos_ISV()
        {
            return dao.Cargar_Tipos_ISV();
        }
    }
}