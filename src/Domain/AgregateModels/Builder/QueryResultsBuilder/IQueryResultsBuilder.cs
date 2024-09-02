// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueryResultsBuilder.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// IQueryResultsBuilder
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryResultsBuilder
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using System.Collections.Generic;

    /// <summary>
    /// <see cref="IQueryResultsBuilder"/>
    /// </summary>
    public interface IQueryResultsBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        List<QueryResults> Build();

        /// <summary>
        /// Creates new queryresult.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns></returns>
        IQueryResultsBuilder NewQueryResult(List<QueryResults> links);
    }
}