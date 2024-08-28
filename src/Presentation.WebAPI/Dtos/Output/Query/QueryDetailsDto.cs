// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryDetailsDto.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryDetailsDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Dtos.Output.Query
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Query.Enums;

    /// <summary>
    /// <see cref="QueryDetailsDto"/>
    /// </summary>
    public class QueryDetailsDto
    {
        /// <summary>
        /// Gets the active scraper.
        /// </summary>
        /// <value>The active scraper.</value>
        public string ActiveScraper { get; init; }

        /// <summary>
        /// Gets the gmaps search link.
        /// </summary>
        /// <value>The gmaps search link.</value>
        public string GMapsSearchLink { get; init; }

        /// <summary>
        /// Gets a value indicating whether this instance is instant query.
        /// </summary>
        /// <value><c>true</c> if this instance is instant query; otherwise, <c>false</c>.</value>
        public bool IsInstant { get; init; }

        /// <summary>
        /// Gets the raw query.
        /// </summary>
        /// <value>The raw query.</value>
        public string RawQuery { get; init; }

        /// <summary>
        /// Gets the results.
        /// </summary>
        /// <value>The results.</value>
        public List<QueryResult> Results { get; init; }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        public QueryStatus Status { get; init; }

        /// <summary>
        /// Gets the status history.
        /// </summary>
        /// <value>The status history.</value>
        public List<QueryStatusHistory> StatusHistory { get; init; }

        /// <summary>
        /// Gets the tenant identifier.
        /// </summary>
        /// <value>The tenant identifier.</value>
        public Guid TenantId { get; init; }

        /// <summary>
        /// Gets the UUID.
        /// </summary>
        /// <value>The UUID.</value>
        public Guid Uuid { get; init; }
    }
}