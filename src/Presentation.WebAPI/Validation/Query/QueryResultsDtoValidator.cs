// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryResultsDtoValidator.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryResultsDtoValidator
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Validation.Query
{
    using FluentValidation;
    using GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.QueryResults;

    /// <summary>
    /// <see cref="QueryResultsDtoValidator"/>
    /// </summary>
    /// <seealso cref="AbstractValidator{QueryResultsDto};"/>
    public class QueryResultsDtoValidator : AbstractValidator<QueryResultsDto>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryResultsDtoValidator"/> class.
        /// </summary>
        public QueryResultsDtoValidator()
        {
            this.RuleFor(x => x.Links).NotNull();
        }
    }
}