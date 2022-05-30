using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Domain.Interfaces.Repository
{
    public  interface IRepositoryUserCreditCard<TEntity, TEntityID> : IAdd<TEntity>, IEdit<TEntity>, IDelete<TEntity>, IList<TEntity, TEntityID>, ITransaction
    {
        // Se pueden colocar metodos especificos para realizar operaciones dentro del contexto UserCreaditCard, como Bloquear la Tarjeta, anularla etc

        // void Anular(TEntityID _tEntityID);


    }
}
