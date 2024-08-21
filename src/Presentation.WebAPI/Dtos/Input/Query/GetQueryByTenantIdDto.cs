// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetQueryByTenantIdDto.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// GetQueryByTenantIdDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.Query
{
    /// <summary>
    /// <see cref="GetQueryByTenantIdDto"/>
    /// </summary>
    public class GetQueryByTenantIdDto
    {
        /// <summary>
        /// Gets or sets the tenant identifier.
        /// </summary>
        /// <value>The tenant identifier.</value>
        public Guid TenantId { get; set; }
    }
}