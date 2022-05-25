using BackEndPortafolioTarjeta.Common.Entities;
using BackEndPortafolioTarjeta.Common.Entities.EntityFactory;
using BackEndPortafolioTarjeta.Common.Exceptions;
using BackEndPortafolioTarjeta.Persistence.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BackEndPortafolioTarjeta.Persistence.DAO.Interfaces
{
    public class DAOUserCreditCard : DAO , IDAOUserCreditCard
    {

       /* private readonly DAO _context;

        //Igualo la instanciasion anterior a la nueva declarada
        public DAOUserCreditCard(DAO context)
        {
            _context = context;
        }
       */
        public DAOUserCreditCard()
        {
        }

        public List<Entity> GetAllCreditCards()
        {
            List<Entity> _creditCardList = new List<Entity>();
            UserCreditCard _Credit;

            _Credit = EntityFactory.CreateEmptyUserCreditCard();

            try
            {
                Conectar();
                //_creditCardList = _context.TarjetaCredito.ToList();
                return _creditCardList;


            }
            catch (CustomException e)
            {
                throw new CustomException("Error al Consultar la lista de Tarjetas de Credito");
            }


        }


        /// <summary>
		/// Metodo para consultar una UserCreditCard
		/// </summary>
		/// <param name="entidad">Entidad</param>
		/// <returns></returns>
        public Entity GetUserCreditCardsbyId(Entity entidad)
        {
            throw new NotImplementedException();
        }

        public void Refresh(Entity entidad)
        {
            try
            {
                UserCreditCard _creditCard = (UserCreditCard)entidad;
                //var _RefreshCard = _context.TarjetaCredito.Attach(_creditCard);

                //_RefreshCard.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                //_context.SaveChanges();
            }
            catch (CustomException e)
            {
                throw new CustomException("Parametros nulos en: " + GetType().FullName + "." + MethodBase.GetCurrentMethod().Name + ". " + e.Message);
            }
        }

        public void Delete(Entity entidad)
        {
            try
            {
                //UserCreditCard _creditCard = (UserCreditCard)entidad;
                //UserCreditCard findTarjeta = (UserCreditCard)_context.TarjetaCredito.Find(_creditCard.Id);

                //if (findTarjeta == null)
                //{
                //    throw new CustomException("Parametros nulos en: " + GetType().FullName + "." + MethodBase.GetCurrentMethod().Name + ". ");
                //}
                //_context.TarjetaCredito.Remove(findTarjeta);
                //_context.SaveChanges();


                //return Ok(new { message = "Tarjeta Eliminada con exito!" });
            }
            catch (Exception e)
            {

                throw new CustomException("Parametros nulos en: " + GetType().FullName + "." + MethodBase.GetCurrentMethod().Name + ". " + e.Message);
            }
        }

        /// <summary>
        /// Metodo par agregar una Tarjeta de Credito de tipo Entidad
        /// </summary>
        /// <param name="entidad">Tarjeta de Credito a agregar</param>
        public void Add(Entity entidad)
        {
            try
            {
                //UserCreditCard _creditCard = (UserCreditCard)entidad;
                //_context.Add(_creditCard);
                //_context.SaveChanges();

            }
            catch (NullReferenceException e)
            {
                throw new CustomException("Parametros nulos en: " + GetType().FullName + "." + MethodBase.GetCurrentMethod().Name + ". " + e.Message);
            }

            catch (InvalidCastException e)
            {
                throw new CustomException("Casteo no correcto en: " + GetType().FullName + "." + MethodBase.GetCurrentMethod().Name + ". " + e.Message);
            }

        }

        public List<Entity> GetAll()
        {
            try
            {
                List<Entity> _creditCardList = new List<Entity>();
                //UserCreditCard _Credit;

                //_Credit = EntityFactory.CreateEmptyUserCreditCard();
                //_creditCardList = _context.TarjetaCredito.ToList();
                return _creditCardList;
            }
            catch (Exception e)
            {
                throw new CustomException("Error al Consultar la lista de Tarjetas de Credito");
            }
        }
    }
}
