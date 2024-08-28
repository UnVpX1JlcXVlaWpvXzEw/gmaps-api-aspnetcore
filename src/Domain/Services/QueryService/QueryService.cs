// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryService.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryService
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.Services.QueryService
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="QueryService"/>
    /// </summary>
    /// <seealso cref="IQueryService"/>
    internal class QueryService : IQueryService
    {
        /// <summary>
        /// The dev identifier list
        /// </summary>
        private Dictionary<string, Guid> devIdList = new()
        {
            { "Motinha", Guid.Parse("6453f7b5-01ea-469f-9360-3373962afae4") },
            { "Carlos", Guid.Parse("38a8fdbb-624f-40c5-8bb9-7543cc595f4d") },
            { "Rui", Guid.Parse("6e1ed1a2-f14d-4756-b125-0a05bac34bab") },
            { "QueryBuilder", Guid.Parse("6279bee3-8b27-456e-8afb-aaf47c83f5dd") }
        };

        /// <summary>
        /// Verifies the instant query asynchronous.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        public Task VerifyInstantQueryAsync(Query query)
        {
            if (devIdList.ContainsValue(query.TenantId))
            {
                query.NotInstantQuery();
                return Task.CompletedTask;
            }

            query.IsInstantQuery();
            return Task.CompletedTask;
        }
    }
}