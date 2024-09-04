// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapperProfile.cs" company="ApexAlgorithms">
//     Copyright (c) ApexAlgorithms. All rights reserved.
// </copyright>
// <summary>
// MapperProfile
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace GMapsMagicianAPI.Presentation.WebAPI.Mappers
{
    using AutoMapper;
    using GMapsMagicianAPI.Domain.AgregateModels.Query;
    using GMapsMagicianAPI.Presentation.WebAPI.Dtos.Output.Query;
    using GMapsMagicianAPI.Presentation.WebAPI.Dtos.Output.QueryResult;

    /// <summary>
    /// <see cref="MapperProfile"/>
    /// </summary>
    /// <seealso cref="Profile"/>
    public class MapperProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MapperProfile"/> class.
        /// </summary>
        public MapperProfile()
        {
            this.CreateMap<Query, QueryDetailsDto>()
                .ForMember(x => x.Uuid,
                opt => opt.MapFrom(src => src.UUId));

            this.CreateMap<QueryResult, QueryResultGenericDto>()
                .ForMember(x => x.Link,
                opt => opt.MapFrom(src => src.Link));
        }
    }
}