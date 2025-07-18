using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_MarZel.Recursos.Modelos
{
    public class Model_Usuario
    {
        public int ID_USUARIO { get; set; } 
        public string IDENTIDAD { get; set; } = string.Empty;
        public string NOMBRE { get; set; } = string.Empty;
        public string CORREO { get; set; } = string.Empty;
        public string USUARIO { get; set; } = string.Empty;
        public string CONTRASENA { get; set; } = string.Empty;
        public string CELULAR { get; set; } = string.Empty;
        public int ID_TIPO { get; set; }
        public int ID_ESTADO { get; set; }

    }
}
