// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateQueryCommand.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// CreateQueryCommand
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Commands.Query
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using MediatR;

    /// <summary>
    /// <see cref="CreateQueryCommand"/>
    /// </summary>
    /// <seealso cref="IRequest{Query}"/>
    public class CreateQueryCommand : IRequest<Query>
    {
        /// <summary>
        /// Gets the raw query.
        /// </summary>
        /// <value>The raw query.</value>
        public string RawQuery { get; init; }

        /// <summary>
        /// Gets the tenant identifier.
        /// </summary>
        /// <value>The tenant identifier.</value>
        public Guid TenantId { get; init; }
    }
}