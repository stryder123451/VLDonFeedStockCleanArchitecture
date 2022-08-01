using FeedStock.Application.Interfaces;
using FeedStock.Domain.Models;
using FeedStock.Persistence.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Persistence.DbContextClass
{
    public class FeedStockDbContext : DbContext, IFeedStockDbContext
    {
        public DbSet<Request> Requests { get; set; }
        public DbSet<Organizations> Organizations { get; set; }
        public DbSet<Workers> Workers { get; set; }

        public FeedStockDbContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new RequestConfiguration());
            base.OnModelCreating(builder);
        }

        public Task<int> SaveChangesAsync(CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
