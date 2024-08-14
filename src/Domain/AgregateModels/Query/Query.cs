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
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="Query"/>
    /// </summary>
    /// <seealso cref="EntityBase"/>
    /// <seealso cref="IAggregateRoot"/>
    public class Query : EntityBase, IAggregateRoot
    {
        /// <summary>
        /// The query results
        /// </summary>
        private readonly List<QueryResult> queryResults;

        /// <summary>
        /// The query result status histories
        /// </summary>

        /// <summary>
        /// The query status histories
        /// </summary>
        private readonly List<QueryStatusHistory> queryStatusHistories;

        /// <summary>
        /// Initializes a new instance of the <see cref="Query"/> class.
        /// </summary>
        /// <param name="rawQuery">The raw query.</param>
        /// <param name="gMapsSearchLink">The g maps search link.</param>
        /// <param name="tenantId">The tenant identifier.</param>
        /// <param name="activeScraper">The active scraper.</param>
        /// <param name="isInstantQuery">if set to <c>true</c> [is instant query].</param>
        internal Query(string rawQuery, string gMapsSearchLink, Guid tenantId, string activeScraper, bool isInstantQuery)
            : this()
        {
            this.RawQuery = rawQuery;
            this.GMapsSearchLink = gMapsSearchLink;
            this.TenantId = tenantId;
            this.ActiveScraper = activeScraper;
            this.IsInstantQuery = isInstantQuery;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query"/> class.
        /// </summary>
        protected Query()
            : base()
        {
            this.queryResults = new List<QueryResult>();
            this.queryStatusHistories = new List<QueryStatusHistory>();
        }

        /// <summary>
        /// Gets or sets the active scraper.
        /// </summary>
        /// <value>The active scraper.</value>
        public string ActiveScraper { get; init; }

        /// <summary>
        /// Gets or sets the g maps search link.
        /// </summary>
        /// <value>The g maps search link.</value>
        public string GMapsSearchLink { get; init; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is instant query.
        /// </summary>
        /// <value><c>true</c> if this instance is instant query; otherwise, <c>false</c>.</value>
        public bool IsInstantQuery { get; init; }

        /// <summary>
        /// Gets or sets the raw query.
        /// </summary>
        /// <value>The raw query.</value>
        public string RawQuery { get; init; }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        public QueryStatusHistory Status { get; init; }

        /// <summary>
        /// Gets or sets the tenant identifier.
        /// </summary>
        /// <value>The tenant identifier.</value>
        public Guid TenantId { get; init; }

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