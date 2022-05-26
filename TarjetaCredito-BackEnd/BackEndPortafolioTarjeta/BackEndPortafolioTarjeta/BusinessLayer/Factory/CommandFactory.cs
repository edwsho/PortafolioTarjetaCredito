using BackEndPortafolioTarjeta.BusinessLayer.Command.UserCreditCard;
using BackEndPortafolioTarjeta.Common.Entities;

namespace BackEndPortafolioTarjeta.BusinessLayer.Factory
{
    public static class CommandFactory
    {

        public static AddUserCredictCardCommand AddUserCredictCardCommand(Entity _entidad)
        {
            return new AddUserCredictCardCommand(_entidad);
        }

        public static GetAllUserCreaditCardCommmand GetAllUserCreaditCardCommmand()
        {
            return new GetAllUserCreaditCardCommmand();
        }

        public static RefreshUserCreditCardCommand RefreshUserCreditCardCommand(Entity _entity)
        {
            return new RefreshUserCreditCardCommand(_entity);
        }

        public static DeleteUserCreditCardCommand DeleteUserCreditCardCommand(Entity _entity)
        {
            return new DeleteUserCreditCardCommand(_entity);
        }



    }
}
