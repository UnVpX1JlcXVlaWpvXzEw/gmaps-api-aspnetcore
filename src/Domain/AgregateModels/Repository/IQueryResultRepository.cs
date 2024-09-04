// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueryResultRepository.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// IQueryResultRepository
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
    /// <see cref="IQueryResultRepository"/>
    /// </summary>
    /// <seealso cref="IRepository{QueryResults}"/>
    public interface IQueryResultRepository : IRepository<QueryResult>
    {
        Task<IEnumerable<QueryResult>> GetByLinkAsync(string link, CancellationToken cancellationToken);
    }
}