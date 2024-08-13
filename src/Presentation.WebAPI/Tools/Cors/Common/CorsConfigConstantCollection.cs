﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CorsConfigConstantCollection.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// CorsConfigConstantCollection
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Tools.Cors.Common
{
    /// <summary>
    /// <see cref="CorsConfigConstantCollection"/>
    /// </summary>
    internal static class CorsConfigConstantCollection
    {
        /// <summary>
        /// Gets the cors allowed origins.
        /// </summary>
        /// <value>The cors allowed origins.</value>
        private static CorsConfigConstant CorsAllowedOrigins => new("Cors:AllowedOrigins");

        /// <summary>
        /// Gets the name of the cors origin collection.
        /// </summary>
        /// <value>The name of the cors origin collection.</value>
        private static CorsConfigConstant CorsOriginCollectionName => new("Cors:OriginCollectionName");

        /// <summary>
        /// Gets the cors allowed origins.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <returns></returns>
        internal static string[] GetCorsAllowedOrigins(IConfiguration configuration)
            => configuration.GetSection(CorsAllowedOrigins.Value).Get<string[]>();

        /// <summary>
        /// Gets the name of the cors origin collection.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        /// <returns></returns>
        internal static string GetCorsOriginCollectionName(IConfiguration configuration)
                    => configuration.GetSection(CorsOriginCollectionName.Value).Value;
    }
}