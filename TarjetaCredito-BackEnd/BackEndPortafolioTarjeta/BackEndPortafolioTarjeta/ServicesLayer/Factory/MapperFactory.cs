using BackEndPortafolioTarjeta.ServicesLayer.Mappers;

namespace BackEndPortafolioTarjeta.ServicesLayer.Factory
{
    public class MapperFactory
    {
        /// <summary>
        /// Metodo con el cual se instancia un objeto de tipo UserCreaditCardMapper
        /// </summary>
        /// <returns></returns>
        public static UserCreaditCardMapper CreateUserCreaditCardMapper()
        {
            return new UserCreaditCardMapper();
        }

    }
}
