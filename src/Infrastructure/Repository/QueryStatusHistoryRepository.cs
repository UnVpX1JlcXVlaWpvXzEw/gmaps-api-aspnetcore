// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryStatusHistoryRepository.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryStatusHistoryRepository
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Infrastructure.Repository
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query.Enums;
    using GMapsMagicianAPI.Domain.AgregateModels.Repository;

    /// <summary>
    /// <see cref="QueryStatusHistoryRepository"/>
    /// </summary>
    /// <seealso cref="GenericRepository{QueryStatusHistory}"/>
    /// <seealso cref="IQueryStatusHistoryRepository"/>
    internal class QueryStatusHistoryRepository : GenericRepository<QueryStatusHistory>, IQueryStatusHistoryRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryStatusHistoryRepository"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public QueryStatusHistoryRepository(GMapsMagicianAPIDBContext context)
            : base(context)
        {
        }
    }
}