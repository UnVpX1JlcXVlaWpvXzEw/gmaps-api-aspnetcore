// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetUnscrappedQueryDto.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// GetUnscrappedQueryDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.Query
{
    /// <summary>
    /// <see cref="GetUnscrappedQueryDto"/>
    /// </summary>
    public class GetUnscrappedQueryDto
    {
        /// <summary>
        /// Gets a value indicating whether this instance is instant.
        /// </summary>
        /// <value><c>true</c> if this instance is instant; otherwise, <c>false</c>.</value>
        public bool IsInstant { get; init; }
    }
}