// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetQueryDtoValidator.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// GetQueryDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Validation.Query
{
    using FluentValidation;
    using GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.Query;

    /// <summary>
    /// <see cref="GetQueryDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{GetQueryByTenantIdDto}"/>
    public class GetQueryDtoValidator : AbstractValidator<GetQueryByTenantIdDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetQueryDtoValidator"/> class.
        /// </summary>
        public GetQueryDtoValidator()
        {
            this.RuleFor(x => x.TenantId)
                .NotEqual(Guid.Empty)
                    .WithMessage("The TenantId shouldn't have the default value (00000000-0000-0000-0000-000000000000).");
        }
    }
}