using FeedStock.Application.Interfaces;
using FeedStock.Persistence.DbContextClass;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Persistence.Dependency
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<FeedStockDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            }
            );
            services.AddScoped<IFeedStockDbContext>(provider => provider.GetService<FeedStockDbContext>());
            return services;
        }
    }
}
