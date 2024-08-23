// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FinishScrappingDtoValidator.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// FinishScrappingDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Validation.Query
{
    using FluentValidation;
    using GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.Query;

    /// <summary>
    /// <see cref="FinishScrappingDtoValidator"/>
    /// </summary>
    /// <seealso cref="FluentValidation.AbstractValidator&lt;FinishScrappingDto&gt;"/>
    public class FinishScrappingDtoValidator : AbstractValidator<FinishScrappingDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartScrappingDtoValidator"/> class.
        /// </summary>
        public FinishScrappingDtoValidator()
        {
            this.RuleFor(x => x.Uuid)
                .NotEqual(Guid.Empty)
                    .WithMessage("The uuid shouldn't have this value.");
        }
    }
}