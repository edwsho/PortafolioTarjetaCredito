using BackEndPortafolioTarjeta.ServicesLayer.DTO;

namespace BackEndPortafolioTarjeta.ServicesLayer.Factory
{
    public class DTOFactory
    {
        /// <summary>
        /// Metodo que instancia un objeto de tipo DTOUserCreditCard
        /// </summary>
        /// <param name="id">Id Tarjeta de Creadito </param>
        /// <param name="nombre">>Nombre de la Tarjeta de Creadito/param>
        /// <param name="numeroTarjeta">Numero de la Tarjeta de Credito</param>
        /// <param name="fechaExp">Fecha Expiracion</param>
        /// <param name="cvv">CVV</param>
        /// <returns></returns>
        public static DTOUserCreditCard CreateDTOUserCreaditCard(int id, string nombre, string numeroTarjeta, string fechaExp, string cvv)
        {
            return new DTOUserCreditCard(id, nombre,numeroTarjeta,fechaExp,cvv);
        }


    }
}
