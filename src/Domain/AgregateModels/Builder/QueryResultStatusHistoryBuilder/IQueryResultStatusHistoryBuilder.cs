namespace GMapsMagicianAPI.Domain.AgregateModels.Builder.QueryResultStatusHistory
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using System;

    /// <summary>
    /// <see cref="IQueryResultStatusHistoryBuilder"/>
    /// </summary>
    public interface IQueryResultStatusHistoryBuilder
    {
        /// <summary>
        /// Builds this instance.
        /// </summary>
        /// <returns></returns>
        QueryResultStatusHistory Build();

        /// <summary>
        /// Creates new queryresultstatushistory.
        /// </summary>
        /// <param name="scrapingConclusionDate">The scraping conclusion date.</param>
        /// <returns></returns>
        IQueryResultStatusHistoryBuilder NewQueryResultStatusHistory(DateTime scrapingConclusionDate);
    }
}