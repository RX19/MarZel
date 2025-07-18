using System.Data;

namespace Prototipo_MarZel
{
    public class Proveedor
    {
        public int ID_PROVEEDOR { get; set; }

        public string RTN { get; set; } = string.Empty;

        public string NOMBRE { get; set; } = string.Empty; 

        public string DIRECCION { get; set; } = string.Empty;

        public string CELULAR { get; set; } = string.Empty;

        public int CANT_COMPRAS { get; set; }

        public decimal IMPORTE { get; set; }

    }
}
