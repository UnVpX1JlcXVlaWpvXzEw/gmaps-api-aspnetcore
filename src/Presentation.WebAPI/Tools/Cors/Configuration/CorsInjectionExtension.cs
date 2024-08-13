// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CorsInjectionExtension.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// CorsInjectionExtension
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Tools.Cors.Configuration
{
    using GMapsMagicianAPI.Presentation.WebAPI.Tools.Cors.Common;
    using GMapsMagicianAPI.Presentation.WebAPI.Tools.Cors.Configuration;

    /// <summary>
    /// <see cref="CorsInjectionExtension"/>
    /// </summary>
    public static class CorsInjectionExtension
    {
        /// <summary>
        /// Adds the cors.
        /// </summary>
        /// <param name="services">The services.</param>
        /// <param name="configuration">The configuration.</param>
        public static void AddCors(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
                options.AddPolicy(CorsConfigConstantCollection.GetCorsOriginCollectionName(configuration), builder =>
                {
                    builder.WithOrigins(CorsConfigConstantCollection.GetCorsAllowedOrigins(configuration))
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
            });
        }

        /// <summary>
        /// Uses the cors.
        /// </summary>
        /// <param name="app">The application.</param>
        /// <param name="configuration">The configuration.</param>
        public static void UseCors(this IApplicationBuilder app, IConfiguration configuration)
        {
            app.UseCors(CorsConfigConstantCollection.GetCorsOriginCollectionName(configuration));

            app.UseHttpsRedirection();
        }
    }
}