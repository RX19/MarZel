using System.Data;

namespace Prototipo_MarZel
{
    public abstract class Cliente_Base
    {
        public static string Tabla = "TBL_CLIENTES";

        public abstract DataTable Cargar_Clientes();

        public abstract void Eliminar_Cliente(int Id_Cliente);

        public abstract DataTable Buscar_En_Clientes(string filtro);

        public abstract void Agregar_Cliente(string RTN, string Nombre, string Direccion, string Celular, int Cant_Ventas, decimal Importe);

        public abstract void Modificar_Cliente(int Id_Cliente, string RTN, string Nombre, string Direccion, string Celular);

        public abstract void Modificar_Cliente(int Id_Cliente, string RTN, string Nombre, string Direccion, string Celular, int Cant_Ventas, decimal Importe);

        public abstract DataTable Cargar_Cliente(int Id_Cliente);

        public abstract DataTable Cargar_Cliente(string RTN);

        public abstract bool Existe_RTN(string RTN);
    }

    public class model_cliente
    {
        public string RTN { get; set; } = string.Empty;
        public string Nombre { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string Celular { get; set; } = string.Empty;
    }
}