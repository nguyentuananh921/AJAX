
using MediatR;
using FluentValidation;


using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public static class ApplicationDependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services) 
        {

            services.AddAutoMapper();
            services.AddMediator();
            services.AddValidators();

            //https://www.youtube.com/watch?v=fe4iuaoxGbA&t=552s
            //var assembly= typeof(ApplicationDependencyInjection).Assembly;
            //services.AddMediatR(configuration=>
            //        configuration.RegisterServicesFromAssembly(assembly));

            //services.AddValidatorsFromAssembly(assembly);//For fluent Valiator

            return services;
        }
        private static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
        private static void AddMediator(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }

        private static void AddValidators(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
