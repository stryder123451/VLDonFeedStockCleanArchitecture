using FeedStock.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Application.Interfaces
{
    public interface IFeedStockDbContext
    {
        DbSet<Request> Requests { get; set; }
        DbSet<Organizations> Organizations { get; set; }
        DbSet<Workers> Workers { get; set; }
        Task<int> SaveChangesAsync(CancellationToken token);
    }
}
