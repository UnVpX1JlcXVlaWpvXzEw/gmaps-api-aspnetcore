// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StartScrappingCommandHandler.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// StartScrappingCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Commands.StartScrappingCommand
{
    using GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryBuilder;
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Repository;
    using GMapsMagicianAPI.Domain.Exceptions;
    using MediatR;

    /// <summary>
    /// <see cref="StartScrappingCommandHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{StartScrappingCommand, Query}"/>
    public class StartScrappingCommandHandler : IRequestHandler<StartScrappingCommand, Query>

    {
        /// <summary>
        /// The query repository
        /// </summary>
        private readonly IQueryRepository queryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="StartScrappingCommandHandler"/> class.
        /// </summary>
        /// <param name="queryRepository">The query repository.</param>
        /// <param name="queryBuilder">The query builder.</param>
        public StartScrappingCommandHandler(IQueryRepository queryRepository, IQueryBuilder queryBuilder)
        {
            this.queryRepository = queryRepository;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Response from the request</returns>
        /// <exception cref="NotFoundException">The query with id {request.Uuid} wasn't found.</exception>
        public async Task<Query> Handle(StartScrappingCommand request, CancellationToken cancellationToken)
        {
            Query query = await this.queryRepository
                .GetAsync(
                    request.Uuid,
                    cancellationToken);

            if (query is null)
            {
                throw new NotFoundException($"The query with id {request.Uuid} wasn't found.");
            }

            query.StartScrapping(request.Uuid);

            await this.queryRepository.Update(query, cancellationToken);

            await this.queryRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return query;
        }
    }
}