using System;
using System.Data;

namespace Prototipo_MarZel.Recursos.Modelos
{
    public abstract class Movimiento_Inventario_Base
    {
        public static string Tabla = "TBL_MOVIMIENTOS_INVENTARIO";

        public abstract DataTable ObtenerTodos();
        // Puedes agregar más métodos abstractos aquí si lo necesitas en el futuro
    }

    public class Movimiento_Inventario
    {
        public int ID_MOVIMIENTO { get; set; }
        public int ID_PRODUCTO { get; set; }
        public string TIPO_MOVIMIENTO { get; set; } = string.Empty;
        public int CANTIDAD { get; set; }
        public DateTime FECHA { get; set; }
        public string USUARIO { get; set; } = string.Empty;
        // Agrega más propiedades si tu tabla tiene más columnas
    }
}