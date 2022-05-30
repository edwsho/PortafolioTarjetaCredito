using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Domain.DomainObject
{
    public class UserCreditCard
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string numeroTarjeta { get; set; }

        public string fechaExp { get; set; }

        public string cvv { get; set; }

    }
}
