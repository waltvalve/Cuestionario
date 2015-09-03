using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cuestionario
    {
       public int IDCuestionario    { get; set; }
        public int IDUsuario       { get; set; }
        public string Titulo   { get; set; }
        public string Descripción { get; set; }
        public string Estado { get; set; }
        public string Abierto { get; set; }
        public string Realizado { get; set; }
        public string Hora_Emision { get; set; }
        public string Dia_Emision { get; set; }
        public string Hora_Termino { get; set; }
        public string Dia_Termino { get; set; }

    }
}
