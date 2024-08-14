// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExceptionMiddlewareExtension.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// ExceptionMiddlewareExtension
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Exceptions.Middleware
{
    /// <summary>
    /// <see cref="ExceptionMiddlewareExtension"/>
    /// </summary>
    public static class ExceptionMiddlewareExtension
    {
        /// <summary>
        /// Uses the exception middleware.
        /// </summary>
        /// <param name="application">The application.</param>
        public static void UseExceptionMiddleware(this IApplicationBuilder application)
        {
            application.UseMiddleware<ExceptionMiddleware>();
        }
    }
}