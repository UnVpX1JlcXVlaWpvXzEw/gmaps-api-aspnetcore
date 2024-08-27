// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueryRepository.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// IQueryRepository
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Repository
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.SeedWork;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="IQueryRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{Query}"/>
    public interface IQueryRepository : IRepository<Query>
    {
        /// <summary>
        /// Gets the by tenant identifier asynchronous.
        /// </summary>
        /// <param name="tenantId">The tenant identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<IEnumerable<Query>> GetByTenantIdAsync(Guid tenantId, CancellationToken cancellationToken);

        /// <summary>
        /// Gets the unscrapped query asynchronous.
        /// </summary>
        /// <param name="IsInstant">if set to <c>true</c> [is instant].</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        Task<Query> GetUnscrappedQueryAsync(bool isInstant, CancellationToken cancellationToken);
    }
}