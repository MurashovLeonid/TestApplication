using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using System.Security.Policy;
using TestApplication.UseCases.Queries.Users;

namespace TestApplication.Exstensions
{
    public static class StartupExstensions
    {
        public static void ConfigureMediatR(this IServiceCollection services)
        {
            services.AddMediatR(typeof(UsersPaginationQueryHandler).Assembly); 
        }
    }
}
