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
    /// <see cref="QueryResults"/>
    /// </summary>
    /// <seealso cref="EntityBase"/>
    public class QueryResults : EntityBase
    {
        /// <summary>
        /// The result status histories
        /// </summary>
        private readonly List<QueryResultStatusHistory> resultStatusHistory;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResults"/> class.
        /// </summary>
        /// <param name="link">The link.</param>
        internal QueryResults(string link)
            : this()
        {
            this.Link = link;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResults"/> class.
        /// </summary>
        protected QueryResults()
            : base()
        {
            this.resultStatusHistory = new List<QueryResultStatusHistory>();
        }

        /// <summary>
        /// Gets the link.
        /// </summary>
        /// <value>The link.</value>
        public string Link { get; init; }

        /// <summary>
        /// Gets the result status history.
        /// </summary>
        /// <value>The result status history.</value>
        public virtual IReadOnlyCollection<QueryResultStatusHistory> ResultStatusHistory => this.resultStatusHistory;

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        public QueryResultStatus Status { get; private set; }

        public void FinishScrapping()
        {
            Status = QueryResultStatus.SCRAPED;
        }

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