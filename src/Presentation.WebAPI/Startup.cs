// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Startup.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// Startup
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI
{
    using Domain.Configuration;
    using FluentValidation;
    using FluentValidation.AspNetCore;
    using GMapsMagicianAPI.Infrastructure;
    using GMapsMagicianAPI.Infrastructure.Configuration;
    using GMapsMagicianAPI.Presentation.WebAPI.Configuration;
    using GMapsMagicianAPI.Presentation.WebAPI.Exceptions.Middleware;
    using GMapsMagicianAPI.Presentation.WebAPI.Tools.Cors.Configuration;
    using GMapsMagicianAPI.Presentation.WebAPI.Validation;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.OpenApi.Models;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using Serilog;
    using System.Reflection;

    /// <summary>
    /// <see cref="Startup"/>
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Startup"/> class.
        /// </summary>
        /// <param name="configuration">The configuration.</param>
        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>The configuration.</value>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Configures the specified application.
        /// </summary>
        /// <param name="app">The application.</param>
        public void Configure(WebApplication app)
        {
            MigrateDatabase(app);

            app.UseCors(this.Configuration);

            app.UseExceptionMiddleware();

            app.UseSerilogRequestLogging();

            app.UseSwagger();

            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "GMapsMagicianAPI V1");
            });

            app.UseRouting();

            app.MapControllers();
        }

        /// <summary>
        /// Configures the services.
        /// </summary>
        /// <param name="services">The services.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<GMapsMagicianAPIDBContext>(options =>
                options.UseLazyLoadingProxies(),
                ServiceLifetime.Scoped);

            services.RegisterDomainServices();
            services.RegisterInfrastructureServices();
            services.RegisterPresentationServices();

            services.AddCors(this.Configuration);

            services.AddControllers(options =>
            {
                options.Filters.Add(typeof(ValidationAttribute));
            })
            .ConfigureApiBehaviorOptions(options =>
            {
                options.SuppressModelStateInvalidFilter = true;
            })
            .AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.Converters.Add(new StringEnumConverter());
                options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                options.SerializerSettings.DateTimeZoneHandling = DateTimeZoneHandling.Utc;
            });

            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddFluentValidationAutoValidation();

            services.AddLogging();

            services.AddAutoMapper(typeof(Startup));

            services.AddMediatR(opt =>
            {
                opt.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });

            services.AddSwaggerGenNewtonsoftSupport();

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "GMapsMagicianAPI",
                });
            });
        }

        /// <summary>
        /// Migrates the database.
        /// </summary>
        /// <param name="app">The application.</param>
        private static void MigrateDatabase(WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            var context = scope.ServiceProvider.GetRequiredService<GMapsMagicianAPIDBContext>();

            context.Database.MigrateAsync()
                .GetAwaiter()
                .GetResult();
        }
    }
}