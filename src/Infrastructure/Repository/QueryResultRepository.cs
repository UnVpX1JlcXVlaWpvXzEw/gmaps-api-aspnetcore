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
    }
}