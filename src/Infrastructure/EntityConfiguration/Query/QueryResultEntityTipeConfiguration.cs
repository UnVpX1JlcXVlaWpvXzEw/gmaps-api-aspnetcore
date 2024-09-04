// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResultsEntityTypeConfiguration.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResultsEntityTypeConfiguration
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Infrastructure.EntityConfiguration.Query
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Query.Enums;
    using GMapsMagicianAPI.Infrastructure.EntityConfiguration;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    /// <summary>
    /// <see cref="QueryResultEntityTipeConfiguration"/>
    /// </summary>
    /// <seealso cref="EntityTypeConfiguration{QueryResult}"/>
    internal class QueryResultEntityTipeConfiguration : EntityTypeConfiguration<QueryResult>
    {
        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <value>The name of the table.</value>
        protected override string TableName => "QueryResult";

        /// <summary>
        /// Configures the entity.
        /// </summary>
        /// <param name="builder">The builder.</param>
        protected override void ConfigureEntity(EntityTypeBuilder<QueryResult> builder)
        {
            builder.Property(e => e.Link)
                .HasMaxLength(500)
                .IsRequired();

            builder.Property(e => e.Status)
                .HasConversion(x =>
                x.ToString(), v =>
                (QueryResultStatus)Enum.Parse(typeof(QueryResultStatus), v))
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}