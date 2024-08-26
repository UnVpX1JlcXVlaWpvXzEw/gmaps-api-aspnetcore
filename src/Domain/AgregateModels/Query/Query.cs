// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Query.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// Query
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Query
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query.Enums;
    using GMapsMagicianAPI.Domain.SeedWork;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="Query"/>
    /// </summary>
    /// <seealso cref="EntityBase"/>
    /// <seealso cref="IAggregateRoot"/>
    public class Query : EntityBase, IAggregateRoot
    {
        /// <summary>
        /// The results
        /// </summary>
        private readonly List<QueryResult> queryResults;

        /// <summary>
        /// The status history
        /// </summary>
        private readonly List<QueryStatusHistory> statusHistory;

        /// <summary>
        /// Initializes a new instance of the <see cref="Query"/> class.
        /// </summary>
        /// <param name="rawQuery">The raw query.</param>
        /// <param name="gMapsSearchLink">The g maps search link.</param>
        /// <param name="tenantId">The tenant identifier.</param>
        /// <param name="activeScraper">The active scraper.</param>
        /// <param name="isInstant">if set to <c>true</c> [is instant query].</param>
        internal Query(string rawQuery, Guid tenantId)
            : this()
        {
            this.RawQuery = rawQuery;
            this.TenantId = tenantId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query"/> class.
        /// </summary>
        protected Query()
            : base()
        {
            this.queryResults = new List<QueryResult>();
            this.statusHistory = new List<QueryStatusHistory>();
        }

        /// <summary>
        /// Gets the active scraper.
        /// </summary>
        /// <value>The active scraper.</value>
        public string? ActiveScraper { get; private set; }

        /// <summary>
        /// Gets the g maps search link.
        /// </summary>
        /// <value>The g maps search link.</value>
        public string? GMapsSearchLink { get; private set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is instant query.
        /// </summary>
        /// <value><c>true</c> if this instance is instant query; otherwise, <c>false</c>.</value>
        public bool IsInstant { get; private set; }

        /// <summary>
        /// Gets the query results.
        /// </summary>
        /// <value>The query results.</value>
        public virtual IReadOnlyCollection<QueryResult> QueryResults => this.queryResults;

        /// <summary>
        /// Gets or sets the raw query.
        /// </summary>
        /// <value>The raw query.</value>
        public string RawQuery { get; init; }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        public QueryStatus Status { get; private set; }

        /// <summary>
        /// Gets the status history.
        /// </summary>
        /// <value>The status history.</value>
        public virtual IReadOnlyCollection<QueryStatusHistory> StatusHistory => this.statusHistory;

        /// <summary>
        /// Gets or sets the tenant identifier.
        /// </summary>
        /// <value>The tenant identifier.</value>
        public Guid TenantId { get; init; }

        /// <summary>
        /// Finishes the scrapping.
        /// </summary>
        public void FinishScrapping()
        {
            Status = QueryStatus.SCRAPED;
        }

        /// <summary>
        /// Starts the scrapping.
        /// </summary>
        /// <param name="Uuid">The UUID.</param>
        public void StartScrapping()
        {
            Status = QueryStatus.SCRAPING;
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