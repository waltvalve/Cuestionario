using Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Datos.EF.Repositorios
{
    public class Repositorio_Generico<T> : IRepositorio<T> where T : class
    {
     
            Contextos.Contexto io_contexto;
            public IDbSet<T> EntidadConjunto { get; set; }
            public Repositorio_Generico(Contextos.Contexto ao_contexto)
            {
                this.io_contexto = ao_contexto;
                this.EntidadConjunto = ao_contexto.Set<T>();
            }
            public Repositorio_Generico()
                : this(new Contextos.Contexto(/*"Conexion_SQL"*/))
                //: this(new Contextos.Contexto("Conexion_ORACLE"))
            {
                //this.Entidad = System.Reflection.Assembly.GetAssembly(typeof(C)).CreateInstance(typeof(C));
            }

            public T ObtenerPorCodigo(params object[] ao_llaves)
            {
                return EntidadConjunto.Find(ao_llaves);
            }


        public IList<T> ObtenerPorExpresion(Expression<Func<T, bool>> ao_llaves = null, string as_incluir = null, byte aby_limite = 0)
            {
                if (ao_llaves == null)
                    return EntidadConjunto.ToList();
                else
                    return EntidadConjunto.Where(ao_llaves).ToList();
            }
            public bool Adicionar(T ao_entidad)
            {
                EntidadConjunto.Add(ao_entidad);
                io_contexto.SaveChanges();
                return true;
            }

            public bool Actualizar(T ao_entidad)
            {
                EntidadConjunto.Add(ao_entidad);
                return true;
            }

        }
    }
