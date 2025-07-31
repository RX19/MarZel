using System.Data;
using System.Windows.Forms;

namespace Prototipo_MarZel
{
    public class Temp_Venta_Controller
    {
        private Temp_Venta_Base Temp_Venta_DAO;

        public Temp_Venta_Controller()
        {
            Temp_Venta_DAO = new Temp_Venta_DAO();
        }

        public void Eliminar_Registros_Temporales()
        {
            Temp_Venta_DAO.Eliminar_Registros_Temporales();
        }

        public void Agregar_Venta(int Id_Usuario, string Nombre_Usuario, int Id_Venta)
        {
            Temp_Venta_DAO.Agregar_Venta(Id_Usuario, Nombre_Usuario, Id_Venta);
        }

        public void Capturar_Detalles(int Id_Venta)
        {
            Temp_Venta_DAO.Capturar_Detalles(Id_Venta);
        }

        public DataTable Cargar_Detalles()
        {
            return Temp_Venta_DAO.Cargar_Detalles();
        }

        public DataTable Cargar_Venta()
        {
            return Temp_Venta_DAO.Cargar_Venta();
        }

        public bool Buscar_En_Detalles_Venta(string Codigo_Barra)
        {
            return Temp_Venta_DAO.Buscar_En_Detalles_Venta(Codigo_Barra);
        }

        public bool Buscar_En_Productos(string Codigo_Barra)
        {
            return Temp_Venta_DAO.Buscar_En_Productos(Codigo_Barra);
        }

        public void Agregar_Detalle(int Id_Venta, int Id_Producto, string Codigo_Barra,
            string Descripcion, int Cantidad, decimal Precio, decimal Precio_Completo, decimal Precio_Unitario,
            int Id_ISV, decimal Descuento, decimal Importe, int Existencia, DateTime Fecha_Creacion)
        {
            Temp_Venta_DAO.Agregar_Detalle(Id_Venta, Id_Producto, Codigo_Barra,
            Descripcion, Cantidad, Precio, Precio_Completo, Precio_Unitario,
            Id_ISV, Descuento, Importe, Existencia, Fecha_Creacion);
        }

        public DataTable Cargar_Producto(string Codigo_Barra)
        {
            return Temp_Venta_DAO.Cargar_Producto(Codigo_Barra);
        }

        public void Actualizar_Detalle(string Codigo_Barra, int Cantidad, decimal Precio,
            decimal Descuento, decimal Importe, int Existencia, DateTime Fecha_Creacion)
        {
            Temp_Venta_DAO.Actualizar_Detalle(Codigo_Barra, Cantidad, Precio,
                Descuento, Importe, Existencia, Fecha_Creacion);
        }

        public void Completar_Venta()
        {
            Temp_Venta_DAO.Completar_Venta();
        }
        public void Asignar_Id_Cliente(int Id_Cliente)
        {
            Temp_Venta_DAO.Asignar_Id_Cliente(Id_Cliente);
        }

        public void Asignar_Id_Venta(int Id_Venta)
        {
            Temp_Venta_DAO.Asignar_Id_Venta(Id_Venta);
        }

        public void Modificar_Cliente(int? Id_Cliente, string Rtn, string Nombre, string Direccion, string Celular)
        {
            Temp_Venta_DAO.Modificar_Cliente(Id_Cliente, Rtn, Nombre, Direccion, Celular);
        }

        public void Modificar_Detalle(int Id_Venta, int Id_Producto, int Cantidad, decimal Precio, decimal Descuento,
            decimal Importe, int Existencia, DateTime Fecha_Creacion)
        {
            Temp_Venta_DAO.Modificar_Detalle(Id_Venta, Id_Producto, Cantidad, Precio, Descuento, Importe, Existencia, Fecha_Creacion);
        }

        public void Eliminar_Detalle(string Codigo_Barra)
        {
            Temp_Venta_DAO.Eliminar_Detalle(Codigo_Barra);
        }

        /*public bool Existe_Factura(string Factura)
        {
            return Temp_Venta_DAO.Existe_Factura(Factura);
        }

        public void Completar_Venta(int Id_Venta, string Factura, DateTime Fecha)
        {
            Temp_Venta_DAO.Completar_Venta(Id_Venta, Factura, Fecha);
        }

        public void Asignar_ID_Producto(int Id_Producto, string Codigo_Barra)
        {
            Temp_Venta_DAO.Asignar_ID_Producto(Id_Producto, Codigo_Barra);
        }

        

        public void Modificar_Detalle(int Id_Venta, int? Id_Producto, string Codigo_Barra_1, string Codigo_Barra, string Descripcion, int Cantidad,
            decimal Costo, decimal Descuento, decimal Importe, int Id_ISV, decimal Precio_Completo, decimal Precio_Unitario,
            int Id_Categoria, DateTime Fecha_Creacion)
        {
            Temp_Venta_DAO.Modificar_Detalle(Id_Venta, Id_Producto, Codigo_Barra_1, Codigo_Barra, Descripcion, Cantidad, Costo, Descuento,
                Importe, Id_ISV, Precio_Completo, Precio_Unitario, Id_Categoria, Fecha_Creacion);
        }*/


    }
}