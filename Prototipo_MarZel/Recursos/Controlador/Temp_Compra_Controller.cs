using System.Data;
using System.Windows.Forms;

namespace Prototipo_MarZel
{
    public class Temp_Compra_Controller
    {
        private Temp_Compra_Base Temp_Compra_DAO;

        public Temp_Compra_Controller()
        {
            Temp_Compra_DAO = new Temp_Compra_DAO();
        }

        public void Eliminar_Registros_Temporales()
        {
            Temp_Compra_DAO.Eliminar_Registros_Temporales();
        }

        public void Agregar_Compra(int Id_Compra)
        {
            Temp_Compra_DAO.Agregar_Compra(Id_Compra);
        }

        public void Capturar_Detalles(int Id_Compra)
        {
            Temp_Compra_DAO.Capturar_Detalles(Id_Compra);
        }

        public DataTable Cargar_Detalles(int Id_Compra)
        {
            return Temp_Compra_DAO.Cargar_Detalles(Id_Compra);
        }

        public DataTable Cargar_Compra(int Id_Compra)
        {
            return Temp_Compra_DAO.Cargar_Compra(Id_Compra);
        }

        public bool Buscar_En_Detalles_Compra(string Codigo_Barra)
        {
            return Temp_Compra_DAO.Buscar_En_Detalles_Compra(Codigo_Barra);
        }

        public DataTable Cargar_Producto(string Codigo_Barra)
        {
            return Temp_Compra_DAO.Cargar_Producto(Codigo_Barra);
        }

        public bool Buscar_En_Productos(string Codigo_Barra)
        {
            return Temp_Compra_DAO.Buscar_En_Productos(Codigo_Barra);
        }

        public void Agregar_Detalle(int Id_Compra, int? Id_Producto, string Codigo_Barra, string Descripcion, int Cantidad,
            decimal Costo, decimal Descuento, decimal Importe, int Id_ISV, decimal Precio_Completo, decimal Precio_Unitario,
            int Id_Categoria, DateTime Fecha_Creacion)
        {
            Temp_Compra_DAO.Agregar_Detalle(Id_Compra, Id_Producto, Codigo_Barra, Descripcion, Cantidad, Costo, Descuento,
                Importe, Id_ISV, Precio_Completo, Precio_Unitario, Id_Categoria, Fecha_Creacion);
        }

        public void Modificar_Proveedor(int Id_Compra, int? Id_Proveedor, string RTN, string Nombre, string Direccion, string Celular)
        {
            Temp_Compra_DAO.Modificar_Proveedor(Id_Compra, Id_Proveedor, RTN, Nombre, Direccion, Celular);
        }

        public bool Existe_Factura(string Factura)
        {
            return Temp_Compra_DAO.Existe_Factura(Factura);
        }

        public void Completar_Compra(int Id_Compra, string Factura, DateTime Fecha)
        {
            Temp_Compra_DAO.Completar_Compra(Id_Compra, Factura, Fecha);
        }

        public void Asignar_ID_Proveedor(int Id_Compra, int Id_Proveedor)
        {
            Temp_Compra_DAO.Asignar_ID_Proveedor(Id_Compra,Id_Proveedor);
        }

        public void Asignar_ID_Producto(int Id_Compra, int Id_Producto, string Codigo_Barra)
        {
            Temp_Compra_DAO.Asignar_ID_Producto(Id_Compra, Id_Producto, Codigo_Barra);
        }

        public void Modificar_Detalle(int Id_Compra, int? Id_Producto, string Codigo_Barra, string Descripcion, int Cantidad,
            decimal Costo, decimal Descuento, decimal Importe, int Id_ISV, decimal Precio_Completo, decimal Precio_Unitario,
            int Id_Categoria, DateTime Fecha_Creacion)
        {
            Temp_Compra_DAO.Modificar_Detalle(Id_Compra, Id_Producto, Codigo_Barra, Descripcion, Cantidad, Costo, Descuento,
                Importe, Id_ISV, Precio_Completo, Precio_Unitario, Id_Categoria, Fecha_Creacion);
        }
    }
}