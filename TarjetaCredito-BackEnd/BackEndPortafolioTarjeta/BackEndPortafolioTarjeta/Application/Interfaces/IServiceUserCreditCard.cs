using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarjetaCredito.Domain.Interfaces;

namespace TarjetaCredito.Application.Interfaces
{
    public interface IServiceUserCreditCard<TEntity, TEntityID> : IAdd<TEntity>, IEdit<TEntity>, IDelete<TEntity>, IList<TEntity, TEntityID>
    {
        // void Anular(TEntityID _tEntityID);
    }
}
