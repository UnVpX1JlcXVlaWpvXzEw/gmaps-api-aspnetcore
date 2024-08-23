// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteQueryDto.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// DeleteQueryDto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.Query
{
    /// <summary>
    /// <see cref="DeleteQueryDto"/>
    /// </summary>
    public class DeleteQueryDto
    {
        /// <summary>
        /// Gets the UUID.
        /// </summary>
        /// <value>The UUID.</value>
        public Guid Uuid { get; init; }
    }
}