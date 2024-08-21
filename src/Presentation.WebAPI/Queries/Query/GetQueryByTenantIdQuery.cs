// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetQueryByTenantIdQuery.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// GetQueryByTenantIdQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Queries.Query
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using MediatR;

    /// <summary>
    /// <see cref="GetQueryByTenantIdQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{IEnumerable{Query}}"/>
    public class GetQueryByTenantIdQuery : IRequest<IEnumerable<Query>>
    {
        /// <summary>
        /// Gets the tenant identifier.
        /// </summary>
        /// <value>The tenant identifier.</value>
        public Guid TenantId { get; init; }
    }
}