namespace GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryStatusHistoryBuilder
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query.Enums;
    using System;

    /// <summary>
    /// <see cref="IQueryStatusHistoryBuilder"/>
    /// </summary>
    public interface IQueryStatusHistoryBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        QueryStatusHistory Build();

        /// <summary>
        /// Creates new querystatushistory.
        /// </summary>
        /// <param name="scrapingConclusionDate">The scraping conclusion date.</param>
        /// <returns></returns>
        public IQueryStatusHistoryBuilder NewQueryStatusHistory(DateTime scrapingConclusionDate);
    }
}