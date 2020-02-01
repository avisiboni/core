﻿using Codidact.Application.Repositories;
using Codidact.Application.Repositories.Communities;
using Microsoft.Extensions.DependencyInjection;

namespace Codidact.Application
{
    /// <summary>
    /// Dependency Injection module for the application
    /// </summary>
    public static class ApplicationModule
    {
        /// <summary>
        /// Adds all of the application services into the service collection
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ICommunityRepository, CommunityRepository>();
            return services;
        }

    }
}
