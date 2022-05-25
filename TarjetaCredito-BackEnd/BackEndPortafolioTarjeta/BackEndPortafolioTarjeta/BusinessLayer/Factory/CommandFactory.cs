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



    }
}
