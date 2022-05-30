using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarjetaCredito.Application.Interfaces;
using TarjetaCredito.Domain.DomainObject;
using TarjetaCredito.Domain.Interfaces.Repository;

namespace TarjetaCredito.Application.Services
{
    public class UserCreditCardServices : IServiceBase<UserCreditCard, int>
    {
        //Aca se crearian los Casos de uso de nuestro proyecto ya que corresponde a la implementacion
        //de las interfaces de los servicios usando la capa de Dominio y Aplicaciones en si.

        private readonly IRepositoryBase<UserCreditCard, int> repoUserCreditCard;

        public UserCreditCardServices(IRepositoryBase<UserCreditCard, int> _repoUserCreditCard)
        {
            repoUserCreditCard = _repoUserCreditCard;
        }

        public UserCreditCard Add(UserCreditCard _entity)
        {
            if (_entity == null)
                throw new ArgumentNullException("La tarjeta de Credito es requerida!");

            var _result =  repoUserCreditCard.Add(_entity);
            repoUserCreditCard.SaveAllChanges();
            return _result;
          
        }

        public void Delete(int _entity)
        {
            if (_entity == null)
                throw new ArgumentNullException("La tarjeta de Credito es requerida!");

            repoUserCreditCard.Delete(_entity);
            repoUserCreditCard.SaveAllChanges();
        }

        public void Edit(UserCreditCard _entity)
        {
            if (_entity == null)
                throw new ArgumentNullException("La tarjeta de Credito es requerida!");

            repoUserCreditCard.Edit(_entity);
            repoUserCreditCard.SaveAllChanges();

        }

        public UserCreditCard GetbyID(int _entity)
        {
            if (_entity == null)
                throw new ArgumentNullException("La tarjeta de Credito es requerida!");

            var _result = repoUserCreditCard.GetbyID(_entity);
            repoUserCreditCard.SaveAllChanges();
            return _result;

        }

        public List<UserCreditCard> List()
        {
            var _result = repoUserCreditCard.List();
            repoUserCreditCard.SaveAllChanges();
            return _result;
        }
    }
}
