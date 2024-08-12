// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDomainEvent.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// IDomainEvent
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.SeedWork
{
    using MediatR;

    /// <summary>
    /// <see cref="IDomainEvent"/>
    /// </summary>
    /// <seealso cref="INotification"/>
    public interface IDomainEvent : INotification
    {
    }
}