using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FeedStock.Application.Dependency
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
