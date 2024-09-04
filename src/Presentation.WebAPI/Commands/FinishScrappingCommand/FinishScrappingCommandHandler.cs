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
    using GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryBuilder;
    using GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryResultsBuilder;
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Repository;
    using GMapsMagicianAPI.Domain.Exceptions;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// </summary>
    /// <seealso cref="IRequestHandler{FinishScrappingCommand, {IEnumerable}QueryResult}"/>
    public class FinishScrappingCommandHandler : IRequestHandler<FinishScrappingCommand, IEnumerable<QueryResult>>
    {
        /// <summary>
        /// The query repository
        /// </summary>
        private readonly IQueryRepository queryRepository;

        /// <summary>
        /// The query results builder
        /// </summary>
        private readonly IQueryResultBuilder queryResultsBuilder;

        /// <summary>
        /// The query results repository
        /// </summary>
        private readonly IQueryResultRepository queryResultsRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="FinishScrappingCommandHandler"/> class.
        /// </summary>
        /// <param name="queryResultsRepository">The query results repository.</param>
        /// <param name="queryResultsBuilder">The query results builder.</param>
        /// <param name="queryRepository">The query repository.</param>
        /// <param name="queryBuilder">The query builder.</param>
        public FinishScrappingCommandHandler(IQueryResultRepository queryResultsRepository, IQueryResultBuilder queryResultsBuilder, IQueryRepository queryRepository, IQueryBuilder queryBuilder)
        {
            this.queryResultsRepository = queryResultsRepository;
            this.queryResultsBuilder = queryResultsBuilder;
            this.queryRepository = queryRepository;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Response from the request</returns>
        /// <exception cref="NotFoundException">
        /// The query with id {request.Uuid} wasn't found. or The query with link {request.Links}
        /// wasn't found.
        /// </exception>
        public async Task<IEnumerable<QueryResult>> Handle(FinishScrappingCommand request, CancellationToken cancellationToken)
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

            var queryResults = new List<QueryResult>();

            foreach (string link in request.Links)
            {
                QueryResult queryResult = this.queryResultsBuilder
                    .NewQueryResult(link)
                    .Build();

                if (queryResult is null)
                {
                    throw new NotFoundException($"The query with link {request.Links} wasn't found.");
                }

                await this.queryResultsRepository.Update(queryResult, cancellationToken);

                await this.queryResultsRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

                queryResults.Add(queryResult);
                query.AddResults(queryResult);
            }
            return queryResults;
        }
    }
}