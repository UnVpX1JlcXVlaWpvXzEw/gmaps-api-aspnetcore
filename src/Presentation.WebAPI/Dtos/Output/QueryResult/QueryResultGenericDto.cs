// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResultGenericDto.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResultGenericDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Dtos.Output.QueryResults
{
    /// <summary>
    /// <see cref="QueryResultGenericDto"/>
    /// </summary>
    public class QueryResultGenericDto
    {
        /// <summary>
        /// Gets the links.
        /// </summary>
        /// <value>The links.</value>
        public string Link { get; init; }

        /// <summary>
        /// Gets the UUID.
        /// </summary>
        /// <value>The UUID.</value>
        public Guid Uuid { get; init; }
    }
}