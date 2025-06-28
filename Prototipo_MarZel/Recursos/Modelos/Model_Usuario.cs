using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototipo_MarZel.Recursos.Modelos
{
    public class Model_Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Celular { get; set; }
        public int IdTipoUsuario { get; set; }
        public bool Estado { get; set; } = true;

    }
}
