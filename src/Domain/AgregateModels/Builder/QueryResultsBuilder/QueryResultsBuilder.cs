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
    internal class QueryResultsBuilder : IQueryResultsBuilder
    {
        /// <summary>
        /// The query result
        /// </summary>
        private List<QueryResults> queryResult;

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">The template object is not initialized.</exception>
        public List<QueryResults> Build()
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
        /// <param name="Link"></param>
        /// <returns></returns>
        public IQueryResultsBuilder NewQueryResult(List<QueryResults> links)
        {
            foreach (var link in links)
            {
                queryResult = new List<QueryResults>(links);
            }

            return this;
        }
    }
}