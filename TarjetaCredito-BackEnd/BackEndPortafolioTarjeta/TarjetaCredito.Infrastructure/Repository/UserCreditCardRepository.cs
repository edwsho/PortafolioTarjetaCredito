using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarjetaCredito.Domain.DomainObject;
using TarjetaCredito.Domain.Interfaces.Repository;

namespace TarjetaCredito.Infrastructure.Repository
{
    public class UserCreditCardRepository : IRepositoryBase<UserCreditCard, int>
    {

        private UserCreditCardDbContext _context;

        public UserCreditCardRepository(UserCreditCardDbContext context)
        {
            _context = context;
        }


        public UserCreditCard Add(UserCreditCard _entity)
        {
            //_entity.Id = Guid.NewGuid();              //Me aseguro que el Id es unico
            _context.userCreditCards.Add(_entity);    //Agrego la Entidad userCreditCards que es el DbSet en la clase UserCreditCardDbContext
            return _entity;
        }

        public void Delete(int _entity)
        {
            var _producto = _context.userCreditCards.Where(c => c.Id == _entity).FirstOrDefault();
            if (_producto != null)
            {
               _context.userCreditCards.Remove(_producto);
            }
        }

        public void Edit(UserCreditCard _entity)
        {
            var _producto = _context.userCreditCards.Where(c => c.Id == _entity.Id).FirstOrDefault();
            if (_producto != null)
            {
                _producto.Id = _entity.Id;
                _producto.Nombre = _entity.Nombre;
                _producto.numeroTarjeta = _entity.numeroTarjeta;
                _producto.fechaExp = _entity.fechaExp;
                _producto.cvv = _entity.cvv;

                _context.Entry(_producto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }

        public UserCreditCard GetbyID(int _entity)
        {
            var _producto = _context.userCreditCards.Where(c => c.Id == _entity).FirstOrDefault();
            return _producto;
            
        }

        public List<UserCreditCard> List()
        {
            return _context.userCreditCards.ToList();
        }

        public void SaveAllChanges()
        {
            _context.SaveChanges();
        }
    }
}
