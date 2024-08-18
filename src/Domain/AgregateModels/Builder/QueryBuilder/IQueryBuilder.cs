// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueryBuilder.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// IQueryBuilder
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryBuilder
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;

    /// <summary>
    /// <see cref="IQueryBuilder"/>
    /// </summary>
    public interface IQueryBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        Query Build();

        /// <summary>
        /// Creates new query.
        /// </summary>
        /// <param name="rawQuery">The raw query.</param>
        /// <param name="tenantId">The tenant identifier.</param>
        /// <returns></returns>
        IQueryBuilder NewQuery(string rawQuery, Guid tenantId);
    }
}