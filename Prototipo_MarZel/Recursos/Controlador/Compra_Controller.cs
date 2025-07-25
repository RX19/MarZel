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

        public DataTable Cargar_Compra(string Factura)
        {
            return Compra_DAO.Cargar_Compra(Factura);
        }

        public void Agregar_Detalle(int Id_Compra, int Id_Producto, int Cantidad, decimal Costo, decimal Descuento, decimal Importe)
        {
            Compra_DAO.Agregar_Detalle(Id_Compra, Id_Producto, Cantidad, Costo, Descuento, Importe);
        }

        public void Agregar_Compra(int Id_Compra)
        {
            Compra_DAO.Guardar_Proveedor();
            Compra_DAO.Guardar_Compra();
            Compra_DAO.Procesar_Detalles();
        }
    }
}