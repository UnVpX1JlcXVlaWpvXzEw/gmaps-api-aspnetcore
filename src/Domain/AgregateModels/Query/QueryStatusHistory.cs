// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryStatusHistory.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryStatusHistory
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Query.Enums
{
    using GMapsMagicianAPI.Domain.SeedWork;
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="QueryStatusHistory"/>
    /// </summary>
    /// <seealso cref="EntityBase"/>
    public class QueryStatusHistory : EntityBase
    {
        internal QueryStatusHistory(string link, DateTime scrapingConclusionDate)
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
        public QueryStatus Status { get; init; }

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