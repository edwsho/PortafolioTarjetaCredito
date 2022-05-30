using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Domain.Interfaces
{
    public interface IList<TEntity, TEntityID>
    {
        List<TEntity> List();

        TEntity GetbyID(TEntityID _entity);
    }
}
