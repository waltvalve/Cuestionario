using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int IDUsuario { get; set; }
        public int IDRol { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Estado { get; set; }
        public string Foto { get; set; }

    }
}
