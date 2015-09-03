using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public interface IRepositorio<T> : IRepositorio_Lectura<T>
    {
        bool Adicionar(T ao_entidad);
        bool Actualizar(T ao_entidad);
    }
}
