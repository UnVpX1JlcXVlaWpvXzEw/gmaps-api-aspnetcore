// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResultDto.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResultDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.QueryResult
{
    /// <summary>
    /// <see cref="QueryResultDto"/>
    /// </summary>
    public class QueryResultDto
    {
        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <value>The links.</value>
        public List<string> Links { get; init; }

        /// <summary>
        /// Gets the UUID.
        /// </summary>
        /// <value>The UUID.</value>
        public Guid Uuid { get; init; }
    }
}