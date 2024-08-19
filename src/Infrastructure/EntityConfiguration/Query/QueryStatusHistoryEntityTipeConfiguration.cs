// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryStatusHistoryEntityTipeConfiguration.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryStatusHistoryEntityTipeConfiguration
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Infrastructure.EntityConfiguration.Query
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query.Enums;
    using GMapsMagicianAPI.Infrastructure.EntityConfiguration;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// <see cref="QueryStatusHistoryEntityTipeConfiguration"/>
    /// </summary>
    /// <seealso cref="EntityTypeConfiguration{QueryStatusHistory}"/>
    internal class QueryStatusHistoryEntityTipeConfiguration : EntityTypeConfiguration<QueryStatusHistory>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        protected override string TableName => "QueryStatusHistory";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<QueryStatusHistory> builder)
        {
            builder.Property(e => e.Status)
                .HasConversion(x =>
                x.ToString(), v =>
                (QueryStatus)Enum.Parse(typeof(QueryStatus), v))
                .HasMaxLength(20)
                .IsRequired();

            builder.Property(e => e.ScrapingConclusionDate)
                .IsRequired();
        }
    }
}