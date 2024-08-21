// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResultStatusHistoryEntityTipeConfiguration.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResultStatusHistoryEntityTipeConfiguration
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Infrastructure.EntityConfiguration.Query
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Query.Enums;
    using GMapsMagicianAPI.Infrastructure.EntityConfiguration;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// <see cref="QueryResultStatusHistoryEntityTypeConfiguration"/>
    /// </summary>
    /// <seealso cref="EntityTypeConfiguration{QueryResultStatusHistory}"/>
    internal class QueryResultStatusHistoryEntityTypeConfiguration : EntityTypeConfiguration<QueryResultStatusHistory>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        protected override string TableName => "QueryResultStatusHistory";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<QueryResultStatusHistory> builder)
        {
            builder.Property(e => e.Status)
                .HasConversion(x =>
                x.ToString(), v =>
                (QueryResultStatus)Enum.Parse(typeof(QueryResultStatus), v))
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.ScrapingConclusionDate)
                .IsRequired();
        }
    }
}