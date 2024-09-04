// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResultRepository.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResultRepository
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
    /// <see cref="QueryResultRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{QueryResult}"/>
    /// <seealso cref="IQueryResultRepository"/>
    internal class QueryResultRepository : GenericRepository<QueryResult>, IQueryResultRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResultRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public QueryResultRepository(GMapsMagicianAPIDBContext context)
            : base(context)
        {
        }

        /// <summary>
        /// Gets the by link asynchronous.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<IEnumerable<QueryResult>> GetByLinkAsync(string link, CancellationToken cancellationToken)
        {
            return await this.Entities
                .Where(x =>
                x.Link == link)
                .ToListAsync(cancellationToken);
        }
    }
}