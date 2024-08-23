// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteQueryDtoValidator.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// DeleteQueryDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Validation.Query
{
    using FluentValidation;
    using GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.Query;

    /// <summary>
    /// <see cref="DeleteQueryDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{DeleteQueryDto}"/>
    public class DeleteQueryDtoValidator : AbstractValidator<DeleteQueryDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteQueryDtoValidator"/> class.
        /// </summary>
        public DeleteQueryDtoValidator()
        {
            this.RuleFor(x => x.Uuid)
                .NotEqual(Guid.Empty)
                    .WithMessage("The uuid shouldn't have this value.");
        }
    }
}