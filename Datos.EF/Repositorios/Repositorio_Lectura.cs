using Datos.EF.Contextos;
using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EF.Repositorios
{
    public class Repositorio_Lectura<T> : IRepositorio_Lectura<T> where T : class
    {
        public IDbSet<T> Entidad { get; set; }
        public Repositorio_Lectura(Contexto ao_contexto)
        {
            this.Entidad = ao_contexto.Set<T>();
        }
        //public Repositorio_Lectura() : this(new Contexto("Conexion_ORACLE"))
        public Repositorio_Lectura() : this(new Contexto(/*"Conexion_SQL"*/))
        {
            //this.Entidad = System.Reflection.Assembly.GetAssembly(typeof(C)).CreateInstance(typeof(C));
        }
        public T ObtenerPorCodigo(params object[] ao_llaves)
        {
            return Entidad.Find(ao_llaves);
        }

        public IList<T> ObtenerPorExpresion(System.Linq.Expressions.Expression<Func<T, bool>> ao_llaves, string as_incluir, byte aby_limite)
        {
            return Entidad.Where(ao_llaves).ToList();
        }
    }
}
