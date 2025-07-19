using System.Data;

namespace Prototipo_MarZel
{
    public class Temp_Compra
    {

        public int? ID_COMPRA { get; set; }

        public int? ID_PROVEEDOR { get; set; }

        public string? RTN { get; set; }

        public string? NOMBRE { get; set; }

        public string? DIRECCION { get; set; }

        public string? CELULAR { get; set; }

        public DateTime? FECHA { get; set; }

        public string? FACTURA { get; set; }

        public decimal? SUBTOTAL { get; set; }

        public decimal? GRAVADO { get; set; }

        public decimal? ISV { get; set; }

        public decimal? EXENTO { get; set; }

        public decimal? TOTAL { get; set; }
    }
}