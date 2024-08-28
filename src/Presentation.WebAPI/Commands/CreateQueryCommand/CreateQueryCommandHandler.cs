// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CreateQueryCommandHandler.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// CreateQueryCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Commands.CreateQueryCommand
{
    using GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryBuilder;
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Repository;
    using GMapsMagicianAPI.Domain.Exceptions;
    using GMapsMagicianAPI.Domain.Services.QueryService;
    using MediatR;

    /// <summary>
    /// <see cref="CreateQueryCommandHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{CreateQueryCommand, Query}"/>
    public class CreateQueryCommandHandler : IRequestHandler<CreateQueryCommand, Query>
    {
        /// <summary>
        /// The query builder
        /// </summary>
        private readonly IQueryBuilder queryBuilder;

        /// <summary>
        /// The query repository
        /// </summary>
        private readonly IQueryRepository queryRepository;

        /// <summary>
        /// The query service
        /// </summary>
        private readonly IQueryService queryService;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateQueryCommandHandler"/> class.
        /// </summary>
        /// <param name="queryBuilder">The query builder.</param>
        /// <param name="queryRepository">The query repository.</param>
        /// <param name="queryService">The query service.</param>
        public CreateQueryCommandHandler(
            IQueryBuilder queryBuilder,
            IQueryRepository queryRepository,
            IQueryService queryService)
        {
            this.queryBuilder = queryBuilder;
            this.queryRepository = queryRepository;
            this.queryService = queryService;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Response from the request</returns>
        /// <exception cref="DuplicatedException">
        /// The Query with RawQuery {request.RawQuery} and tenantId {request.TenantId} already exists.
        /// </exception>
        public async Task<Query> Handle(CreateQueryCommand request, CancellationToken cancellationToken)
        {
            Query query = this.queryBuilder
                .NewQuery(
                request.RawQuery,
                request.TenantId)
                .Build();

            await this.queryService.VerifyInstantQueryAsync(query);

            await this.queryRepository.AddAsync(query, cancellationToken);

            await this.queryRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return query;
        }
    }
}