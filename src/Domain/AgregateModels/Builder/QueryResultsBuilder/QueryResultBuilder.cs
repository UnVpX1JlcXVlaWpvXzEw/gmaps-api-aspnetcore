// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResultsBuilder.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResultsBuilder
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryResultsBuilder
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using System;

    /// <summary>
    /// <see cref="QueryResultsBuilder"/>
    /// </summary>
    /// <seealso cref="QueryResultsBuilder.IQueryResultsBuilder"/>
    internal class QueryResultBuilder : IQueryResultBuilder
    {
        /// <summary>
        /// The query result
        /// </summary>
        private QueryResult queryResult;

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">The template object is not initialized.</exception>
        public QueryResult Build()
        {
            if (queryResult is null)
            {
                throw new InvalidOperationException("The template object is not initialized.");
            }

            return queryResult;
        }

        /// <summary>
        /// Creates new queryresult.
        /// </summary>
        /// <param name="link"></param>
        /// <returns></returns>
        public IQueryResultBuilder NewQueryResult(string link)
        {
            queryResult = new QueryResult(link);

            return this;
        }
    }
}