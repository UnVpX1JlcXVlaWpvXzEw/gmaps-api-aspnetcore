// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateQueryDtoValidator.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// CreateQueryDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Validation.Query
{
    using FluentValidation;
    using GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.Query;

    /// <summary>
    /// <see cref="CreateQueryDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{CreateQueryDto}"/>
    public class CreateQueryDtoValidator : AbstractValidator<CreateQueryDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateQueryDtoValidator"/> class.
        /// </summary>
        public CreateQueryDtoValidator()
        {
            this.RuleFor(x => x.RawQuery)
                .NotEqual(string.Empty)
                    .WithMessage("The RawQuery shouldn't be empty.")
                .MaximumLength(500)
                    .WithMessage("The RawQuery shouldn't be longer than 500 characters.");

            this.RuleFor(x => x.TenantId)
                .NotEqual(Guid.Empty)
                    .WithMessage("The TenantId shouldn't have the default value (00000000-0000-0000-0000-000000000000).");
        }
    }
}