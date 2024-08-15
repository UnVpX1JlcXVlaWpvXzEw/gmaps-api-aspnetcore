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
    using GMapsMagicianAPI.Domain.SeedWork;
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="QueryResultStatusHistory"/>
    /// </summary>
    /// ///
    /// <seealso cref="EntityBase"/>
    public class QueryResultStatusHistory : EntityBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResultStatusHistory"/> class.
        /// </summary>
        /// <param name="scrapingConclusionDate">The scraping conclusion date.</param>
        internal QueryResultStatusHistory(QueryResultStatus status, DateTime scrapingConclusionDate)
        {
            this.ScrapingConclusionDate = scrapingConclusionDate;
            this.Status = status;
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

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.UUId;
        }
    }
}