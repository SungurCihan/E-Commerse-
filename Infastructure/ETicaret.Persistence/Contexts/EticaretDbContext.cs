using ETicaret.Domain.Entities;
using ETicaret.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Persistence.Contexts
{
    public class EticaretDbContext : DbContext
    {
        public EticaretDbContext(DbContextOptions options) : base(options){}

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreateAt = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdateAt = DateTime.UtcNow,
                };
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
