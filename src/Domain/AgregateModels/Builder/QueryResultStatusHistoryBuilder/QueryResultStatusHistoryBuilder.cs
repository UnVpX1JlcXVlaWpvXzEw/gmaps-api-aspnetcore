// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResultStatusHistory.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResultStatusHistory
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryResultStatusHistory
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;

    /// <summary>
    /// <see cref="QueryResultStatusHistoryBuilder"/>
    /// </summary>
    /// <seealso cref="IQueryResultStatusHistoryBuilder"/>
    internal class QueryResultStatusHistoryBuilder : IQueryResultStatusHistoryBuilder
    {
        /// <summary>
        /// The query result status history
        /// </summary>
        private QueryResultStatusHistory queryResultStatusHistory;

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">The subscription object is not initialized.</exception>
        public QueryResultStatusHistory Build()
        {
            if (queryResultStatusHistory is null)
            {
                throw new InvalidOperationException("The queryResultStatusHistory object is not initialized.");
            }

            return queryResultStatusHistory;
        }

        /// <summary>
        /// Creates new queryresultstatushistory.
        /// </summary>
        /// <param name="scrapingConclusionDate">The scraping conclusion date.</param>
        /// <returns></returns>
        public IQueryResultStatusHistoryBuilder NewQueryResultStatusHistory(DateTime scrapingConclusionDate)
        {
            queryResultStatusHistory = new(scrapingConclusionDate);

            return this;
        }
    }
}