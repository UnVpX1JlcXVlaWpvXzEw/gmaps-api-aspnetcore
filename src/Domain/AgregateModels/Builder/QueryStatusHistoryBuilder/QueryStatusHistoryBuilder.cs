// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryStatusHistoryBuilder.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryStatusHistoryBuilder
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryStatusHistoryBuilder
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query.Enums;

    /// <summary>
    /// <see cref="QueryStatusHistoryBuilder"/>
    /// </summary>
    /// <seealso cref="IQueryStatusHistoryBuilder"/>
    internal class QueryStatusHistoryBuilder : IQueryStatusHistoryBuilder
    {
        /// <summary>
        /// The query status history
        /// </summary>
        private QueryStatusHistory queryStatusHistory;

        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException">
        /// The queryStatusHistory object is not initialized.
        /// </exception>
        public QueryStatusHistory Build()
        {
            if (queryStatusHistory is null)
            {
                throw new InvalidOperationException("The queryStatusHistory object is not initialized.");
            }

            return queryStatusHistory;
        }

        /// <summary>
        /// Creates new querystatushistory.
        /// </summary>
        /// <param name="scrapingConclusionDate">The scraping conclusion date.</param>
        /// <returns></returns>
        public IQueryStatusHistoryBuilder NewQueryStatusHistory(DateTime scrapingConclusionDate)
        {
            queryStatusHistory = new(scrapingConclusionDate);

            return this;
        }
    }
}