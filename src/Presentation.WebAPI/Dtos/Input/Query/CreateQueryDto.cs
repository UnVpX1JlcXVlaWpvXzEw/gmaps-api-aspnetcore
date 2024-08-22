// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateQueryDto.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// CreateQueryDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.Query
{
    /// <summary>
    /// <see cref="CreateQueryDto"/>
    /// </summary>
    public class CreateQueryDto
    {
        /// <summary>
        /// Gets or sets the raw query.
        /// </summary>
        /// <value>The raw query.</value>
        public string RawQuery { get; set; }

        /// <summary>
        /// Gets or sets the tenant identifier.
        /// </summary>
        /// <value>The tenant identifier.</value>
        public Guid TenantId { get; set; }
    }
}