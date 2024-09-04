// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FinishScrappingCommand.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// FinishScrappingCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Commands.FinishScrappingCommand
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using MediatR;

    /// <summary>
    /// <see cref="FinishScrappingCommand"/>
    /// </summary>
    /// <seealso cref="IRequest{QueryResult}"/>
    public class FinishScrappingCommand : IRequest<IEnumerable<QueryResult>>
    {
        /// <summary>
        /// Gets the link.
        /// </summary>
        /// <value>The link.</value>
        public List<string> Links { get; init; }

        /// <summary>
        /// Gets the UUID.
        /// </summary>
        /// <value>The UUID.</value>
        public Guid Uuid { get; init; }
    }
}