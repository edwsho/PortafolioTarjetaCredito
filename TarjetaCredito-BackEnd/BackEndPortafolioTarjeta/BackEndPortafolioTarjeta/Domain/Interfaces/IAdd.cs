using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Domain.Interfaces
{
    public interface IAdd<TEntity>
    {
        TEntity Add(TEntity _entity);
    }
}
