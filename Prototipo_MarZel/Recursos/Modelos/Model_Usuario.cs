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
        public string IDENTIDAD { get; set; }
        public string NOMBRE { get; set; }
        public string CORREO { get; set; }
        public string USUARIO { get; set; }
        public string CONTRASENA { get; set; }
        public string CELULAR { get; set; }
        public int ID_TIPO { get; set; }
        public int ID_ESTADO { get; set; }

    }
}
