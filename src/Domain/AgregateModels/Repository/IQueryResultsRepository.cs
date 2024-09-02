// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueryResultsRepository.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// IQueryResultsRepository
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Repository
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.SeedWork;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="IQueryResultsRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{QueryResults}"/>
    public interface IQueryResultsRepository : IRepository<QueryResults>
    {
        Task<IEnumerable<QueryResults>> GetByLinkAsync(string link, CancellationToken cancellationToken);
    }
}