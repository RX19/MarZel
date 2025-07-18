using System.Data;

namespace Prototipo_MarZel
{
    public class Compra
    {

        public int ID_COMPRA { get; set; }

        public int ID_PROVEEDOR { get; set; }

        public string NOMBRE_PROVEEDOR { get; set; } = string.Empty;
        
        public DateTime FECHA { get; set; }

        public string FACTURA { get; set; } = string.Empty;

        public decimal SUBTOTAL { get; set; }
       
        public decimal GRAVADO { get; set; }
        
        public decimal ISV { get; set; }
        
        public decimal EXENTO { get; set; }
        
        public decimal TOTAL { get; set; }
    }
}
