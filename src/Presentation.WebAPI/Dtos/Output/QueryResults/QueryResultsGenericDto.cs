// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResultsGenericDto.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResultsGenericDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Dtos.Output.QueryResults
{
    /// <summary>
    /// <see cref="QueryResultsGenericDto"/>
    /// </summary>
    public class QueryResultsGenericDto
    {
        /// <summary>
        /// Gets the link.
        /// </summary>
        /// <value>The link.</value>
        public string Link { get; init; }

        /// <summary>
        /// Gets the UUID.
        /// </summary>
        /// <value>The UUID.</value>
        public string Uuid { get; init; }
    }
}