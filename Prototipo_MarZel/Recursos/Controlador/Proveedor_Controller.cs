using Prototipo_MarZel.Recursos.Modelos;
using System.Data;

namespace Prototipo_MarZel
{
    public class Proveedor_Controller
    {
        private Proveedor_Base Proveedor_DAO;

        public Proveedor_Controller()
        {
            Proveedor_DAO = new Proveedor_DAO();
        }

        public DataTable Cargar_Proveedores()
        {
            return Proveedor_DAO.Cargar_Proveedores();
        }

        public void Eliminar_Proveedor(int Id_Proveedor) 
        {
            Proveedor_DAO.Eliminar_Proveedor(Id_Proveedor);
        }

        public DataTable Buscar_En_Proveedores(string filtro)
        {
            return Proveedor_DAO.Buscar_En_Proveedores(filtro);
        }

        public void Agregar_Proveedor(string RTN, string Nombre, string Direccion, string Celular, int Cant_Compras, decimal Importe)
        {
            Proveedor_DAO.Agregar_Proveedor(RTN, Nombre, Direccion, Celular, Cant_Compras, Importe);
        }

        public void Modificar_Proveedor(int Id_Proveedor, string RTN, string Nombre, string Direccion, string Celular)
        {
            Proveedor_DAO.Modificar_Proveedor(Id_Proveedor, RTN, Nombre, Direccion, Celular);
        }

        public DataTable Cargar_Proveedor(int Id_Proveedor)
        {
            return Proveedor_DAO.Cargar_Proveedor(Id_Proveedor);
        }

        public DataTable Cargar_Proveedor(string RTN)
        {
            return Proveedor_DAO.Cargar_Proveedor(RTN);
        }

        public bool Existe_RTN(string RTN)
        {
            return Proveedor_DAO.Existe_RTN(RTN);
        }
    }
}