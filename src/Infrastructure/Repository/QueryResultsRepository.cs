// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResultsRepository.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResultsRepository
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Infrastructure.Repository
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Repository;
    using GMapsMagicianAPI.Infrastructure;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="QueryResultsRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{QueryResult}"/>
    /// <seealso cref="IQueryResultsRepository"/>
    internal class QueryResultsRepository : GenericRepository<QueryResults>, IQueryResultsRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResultsRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public QueryResultsRepository(GMapsMagicianAPIDBContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Gets the by link asynchronous.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<IEnumerable<QueryResults>> GetByLinkAsync(string link, CancellationToken cancellationToken)
        {
            return await this.Entities
                .Where(x =>
                x.Link == link)
                .ToListAsync(cancellationToken);
        }
    }
}