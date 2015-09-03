using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alternativa
    {
        public int IDAlternativa { get; set; }
        public int IDPregunta { get; set; }
        public string Descripción { get; set; }
        public string Respuesta { get; set; }

    }
}
