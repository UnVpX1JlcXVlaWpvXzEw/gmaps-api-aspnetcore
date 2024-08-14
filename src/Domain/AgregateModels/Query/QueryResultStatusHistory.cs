// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResultStatusHistory.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResultStatusHistory
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Query
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query.Enums;

    /// <summary>
    /// <see cref="QueryResultStatusHistory"/>
    /// </summary>
    public class QueryResultStatusHistory
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResultStatusHistory"/> class.
        /// </summary>
        /// <param name="scrapingConclusionDate">The scraping conclusion date.</param>
        internal QueryResultStatusHistory(DateTime scrapingConclusionDate)
        {
            this.ScrapingConclusionDate = scrapingConclusionDate;
        }

        /// <summary>
        /// Gets the scraping conclusion date.
        /// </summary>
        /// <value>The scraping conclusion date.</value>
        public DateTime ScrapingConclusionDate { get; init; }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        public QueryResultStatus Status { get; init; }
    }
}