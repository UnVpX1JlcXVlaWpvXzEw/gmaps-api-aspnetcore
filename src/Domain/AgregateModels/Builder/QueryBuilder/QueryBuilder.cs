// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryBuilder.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryBuilder
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryBuilder
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using System;

    /// <summary>
    /// <see cref="QueryBuilder"/>
    /// </summary>
    /// <seealso cref="IQueryBuilder"/>
    internal class QueryBuilder : IQueryBuilder
    {
        /// <summary>
        /// The query
        /// </summary>
        private Query query;

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.InvalidOperationException">The query object is not initialized</exception>
        public Query Build()
        {
            if (query is null)
            {
                throw new InvalidOperationException("The query object is not initialized");
            }

            return query;
        }

        /// <summary>
        /// Creates new query.
        /// </summary>
        /// <param name="rawQuery">The raw query.</param>
        /// <param name="tenantId">The tenant identifier.</param>
        /// <returns></returns>
        public IQueryBuilder NewQuery(string rawQuery, Guid tenantId)
        {
            query = new(rawQuery, tenantId);
            return this;
        }
    }
}