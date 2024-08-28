// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceCollection.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// ServiceCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.Configuration
{
    using GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryBuilder;
    using GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryResultsBuilder;
    using GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryResultStatusHistory;
    using GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryStatusHistoryBuilder;
    using GMapsMagicianAPI.Domain.Services.QueryService;
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// <see cref="ServiceCollection"/>
    /// </summary>
    public static class ServiceCollection
    {
        /// <summary>
        /// Registers the domain services.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void RegisterDomainServices(this IServiceCollection services)
        {
            services.AddTransient<IQueryBuilder, QueryBuilder>();

            services.AddTransient<IQueryResultBuilder, QueryResultBuilder>();

            services.AddTransient<IQueryResultStatusHistoryBuilder, QueryResultStatusHistoryBuilder>();

            services.AddTransient<IQueryStatusHistoryBuilder, QueryStatusHistoryBuilder>();

            services.AddScoped<IQueryService, QueryService>();
        }
    }
}