using System.Data;

namespace Prototipo_MarZel
{
    public class Producto_Controller
    {
        private Producto_Base Producto_DAO;

        public Producto_Controller()
        {
            Producto_DAO = new Producto_DAO();
        }

        public DataTable ObtenerProductos()
        {
            return Producto_DAO.ObtenerProductos();
        }

        public DataTable ObtenerProductosPorDescripcion()
        {
            return Producto_DAO.ObtenerProductos();
        }

        public DataTable ObtenerProducto(string filtro)
        {
            return Producto_DAO.ObtenerProducto(filtro);
        }

        public void ModificarProducto(string codigo, string desc, int id, decimal PU, decimal PC)
        {
            Producto_DAO.ModificarProducto(codigo, desc, id, PU, PC);
        }

        public DataTable Cargar_Producto(string Codigo_Barra)
        {
            return Producto_DAO.Cargar_Producto(Codigo_Barra);
        }

        public DataTable Cargar_Producto(int Id_Prodcuto)
        {
            return Producto_DAO.Cargar_Producto(Id_Prodcuto);
        }

        public int? Buscar_Id_Producto(string Codigo_Barra)
        {
            return Producto_DAO.Buscar_Id_Producto(Codigo_Barra);
        }

        public void Agregar_Producto(string Codigo_Barra, string Descripcion, int Id_ISV, decimal Precio_Completo,
            decimal Precio_Unitario, int Id_Categoria, int Existencia)
        {
            Producto_DAO.Agregar_Producto(Codigo_Barra, Descripcion, Id_ISV, Precio_Completo,
            Precio_Unitario, Id_Categoria, Existencia);
        }

        public void Modificar_Producto(int Id_Producto, string Codigo_Barra, string Descripcion, int Id_ISV, decimal Precio_Completo,
            decimal Precio_Unitario, int Id_Categoria, int Existencia)
        {
            Producto_DAO.Modificar_Producto(Id_Producto, Codigo_Barra, Descripcion, Id_ISV, Precio_Completo,
            Precio_Unitario, Id_Categoria, Existencia);
        }

        public void Disminuir_Existencia(int Id_Producto, int Existencia)
        {
            Producto_DAO.Disminuir_Existencia(Id_Producto, Existencia);
        }

        public bool existeProducto(string Codigo_Barra)
        {
            return Producto_DAO.existeProducto(Codigo_Barra);
        }
    }
}