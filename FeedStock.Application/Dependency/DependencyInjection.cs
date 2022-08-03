using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FeedStock.Application.Common.Behaviours;

namespace FeedStock.Application.Dependency
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssemblies(new[] { Assembly.GetExecutingAssembly() });
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
            return services;
        }
    }
}
