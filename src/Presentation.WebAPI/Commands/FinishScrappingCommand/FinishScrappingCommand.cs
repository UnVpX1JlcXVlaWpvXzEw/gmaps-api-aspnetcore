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
    /// <seealso cref="IRequest{Query}"/>
    public class FinishScrappingCommand : IRequest<Query>
    {
        /// <summary>
        /// Gets the UUID.
        /// </summary>
        /// <value>The UUID.</value>
        public Guid Uuid { get; init; }
    }
}