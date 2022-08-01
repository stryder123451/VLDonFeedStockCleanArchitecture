using FeedStock.Persistence.DbContextClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Persistence.DbContextInitializer
{
    public class DbInitializer
    {
        public static void Initialize(FeedStockDbContext context)
        {
            context.Database.EnsureCreated(); 
        }
    }
}
