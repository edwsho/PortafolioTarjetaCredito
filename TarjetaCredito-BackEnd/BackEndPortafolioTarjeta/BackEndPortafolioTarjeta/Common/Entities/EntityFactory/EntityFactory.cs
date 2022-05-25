using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BackEndPortafolioTarjeta.Common.Entities.EntityFactory
{
    /// <summary>
	/// Fabrica que instancia todas las Entidades
	/// </summary>
    public static class EntityFactory
    {
		/// <summary>
		/// Metodo que realiza una instancia de tipo UserCreditCard
		/// </summary>
		/// <param name="nombre">Nombre del Usuario de la Tarjeta de Credito </param>
		/// <param name="numeroTarjeta">Numero de La Tarjeta de credito </param>
		/// <param name="fechaExp">Fecha de expiracion de la Tarjeta de credito</param>
		/// <param name="cVV">CVV codigo de verificacion</param>
		/// <returns></returns>
		public static UserCreditCard CreateUserCreditCard(string nombre, string numeroTarjeta, string fechaExp, string cVV)
        {
			return new UserCreditCard(nombre, numeroTarjeta, fechaExp, cVV);
        }


		/// <summary>
		/// Metodo que realiza una instancia de tipo UserCreditCard
		/// </summary>
		/// <param name="id">Id</param>
		/// <param name="nombre">Nombre del Usuario de la Tarjeta de Credito </param>
		/// <param name="numeroTarjeta">Numero de La Tarjeta de credito </param>
		/// <param name="fechaExp">Fecha de expiracion de la Tarjeta de credito</param>
		/// <param name="cVV">CVV codigo de verificacion</param>
		/// <returns></returns>
		public static UserCreditCard CreateUserCreditCardWithID(int id, string nombre, string numeroTarjeta, string fechaExp, string cVV)
		{
			return new UserCreditCard(id, nombre, numeroTarjeta, fechaExp, cVV);
		}

		public static UserCreditCard CreateEmptyUserCreditCard()
        {
			return new UserCreditCard();
        }


	}
}
