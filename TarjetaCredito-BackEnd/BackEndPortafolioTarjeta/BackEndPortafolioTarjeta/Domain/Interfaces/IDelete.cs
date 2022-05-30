using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Domain.Interfaces
{
    public interface IDelete<TEntity>
    {
        void Delete(int _entity);
    }
}
