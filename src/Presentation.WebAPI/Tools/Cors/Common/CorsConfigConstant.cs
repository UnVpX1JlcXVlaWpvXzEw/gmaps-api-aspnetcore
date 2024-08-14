// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CorsConfigConstant.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// CorsConfigConstant
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Tools.Cors.Common
{
    using GMapsMagicianAPI.Domain.SeedWork;

    /// <summary>
    /// <see cref="CorsConfigConstant"/>
    /// </summary>
    /// <seealso cref="ConstantObject"/>
    internal class CorsConfigConstant : ConstantObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CorsConfigConstant"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        public CorsConfigConstant(string value)
            : base(value)
        {
        }
    }
}