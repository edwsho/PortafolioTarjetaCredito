using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarjetaCredito.Infrastructure.Models
{
    public  class UserCreditCardModel
    {
        public int id { get; set; }

        [Required]
        [MaxLength(20)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(20)]
        public string numeroTarjeta { get; set; }

        [Required]
        [MaxLength(10)]
        public string fechaExp { get; set; }

        [Required]
        [MaxLength(3)]
        public string cvv { get; set; }

    }
}
