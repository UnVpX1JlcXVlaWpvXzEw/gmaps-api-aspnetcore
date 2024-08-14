// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResults.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResults
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Query
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query.Enums;
    using GMapsMagicianAPI.Domain.SeedWork;
    using System.Collections.Generic;

    /// <summary>
    /// </summary>
    /// <seealso cref="GMapsMagicianAPI.Domain.SeedWork.EntityBase"/>
    public class QueryResult : EntityBase
    {
        /// <summary>
        /// The query result status histories
        /// </summary>
        private readonly List<QueryResultStatusHistory> queryResultStatusHistories;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResult"/> class.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <param name="scrapingConclusionDate">The scraping conclusion date.</param>
        internal QueryResult(string link, DateTime scrapingConclusionDate)
        {
            this.Link = link;
            this.ScrapingConclusionDate = scrapingConclusionDate;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResult"/> class.
        /// </summary>
        protected QueryResult()
            : base()
        {
            this.queryResultStatusHistories = new List<QueryResultStatusHistory>();
        }

        /// <summary>
        /// Gets the link.
        /// </summary>
        /// <value>The link.</value>
        public string Link { get; init; }

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

        /// <summary>
        /// Gets the atomic values.
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.UUId;
        }
    }
}