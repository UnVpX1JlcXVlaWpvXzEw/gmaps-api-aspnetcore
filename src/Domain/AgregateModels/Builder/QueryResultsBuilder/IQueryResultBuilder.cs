// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueryResultBuilder.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// IQueryResultBuilder
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryResultBuilder
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;

    /// <summary>
    /// <see cref="IQueryResultBuilder"/>
    /// </summary>
    public interface IQueryResultBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        QueryResult Build();

        /// <summary>
        /// Creates new queryresult.
        /// </summary>
        /// <param name="link">The link.</param>
        /// <returns></returns>
        IQueryResultBuilder NewQueryResult(string link);
    }
}