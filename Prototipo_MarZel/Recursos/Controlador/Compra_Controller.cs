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

        public DataTable Cargar_Compra(int Id_Compra)
        {
            return Compra_DAO.Cargar_Compra(Id_Compra);
        }

        public void Agregar_Detalle(int Id_Compra, int Id_Producto, int Cantidad, decimal Costo, decimal Descuento, decimal Importe)
        {
            Compra_DAO.Agregar_Detalle(Id_Compra, Id_Producto, Cantidad, Costo, Descuento, Importe);
        }

        public void Agregar_Compra()
        {
            Compra_DAO.Guardar_Proveedor();
            Compra_DAO.Guardar_Compra();
            Compra_DAO.Guardar_Detalles();
        }

        public DataTable Cargar_Detalles(int Id_Compra)
        {
            return Compra_DAO.Cargar_Detalles(Id_Compra);
        }

        public void Eliminar_Detalles(int Id_Compra)
        {
            Compra_DAO.Eliminar_Detalles(Id_Compra);
        }

        public bool Buscar_En_Detalles_Compra(string Codigo_Barra)
        {
            return Compra_DAO.Buscar_En_Detalles_Compra(Codigo_Barra);
        }

        public void Actualizar_Compra(int Id_Compra)
        {
            Compra_DAO.Actualizar_Proveedor(Id_Compra);
            Compra_DAO.Actualizar_Compra(Id_Compra);
            Compra_DAO.Actualizar_Detalles(Id_Compra);
        }

    }
}