// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StartScrappingRouteDtoValidator.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// StartScrappingRouteDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Validation.Query
{
    using FluentValidation;
    using GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.Query;

    /// <summary>
    /// <see cref="StartScrappingRouteDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{StartScrappingDto}"/>
    public class StartScrappingRouteDtoValidator : AbstractValidator<StartScrappingRouteDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartScrappingDtoValidator"/> class.
        /// </summary>
        public StartScrappingRouteDtoValidator()
        {
            this.RuleFor(x => x.Uuid)
                .NotEqual(Guid.Empty)
                    .WithMessage("The uuid shouldn't have this value.");
        }
    }
}