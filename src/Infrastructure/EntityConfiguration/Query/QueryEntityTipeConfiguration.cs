// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QUeryEnttyTipeConfiguration.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QUeryEnttyTipeConfiguration
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Infrastructure.EntityConfiguration.Query
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Query.Enums;
    using GMapsMagicianAPI.Infrastructure.EntityConfiguration;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// </summary>
    /// <seealso cref="EntityTypeConfiguration{Query}"/>
    internal class QueryEntityTipeConfiguration : EntityTypeConfiguration<Query>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        protected override string TableName => "Query";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<Query> builder)
        {
            builder.Property(e => e.RawQuery)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.GMapsSearchLink)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.TenantId)
                .IsRequired();

            builder.Property(e => e.ActiveScraper)
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(e => e.IsInstant)
                .IsRequired();

            builder.Property(e => e.Status)
                .HasConversion(x =>
                x.ToString(), v =>
                (QueryStatusHistory)Enum.Parse(typeof(QueryStatusHistory), v))
                .HasMaxLength(20)
                .IsRequired();

            builder.HasMany(e => e.StatusHistory)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(e => e.QueryResults)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}