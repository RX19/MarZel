using System.Data;

namespace Prototipo_MarZel
{
    public class Temp_Compra_Controller
    {
        private readonly Temp_Compra_DAO dao = new Temp_Compra_DAO();

        public void Eliminar_Registros_Temporales()
        {
            dao.Eliminar_Registros_Temporales();
        }

        public void Agregar_Compra()
        {
            dao.Agregar_Compra();
        }

        public Temp_Compra Cargar_Compra()
        {
            return dao.Cargar_Compra();
        }

        public List<Temp_Detalle_Compra> Cargar_Detalles(int Id_Compra)
        {
            return dao.Cargar_Detalles(Id_Compra);
        }

        public bool Buscar_En_Detalles_Compra(string codigo_barra)
        {
            return dao.Buscar_En_Detalles_Compra(codigo_barra);
        }

        public bool Buscar_En_Productos(string codigo_barra)
        {
            return dao.Buscar_En_Productos(codigo_barra);
        }
        public void Agregar_Nuevo_Detalle(Temp_Detalle_Compra Detalle_Compra)
        {
            dao.Agregar_Nuevo_Detalle(Detalle_Compra);
        }
    }
}