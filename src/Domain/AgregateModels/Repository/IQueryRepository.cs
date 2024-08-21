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
    public interface IQueryRepository : IRepository<Query>
    {
        Task<IEnumerable<Query>> GetByTenantIdAsync(Guid tenantId, CancellationToken cancellationToken);
    }
}