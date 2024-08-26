// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetUnscrappedQueryQuery.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// GetUnscrappedQueryQuery
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Queries.GetUnscrappedQueryQuery
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using MediatR;

    /// <summary>
    /// <see cref="GetUnscrappedQueryQuery"/>
    /// </summary>
    /// <seealso cref="IRequest{Query}"/>
    public class GetUnscrappedQueryQuery : IRequest<Query>
    {
        /// <summary>
        /// Gets a value indicating whether this instance is instant.
        /// </summary>
        /// <value><c>true</c> if this instance is instant; otherwise, <c>false</c>.</value>
        public bool IsInstant { get; init; }
    }
}