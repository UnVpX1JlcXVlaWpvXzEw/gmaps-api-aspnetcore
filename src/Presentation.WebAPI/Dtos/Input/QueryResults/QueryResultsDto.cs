// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResultsDto.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResultsDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.QueryResults
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;

    /// <summary>
    /// <see cref="QueryResultsDto"/>
    /// </summary>
    public class QueryResultsDto
    {
        /// <summary>
        /// Gets the link.
        /// </summary>
        /// <value>The link.</value>
        public List<QueryResults> Links { get; init; }
    }
}