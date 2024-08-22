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
        /// Gets the duplicated by filters asynchronous.
        /// </summary>
        /// <param name="rawQuery">The raw query.</param>
        /// <param name="tenantId">The tenant identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
    }
}