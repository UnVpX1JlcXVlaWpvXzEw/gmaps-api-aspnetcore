// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueryController.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// QueryController
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Controllers
{
    using AutoMapper;
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Presentation.WebAPI.Dtos.Input.Query;
    using GMapsMagicianAPI.Presentation.WebAPI.Dtos.Output.Query;
    using GMapsMagicianAPI.Presentation.WebAPI.Queries.Query;
    using GMapsMagicianAPI.Presentation.WebAPI.Utils;
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using System.Net;

    /// <summary>
    /// <see cref="QueryController"/>
    /// </summary>
    /// <seealso cref="Controller"/>
    [ApiController]
    [Route("api/v1/Newsletter")]
    public class QueryController : Controller
    {
        /// <summary>
        /// The mapper
        /// </summary>
        private readonly IMapper mapper;

        /// <summary>
        /// The mediator
        /// </summary>
        private readonly IMediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryController"/> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        /// <param name="mediator">The mediator.</param>
        public QueryController(
            IMapper mapper,
            IMediator mediator)
        {
            this.mapper = mapper;
            this.mediator = mediator;
        }

        /// <summary>
        /// Gets the by tenant identifier asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<QueryDetailsDto>), (int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> GetByTenantIdAsync([FromQuery] GetQueryByTenantIdDto filter, CancellationToken cancellationToken)
        {
            IEnumerable<Query> queries = await this.mediator.Send(new GetQueryByTenantIdQuery
            {
                TenantId = filter.TenantId
            }, cancellationToken);

            return this.Ok(this.mapper.Map<IEnumerable<QueryDetailsDto>>(queries));
        }
    }
}