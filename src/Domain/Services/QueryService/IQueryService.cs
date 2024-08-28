// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IQueryService.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// IQueryService
// </summary>
// ----------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Domain.Services.QueryService
{
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using System.Threading.Tasks;

    /// <summary>
    /// <see cref="IQueryService"/>
    /// </summary>
    public interface IQueryService
    {
        Task VerifyInstantQueryAsync(Query query);
    }
}