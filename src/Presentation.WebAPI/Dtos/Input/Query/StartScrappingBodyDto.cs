// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StartScrappingBodyDto.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// StartScrappingBodyDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.Query
{
    /// <summary>
    /// <see cref="StartScrappingBodyDto"/>
    /// </summary>
    public class StartScrappingBodyDto
    {
        /// <summary>
        /// Gets the active scrapper.
        /// </summary>
        /// <value>The active scrapper.</value>
        public string ActiveScrapper { get; init; }

        /// <summary>
        /// Gets the g maps search link.
        /// </summary>
        /// <value>The g maps search link.</value>
        public string GMapsSearchLink { get; init; }
    }
}