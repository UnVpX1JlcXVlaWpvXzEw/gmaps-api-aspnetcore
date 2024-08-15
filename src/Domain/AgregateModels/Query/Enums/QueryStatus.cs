// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryStatus.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryStatus
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Query.Enums
{
    /// <summary>
    /// <see cref="QueryStatus"></see>
    /// </summary>
    public enum QueryStatus
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