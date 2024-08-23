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

    public class StartScrappingCommandHandler : IRequestHandler<StartScrappingCommand, Query>

    {
        private readonly IQueryRepository queryRepository;

        public StartScrappingCommandHandler(IQueryRepository queryRepository, IQueryBuilder queryBuilder)
        {
            this.queryRepository = queryRepository;
        }

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