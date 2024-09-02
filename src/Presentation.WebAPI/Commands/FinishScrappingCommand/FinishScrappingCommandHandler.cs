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
    using GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryResultsBuilder;
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Repository;
    using GMapsMagicianAPI.Domain.Exceptions;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="FinishScrappingCommandHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{FinishScrappingCommand, IEnumerable{QueryResults}}"/>
    public class FinishScrappingCommandHandler : IRequestHandler<FinishScrappingCommand, IEnumerable<QueryResults>>
    {
        /// <summary>
        /// The query results builder
        /// </summary>
        private readonly IQueryResultsBuilder queryResultsBuilder;

        /// <summary>
        /// The query results repository
        /// </summary>
        private readonly IQueryResultsRepository queryResultsRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="FinishScrappingCommandHandler"/> class.
        /// </summary>
        /// <param name="queryResultsRepository">The query results repository.</param>
        /// <param name="queryResultsBuilder">The query results builder.</param>
        public FinishScrappingCommandHandler(IQueryResultsRepository queryResultsRepository, IQueryResultsBuilder queryResultsBuilder)
        {
            this.queryResultsRepository = queryResultsRepository;
            this.queryResultsBuilder = queryResultsBuilder;
        }

        /// <summary>
        /// Handles a request
        /// </summary>
        /// <param name="request">The request</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <returns>Response from the request</returns>
        /// <exception cref="NotFoundException">The query with link {request.Link} wasn't found.</exception>
        public async Task<IEnumerable<QueryResults>> Handle(FinishScrappingCommand request, CancellationToken cancellationToken)
        {
            List<QueryResults> queryResults = this.queryResultsBuilder
                .NewQueryResult(request.Links)
                .Build();

            if (queryResultsRepository is null)
            {
                throw new NotFoundException($"The query with link {request.Links} wasn't found.");
            }

            foreach (var queryResult in queryResults)
            {
                queryResult.FinishScrapping();
            }

            await this.queryResultsRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);

            return (IEnumerable<QueryResults>)queryResults;
        }
    }
}