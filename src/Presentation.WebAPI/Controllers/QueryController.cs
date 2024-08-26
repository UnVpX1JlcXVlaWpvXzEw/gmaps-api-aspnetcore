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
    using GMapsMagicianAPI.Presentation.WebAPI.Commands.CreateQueryCommand;
    using GMapsMagicianAPI.Presentation.WebAPI.Commands.DeleteQueryCommand;
    using GMapsMagicianAPI.Presentation.WebAPI.Commands.FinishScrappingCommand;
    using GMapsMagicianAPI.Presentation.WebAPI.Commands.StartScrappingCommand;
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
    [Route("api/v1/Query")]
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
        /// Creates the query asynchronous.
        /// </summary>
        /// <param name="queryDto">The query dto.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(QueryDetailsDto), (int)HttpStatusCode.Created)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> CreateQueryAsync([FromBody] CreateQueryDto queryDto, CancellationToken cancellationToken)
        {
            Query query = await this.mediator.Send(new CreateQueryCommand
            {
                RawQuery = queryDto.RawQuery,
                TenantId = queryDto.TenantId
            }, cancellationToken);

            return this.Created(string.Empty, this.mapper.Map<QueryDetailsDto>(query));
        }

        /// <summary>
        /// Deletes the query asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpDelete("{Uuid}")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.InternalServerError)]
        public async Task<IActionResult> DeleteQueryAsync([FromRoute] DeleteQueryDto filter, CancellationToken cancellationToken)
        {
            await this.mediator.Publish(new DeleteQueryCommand
            {
                Uuid = filter.Uuid
            }, cancellationToken);

            return this.Ok();
        }

        /// <summary>
        /// Finishes the scrapping asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpPatch("{Uuid}/Scraping/Finish")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> FinishScrappingAsync([FromRoute] FinishScrappingDto filter, CancellationToken cancellationToken)
        {
            Query query = await this.mediator.Send(new FinishScrappingCommand
            {
                Uuid = filter.Uuid,
            }, cancellationToken);

            return this.Ok(this.mapper.Map<QueryDetailsDto>(query));
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

        /// <summary>
        /// Starts the scrapping asynchronous.
        /// </summary>
        /// <param name="filter">The filter.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        [HttpPatch("{Uuid}/Scraping/Start")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.InternalServerError)]
        [ProducesResponseType(typeof(ErrorMessage), (int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> StartScrappingAsync([FromRoute] StartScrappingDto filter, CancellationToken cancellationToken)
        {
            Query query = await this.mediator.Send(new StartScrappingCommand
            {
                Uuid = filter.Uuid,
            }, cancellationToken);

            return this.Ok(this.mapper.Map<QueryDetailsDto>(query));
        }
    }
}