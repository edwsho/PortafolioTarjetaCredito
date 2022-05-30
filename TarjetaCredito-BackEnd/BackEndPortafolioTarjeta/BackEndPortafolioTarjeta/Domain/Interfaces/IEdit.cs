using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Domain.Interfaces
{
    public  interface IEdit<TEntity>
    {
        void Edit(TEntity _entity);
    }
}
