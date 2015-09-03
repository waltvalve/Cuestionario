using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EF.Contextos
{
    public class Contexto_Base<T> : DbContext where T : DbContext
    {
        public Contexto_Base(string as_conexion) : base(as_conexion)
        {
            Database.SetInitializer<T>(null);
            Database.Log = s => System.Diagnostics.Debug.WriteLine(s);
        }

    }
}
