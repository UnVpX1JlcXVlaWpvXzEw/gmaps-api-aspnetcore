// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StartScrappingCommand.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// StartScrappingCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Commands.StartScrappingCommand
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using MediatR;

    /// <summary>
    /// <see cref="StartScrappingCommand"/>"/&gt;
    /// </summary>
    /// <seealso cref="INotification"/>
    public class StartScrappingCommand : IRequest<Query>
    {
        /// <summary>
        /// Gets the UUID.
        /// </summary>
        /// <value>The UUID.</value>
        public Guid Uuid { get; init; }
    }
}