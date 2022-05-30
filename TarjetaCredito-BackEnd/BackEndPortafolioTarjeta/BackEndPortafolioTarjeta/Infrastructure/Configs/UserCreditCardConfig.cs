using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;
using TarjetaCredito.Domain.DomainObject;

namespace TarjetaCredito.Infrastructure.Configs
{
    class UserCreditCardConfig : IEntityTypeConfiguration<UserCreditCard>
    {
        public void Configure(EntityTypeBuilder<UserCreditCard> builder)
        {
            builder.ToTable("TarjetaCredito");
            builder.HasKey(x => x.Id);

            //En caso de querer configurar llaves Primarias y Foraneas asi como sus relaciones se hace de la siguiente manera.

            /*builder.HasKey(x => new { x.Id, x.Id2 });

            builder.HasOne(detalle => detalle.Producto)      //Ejemplo un VentaDetalle tiene un Producto     
                .WithMany(Entidad => Entidad.VentaDetalles); //Un producto tiene muchas VentasDetalles

            builder.HasOne(detalle => detalle.Venta)         //Ejemplo un VentaDetalle tiene una Venta 
                 .WithMany(Entidad => Entidad.VentaDetalles);     //Un producto tiene muchas VentaDetalles    */

        }
    }
}
