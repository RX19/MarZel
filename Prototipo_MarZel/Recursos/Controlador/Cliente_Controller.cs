using Prototipo_MarZel.Recursos.Modelos;
using System.Data;

namespace Prototipo_MarZel
{
    public class Cliente_Controller
    {
        private Cliente_Base Cliente_DAO;

        public Cliente_Controller()
        {
            Cliente_DAO = new Cliente_DAO();
        }

        public DataTable Cargar_Clientes()
        {
            return Cliente_DAO.Cargar_Clientes();
        }

        public void Eliminar_Cliente(int Id_Cliente)
        {
            Cliente_DAO.Eliminar_Cliente(Id_Cliente);
        }

        public DataTable Buscar_En_Clientes(string filtro)
        {
            return Cliente_DAO.Buscar_En_Clientes(filtro);
        }

        public void Agregar_Cliente(string RTN, string Nombre, string Direccion, string Celular, int Cant_Compras, decimal Importe)
        {
            Cliente_DAO.Agregar_Cliente(RTN, Nombre, Direccion, Celular, Cant_Compras, Importe);
        }

        public void Modificar_Cliente(int Id_Cliente, string RTN, string Nombre, string Direccion, string Celular)
        {
            Cliente_DAO.Modificar_Cliente(Id_Cliente, RTN, Nombre, Direccion, Celular);
        }

        public void Modificar_Cliente(int Id_Cliente, string RTN, string Nombre, string Direccion, string Celular, int Cant_Compras, decimal Importe)
        {
            Cliente_DAO.Modificar_Cliente(Id_Cliente, RTN, Nombre, Direccion, Celular, Cant_Compras, Importe);
        }

        public DataTable Cargar_Cliente(int Id_Cliente)
        {
            return Cliente_DAO.Cargar_Cliente(Id_Cliente);
        }

        public DataTable Cargar_Cliente(string RTN)
        {
            return Cliente_DAO.Cargar_Cliente(RTN);
        }

        public bool Existe_RTN(string RTN)
        {
            return Cliente_DAO.Existe_RTN(RTN);
        }
    }
}