// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetUnscrappedQueryQueryHandler.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// GetUnscrappedQueryQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Queries.GetUnscrappedQueryQuery
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Repository;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="GetUnscrappedQueryQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetUnscrappedQueryQuery, Query}"/>
    public class GetUnscrappedQueryQueryHandler : IRequestHandler<GetUnscrappedQueryQuery, Query>
    {
        /// <summary>
        /// The query repository
        /// </summary>
        private readonly IQueryRepository queryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUnscrappedQueryQueryHandler"/> class.
        /// </summary>
        /// <param name="queryRepository">The query repository.</param>
        public GetUnscrappedQueryQueryHandler(IQueryRepository queryRepository)
        {
            this.queryRepository = queryRepository;
        }

        /// <summary>
        /// Handles the specified query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<Query> Handle(GetUnscrappedQueryQuery query, CancellationToken cancellationToken)
        {
            Query request = await this.queryRepository.GetUnscrappedQueryAsync(query.IsInstant, cancellationToken);

            return request;
        }
    }
}