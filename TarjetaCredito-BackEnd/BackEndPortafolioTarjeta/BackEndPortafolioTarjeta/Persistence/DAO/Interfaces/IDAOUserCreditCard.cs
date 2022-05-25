using BackEndPortafolioTarjeta.Common.Entities;
using BackEndPortafolioTarjeta.Persistence.Interfaces;

namespace BackEndPortafolioTarjeta.Persistence.DAO.Interfaces
{
    public interface IDAOUserCreditCard : IDAO
    {
        List<Entity> GetAllCreditCards();

        Entity GetUserCreditCardsbyId(Entity entidad);

    }
}
