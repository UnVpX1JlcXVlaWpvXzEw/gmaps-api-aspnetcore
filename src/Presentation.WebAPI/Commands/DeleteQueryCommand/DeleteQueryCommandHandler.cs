// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DeleteQueryCommandHandler.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// DeleteQueryCommandHandler
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Commands.DeleteQueryCommand
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Domain.AgregateModels.Repository;
    using GMapsMagicianAPI.Domain.Exceptions;
    using MediatR;

    /// <summary>
    /// <see cref="DeleteQueryCommandHandler"/>
    /// </summary>
    /// <seealso cref="INotificationHandler{DeleteQueryCommand}"/>
    public class DeleteQueryCommandHandler : INotificationHandler<DeleteQueryCommand>
    {
        /// <summary>
        /// The query repository
        /// </summary>
        private readonly IQueryRepository queryRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteQueryCommandHandler"/> class.
        /// </summary>
        /// <param name="queryRepository">The query repository.</param>
        public DeleteQueryCommandHandler(IQueryRepository queryRepository)
        {
            this.queryRepository = queryRepository;
        }

        /// <summary>
        /// Handles a notification
        /// </summary>
        /// <param name="notification">The notification</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <exception cref="NotFoundException">
        /// The query with id {notification.Uuid} wasn't found.
        /// </exception>
        public async Task Handle(DeleteQueryCommand notification, CancellationToken cancellationToken)
        {
            Query query = await this.queryRepository
                .GetAsync(
                    notification.Uuid,
                cancellationToken);

            if (query is null)
            {
                throw new NotFoundException($"The query with id {notification.Uuid} wasn't found.");
            }

            await this.queryRepository.Remove(query, cancellationToken);

            await this.queryRepository.UnitOfWork.SaveEntitiesAsync(cancellationToken);
        }
    }
}