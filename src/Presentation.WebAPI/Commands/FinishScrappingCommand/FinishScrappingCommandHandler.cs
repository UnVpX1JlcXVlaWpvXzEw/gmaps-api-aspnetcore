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
        /// Initializes a new instance of the <see cref="FinishScrappingCommandHandler"/> class.
        /// </summary>
        /// <param name="queryResultRepository">The query result repository.</param>
        /// <param name="queryResultBuilder">The query result builder.</param>
        /// <param name="queryRepository">The query repository.</param>
        public FinishScrappingCommandHandler(
            IQueryResultBuilder queryResultBuilder,
            IQueryRepository queryRepository)
        {
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

            BuildQueryResults(request.Links, query);

            query.FinishScrapping();

            await this.queryRepository.Update(query, cancellationToken);

            await this.queryRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return query.QueryResults;
        }

        /// <summary>
        /// Builds the query results.
        /// </summary>
        /// <param name="links">The links.</param>
        /// <param name="query">The query.</param>
        private void BuildQueryResults(List<string> links, Query query)
        {
            foreach (string link in links)
            {
                QueryResult queryResult = this.queryResultBuilder
                    .NewQueryResult(link)
                    .Build();

                query.AddResult(queryResult);
            }
        }
    }
}