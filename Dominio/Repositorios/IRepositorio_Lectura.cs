using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IRepositorio_Lectura<T>
    {
        T ObtenerPorCodigo(params object[] ao_llaves);
        IList<T> ObtenerPorExpresion(Expression<Func<T, bool>> ao_llaves = null, string as_incluir = null, byte aby_limite = 0);
    }
}
