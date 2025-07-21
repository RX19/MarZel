using System.Data;

namespace Prototipo_MarZel
{
    public class Temp_Detalle_Compra
    {
        public int? ID_COMPRA { get; set; }

        public int? ID_PRODUCTO { get; set; }

        public string? CODIGO_BARRA { get; set; }

        public string? DESCRIPCION { get; set; }

        public int? CANTIDAD { get; set; }

        public decimal? COSTO { get; set; }

        public int? ID_ISV { get; set; }

        public decimal? DESCUENTO { get; set; }

        public decimal? IMPORTE { get; set; }

        public decimal? PRECIO_COMPLETO { get; set; }

        public decimal? PRECIO_UNITARIO { get; set; }

        public int? ID_CATEGORIA { get; set; }

        public DateTime? FECHA_CREACION { get; set; }
    }
}