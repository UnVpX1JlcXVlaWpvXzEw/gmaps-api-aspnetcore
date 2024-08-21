// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetQueryByTenantIdQueryHandler.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// GetQueryByTenantIdQueryHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Queries.Query
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Repository;
    using MediatR;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="GetQueryByTenantIdQueryHandler"/>
    /// </summary>
    /// <seealso cref="IRequestHandler{GetQueryByTenantIdQuery, IEnumerable{Query}}"/>
    public class GetQueryByTenantIdQueryHandler : IRequestHandler<GetQueryByTenantIdQuery, IEnumerable<Query>>
    {
        /// <summary>
        /// The query repository
        /// </summary>
        private readonly IQueryRepository queryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="GetQueryByTenantIdQueryHandler"/> class.
        /// </summary>
        /// <param name="queryRepository">The query repository.</param>
        public GetQueryByTenantIdQueryHandler(IQueryRepository queryRepository)
        {
            this.queryRepository = queryRepository;
        }

        /// <summary>
        /// Handles the specified query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns></returns>
        public async Task<IEnumerable<Query>> Handle(GetQueryByTenantIdQuery query, CancellationToken cancellationToken)
        {
            IEnumerable<Query> queries = await this.queryRepository.GetByTenantIdAsync(query.TenantId, cancellationToken);

            return queries;
        }
    }
}