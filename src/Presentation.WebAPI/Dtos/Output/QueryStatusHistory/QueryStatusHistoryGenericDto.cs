// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryStatusHistoryGenericDto.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryStatusHistoryGenericDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Dtos.Output.QueryStatusHistory
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query.Enums;

    /// <summary>
    /// <see cref="QueryStatusHistoryGenericDto"/>
    /// </summary>
    public class QueryStatusHistoryGenericDto
    {
        /// <summary>
        /// Gets the scrapping conclusion date.
        /// </summary>
        /// <value>The scrapping conclusion date.</value>
        public DateTime ScrappingConclusionDate { get; init; }

        /// <summary>
        /// Gets the status.
        /// </summary>
        /// <value>The status.</value>
        public QueryStatus Status { get; init; }

        /// <summary>
        /// Gets the UUID.
        /// </summary>
        /// <value>The UUID.</value>
        public Guid Uuid { get; init; }
    }
}