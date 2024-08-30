// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FinishScrappingCommandHandler.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// FinishScrappingCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Commands.FinishScrappingCommand
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Repository;
    using GMapsMagicianAPI.Domain.Exceptions;
    using MediatR;

    /// <summary>
    /// <see cref="FinishScrappingCommandHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{FinishScrappingCommand, Query}"/>
    public class FinishScrappingCommandHandler : IRequestHandler<FinishScrappingCommand, Query>
    {
        /// <summary>
        /// The query repository
        /// </summary>
        private readonly IQueryRepository queryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="FinishScrappingCommandHandler"/> class.
        /// </summary>
        /// <param name="queryRepository">The query repository.</param>
        public FinishScrappingCommandHandler(IQueryRepository queryRepository)
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
        public async Task<Query> Handle(FinishScrappingCommand request, CancellationToken cancellationToken)
        {
            Query query = await this.queryRepository
                .GetAsync(
                    request.Uuid,
                    cancellationToken);

            if (query is null)
            {
                throw new NotFoundException($"The query with id {request.Uuid} wasn't found.");
            }

            query.FinishScrapping();

            await this.queryRepository.Update(query, cancellationToken);

            await this.queryRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return query;
        }
    }
}