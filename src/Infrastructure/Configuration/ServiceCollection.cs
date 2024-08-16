// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceCollection.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// ServiceCollection
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Infrastructure.Configuration
{
    using GMapsMagicianAPI.Domain.AgregateModels.Repository;
    using GMapsMagicianAPI.Infrastructure.Repository;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// <see cref="ServiceCollection"/>
    /// </summary>
    public static class ServiceCollection
    {
        /// <summary>
        /// Registers the infrastructure services.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void RegisterInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IQueryRepository, QueryRepository>();

            services.AddTransient<IQueryResultRepository, QueryResultRepository>();

            services.AddTransient<IQueryResultStatusHistoryRepository, QueryResultStatusHistoryRepository>();

            services.AddTransient<IQueryStatusHistoryRepository, QueryStatusHistoryRepository>();
        }
    }
}