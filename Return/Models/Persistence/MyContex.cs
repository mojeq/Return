using Microsoft.EntityFrameworkCore;
using Return.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Return.Models.Persistence
{
    public class MyContex : DbContext
    {
        public MyContex(DbContextOptions<MyContex> options)
        : base(options)
        {
        }

        public DbSet<ItemToReturnEntity> ItemToReturns { get; set; }
        public DbSet<ReturnEntity> Returns { get; set; }
        public DbSet<AddressEntity> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Entity<OrderEntity>()
            //    .HasOne(p => p.Customer)
            //    .WithMany(o => o.OrderList);

            //builder.Entity<OrderDetailEntity>()
            //    .HasOne(p => p.Order)
            //    .WithMany(o => o.OrderDetails);
        }
    }
}
