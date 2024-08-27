// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StartScrappingBodyDtoValidator.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// StartScrappingBodyDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Validation.Query
{
    using FluentValidation;
    using GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.Query;

    /// <summary>
    /// <see cref="StartScrappingBodyDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{StartScrappingBodyDto}"/>
    public class StartScrappingBodyDtoValidator : AbstractValidator<StartScrappingBodyDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartScrappingBodyDtoValidator"/> class.
        /// </summary>
        public StartScrappingBodyDtoValidator()
        {
            this.RuleFor(x => x.ActiveScrapper)
                .NotEqual(string.Empty)
                    .WithMessage("The active scrapper shouldn't be empty.")
                .MaximumLength(100)
                    .WithMessage("The active scrapper shouldn't be longer than 100 characters.");

            this.RuleFor(x => x.GMapsSearchLink)
                .NotEqual(string.Empty)
                    .WithMessage("The g maps search link shouldn't be empty.")
                .MaximumLength(500)
                    .WithMessage("The g maps search link shouldn't be longer than 500 characters.");
        }
    }
}