// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryRepository.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryRepository
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Infrastructure.Repository
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Query.Enums;
    using GMapsMagicianAPI.Domain.AgregateModels.Repository;
    using GMapsMagicianAPI.Infrastructure;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="QueryRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{Query}"/>
    /// <seealso cref="IQueryRepository"/>
    internal class QueryRepository : GenericRepository<Query>, IQueryRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public QueryRepository(GMapsMagicianAPIDBContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Gets the by tenant identifier asynchronous.
        /// </summary>
        /// <param name="tenantId">The tenant identifier.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Query>> GetByTenantIdAsync(Guid tenantId, CancellationToken cancellationToken)
        {
            return await this.Entities
                .Where(x =>
                x.TenantId == tenantId)
                .ToListAsync(cancellationToken);
        }

        /// <summary>
        /// Gets the unscrapped query asynchronous.
        /// </summary>
        /// <param name="IsInstant"></param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<Query> GetUnscrappedQueryAsync(bool isInstant, CancellationToken cancellationToken)
        {
            return await this.Entities
                .Where(x =>
                    x.Status == QueryStatus.UNSCRAPED &&
                    x.ActiveScraper == null &&
                    x.IsInstant == isInstant)
                .FirstOrDefaultAsync(cancellationToken);
        }
    }
}