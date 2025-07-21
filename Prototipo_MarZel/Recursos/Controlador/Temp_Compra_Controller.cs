using System.Data;
using System.Windows.Forms;

namespace Prototipo_MarZel
{
    public class Temp_Compra_Controller
    {
        private readonly Temp_Compra_DAO Temp_Compra_DAO = new Temp_Compra_DAO();
        
        public void Eliminar_Registros_Temporales()
        {
            Temp_Compra_DAO.Eliminar_Registros_Temporales();
        }

        public void Agregar_Compra(Compra Compra)
        {
            Temp_Compra_DAO.Agregar_Compra(Compra);
        }

        public void Capturar_Detalles(Compra Compra)
        {
            Temp_Compra_DAO.Capturar_Detalles(Compra);
        }

        public List<Temp_Detalle_Compra> Cargar_Detalles()
        {
            return Temp_Compra_DAO.Cargar_Detalles();
        }

        public Temp_Compra Cargar_Calculos()
        {
            return Temp_Compra_DAO.Cargar_Calculos();
        }

        public bool Buscar_En_Detalles_Compra(string codigo_barra)
        {
            return Temp_Compra_DAO.Buscar_En_Detalles_Compra(codigo_barra);
        }


        public Temp_Detalle_Compra Cargar_Producto(string Codigo_Barra)
        {
            return Temp_Compra_DAO.Cargar_Producto(Codigo_Barra);
        }

        public bool Buscar_En_Productos(string codigo_barra)
        {
            return Temp_Compra_DAO.Buscar_En_Productos(codigo_barra);
        }

        public void Agregar_Detalle(Temp_Detalle_Compra Detalle_Compra)
        {
            Temp_Compra_DAO.Agregar_Detalle(Detalle_Compra);
        }

        public Temp_Compra Cargar_Compra()
        {
            return Temp_Compra_DAO.Cargar_Compra();
        }

        public void Actualizar_Proveedor(Temp_Compra compra)
        {
            Temp_Compra_DAO.Actualizar_Proveedor(compra);
        }
    }
}