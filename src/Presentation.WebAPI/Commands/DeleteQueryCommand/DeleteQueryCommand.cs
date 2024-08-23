// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteQueryCommand.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// DeleteQueryCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Commands.DeleteQueryCommand
{
    using MediatR;

    /// <summary>
    /// <see cref="DeleteQueryCommand"/>
    /// </summary>
    /// <seealso cref="INotification"/>
    public class DeleteQueryCommand : INotification
    {
        /// <summary>
        /// Gets the UUID.
        /// </summary>
        /// <value>The UUID.</value>
        public Guid Uuid { get; init; }
    }
}