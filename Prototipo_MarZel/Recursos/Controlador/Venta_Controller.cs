using Prototipo_MarZel.Recursos.Modelos;
using System.Data;

namespace Prototipo_MarZel
{
    public class Venta_Controller
    {
        private Venta_Base Venta_DAO;

        public Venta_Controller()
        {
            Venta_DAO = new Venta_DAO();
        }

        public DataTable Cargar_Ventas()
        {
            return Venta_DAO.Cargar_Ventas();
        }

        public DataTable Buscar_En_Ventas(string filtro)
        {
            return Venta_DAO.Buscar_En_Ventas(filtro);
        }

        public void Guardar_Venta()
        {
            Venta_DAO.Guardar_Cliente();
            Venta_DAO.Guardar_Venta();
            Venta_DAO.Guardar_Detalles();
        }

        public DataTable Cargar_Venta(string Factura)
        {
            return Venta_DAO.Cargar_Venta(Factura);
        }

        public void Agregar_Detalle(int Id_Venta, int Id_Producto, int Cantidad, decimal Precio, decimal Descuento, decimal Importe)
        {
            Venta_DAO.Agregar_Detalle(Id_Venta, Id_Producto, Cantidad, Precio, Descuento, Importe);
        }

        public void Actualizar_Venta(int Id_Venta)
        {
            Venta_DAO.Actualizar_Cliente(Id_Venta);
            Venta_DAO.Actualizar_Venta(Id_Venta);
            Venta_DAO.Actualizar_Detalles(Id_Venta);
        }

        public DataTable Cargar_Venta(int Id_Venta)
        {
            return Venta_DAO.Cargar_Venta(Id_Venta);
        }


        public DataTable Cargar_Detalles(int Id_Venta)
        {
            return Venta_DAO.Cargar_Detalles(Id_Venta);
        }

        public void Eliminar_Detalles(int Id_Venta)
        {
            Venta_DAO.Eliminar_Detalles(Id_Venta);
        }

        public void Eliminar_Venta(int Id_Venta)
        {
            Venta_DAO.Eliminar_Venta(Id_Venta);
        }
    }
}