// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StartScrappingDtoValidator.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// StartScrappingDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Validation.Query
{
    using FluentValidation;
    using GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.Query;

    /// <summary>
    /// <see cref="StartScrappingDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{StartScrappingDto}"/>
    public class StartScrappingDtoValidator : AbstractValidator<StartScrappingDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartScrappingDtoValidator"/> class.
        /// </summary>
        public StartScrappingDtoValidator()
        {
            this.RuleFor(x => x.Uuid)
                .NotEqual(Guid.Empty)
                    .WithMessage("The uuid shouldn't have this value.");
        }
    }
}