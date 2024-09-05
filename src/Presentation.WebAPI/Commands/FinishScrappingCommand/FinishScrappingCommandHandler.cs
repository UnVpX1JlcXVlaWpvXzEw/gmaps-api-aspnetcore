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
    using GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryResultBuilder;
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Repository;
    using GMapsMagicianAPI.Domain.Exceptions;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="FinishScrappingCommandHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{FinishScrappingCommand, {IEnumerable{QueryResult}}"/>
    public class FinishScrappingCommandHandler : IRequestHandler<FinishScrappingCommand, IEnumerable<QueryResult>>
    {
        /// <summary>
        /// The query repository
        /// </summary>
        private readonly IQueryRepository queryRepository;

        /// <summary>
        /// The query result builder
        /// </summary>
        private readonly IQueryResultBuilder queryResultBuilder;

        /// <summary>
        /// The query result repository
        /// </summary>
        private readonly IQueryResultRepository queryResultRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="FinishScrappingCommandHandler"/> class.
        /// </summary>
        /// <param name="queryResultRepository">The query result repository.</param>
        /// <param name="queryResultBuilder">The query result builder.</param>
        /// <param name="queryRepository">The query repository.</param>
        public FinishScrappingCommandHandler(IQueryResultRepository queryResultRepository,
            IQueryResultBuilder queryResultBuilder,
            IQueryRepository queryRepository)
        {
            this.queryResultRepository = queryResultRepository;
            this.queryResultBuilder = queryResultBuilder;
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
            Query query = await this.queryRepository.GetAsync(
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
                QueryResult queryResult = this.queryResultBuilder
                    .NewQueryResult(link)
                    .Build();

                await this.queryResultRepository.Update(queryResult, cancellationToken);

                await this.queryResultRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

                queryResults.Add(queryResult);
                query.AddResult(queryResult);
            }
            return queryResults;
        }
    }
}