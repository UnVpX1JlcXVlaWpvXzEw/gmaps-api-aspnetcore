// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ServiceCollection.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// ServiceCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.Configuration
{
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// <see cref="ServiceCollection"/>
    /// </summary>
    public static class ServiceCollection
    {
        /// <summary>
        /// Registers the domain services.
        /// </summary>
        /// <param name="services">The services.</param>
        public static void RegisterDomainServices(this IServiceCollection services)
        {
        }
    }
}