using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pregunta
    {
        public int IDPregunta { get; set; }
        public int IDCuestionario { get; set; }
        public string Descripción { get; set; }
        public string Estado { get; set; }
    }
}
