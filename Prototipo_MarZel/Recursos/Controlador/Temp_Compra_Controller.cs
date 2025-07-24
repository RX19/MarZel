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
    }
}
        /*public Temp_Compra Cargar_Calculos()
        {
            return Temp_Compra_DAO.Cargar_Calculos();
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
}*/