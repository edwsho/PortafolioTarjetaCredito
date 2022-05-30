using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Domain.Interfaces.Repository
{
    public interface IRepositoryBase<TEntity, TEntityID> : IAdd<TEntity>, IEdit<TEntity>, IDelete<int>, IList<TEntity, int>, ITransaction
    {


    }
}
