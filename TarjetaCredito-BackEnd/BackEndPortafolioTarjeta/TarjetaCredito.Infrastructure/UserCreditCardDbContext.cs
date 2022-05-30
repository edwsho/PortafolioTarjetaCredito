using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarjetaCredito.Domain.DomainObject;
using TarjetaCredito.Infrastructure.Configs;

namespace TarjetaCredito.Infrastructure
{
    public class UserCreditCardDbContext : DbContext
    {

        public DbSet<UserCreditCard> userCreditCards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=(local)\\sqlexpress;Database=TarejtaCreditoDb;Trusted_Connection=True;MultipleActiveResultSets=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new UserCreditCardConfig());

        }

    }
}
