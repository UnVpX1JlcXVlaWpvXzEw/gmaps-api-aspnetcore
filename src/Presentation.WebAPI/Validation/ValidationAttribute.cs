// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ValidationAttribute.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// ValidationAttribute
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Validation
{
    using GMapsMagicianAPI.Presentation.WebAPI.Utils;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Filters;

    /// <summary>
    /// <see cref="ValidationAttribute"/>
    /// </summary>
    /// <seealso cref="ActionFilterAttribute"/>
    public class ValidationAttribute : ActionFilterAttribute
    {
        /// <summary>
        /// Called when [action executing].
        /// </summary>
        /// <param name="context">The filter context.</param>
        /// <inheritdoc/>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errors = context.ModelState.Values.Where(v => v.Errors.Count > 0)
                     .SelectMany(v => v.Errors)
                     .Select(v => v.ErrorMessage)
                     .ToArray();

                var responseObj = new ErrorMessage
                {
                    Status = 400,
                    Message = string.Join(", ", errors)
                };

                context.Result = new JsonResult(responseObj)
                {
                    StatusCode = 400
                };
            }
        }
    }
}