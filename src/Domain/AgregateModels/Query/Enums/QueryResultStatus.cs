// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResultStatus.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResultStatus
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Query.Enums
{
    /// <summary>
    /// <see cref="QueryResultStatus"></see>
    /// </summary>
    public enum QueryResultStatus
    {
        /// <summary>
        /// The unscraped
        /// </summary>
        UNSCRAPED = 0,

        /// <summary>
        /// The scraping
        /// </summary>
        SCRAPING = 1,

        /// <summary>
        /// The scraped
        /// </summary>
        SCRAPED = 2,
    }
}