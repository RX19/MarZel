using System;
using System.Data;

namespace Prototipo_MarZel.Recursos.Modelos
{
    public abstract class Modelo_Movimiento_Inventario
    {
        public static string Tabla = "TBL_MOVIMIENTOS_INVENTARIO";

        public abstract DataTable ObtenerTodos();
        
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