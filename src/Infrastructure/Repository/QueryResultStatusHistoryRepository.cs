// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResultStatusHistoryRepository.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResultStatusHistoryRepository
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Infrastructure.Repository
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Repository;

    /// <summary>
    /// <see cref="QueryResultStatusHistoryRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{QueryResultStatusHistory}"/>
    /// <seealso cref="IQueryResultStatusHistoryRepository"/>
    internal class QueryResultStatusHistoryRepository : GenericRepository<QueryResultStatusHistory>, IQueryResultStatusHistoryRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResultStatusHistoryRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public QueryResultStatusHistoryRepository(GMapsMagicianAPIDBContext context)
            : base(context)
        {
        }
    }
}