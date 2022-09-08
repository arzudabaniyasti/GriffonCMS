using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Domain.Entities.Interest;
using GriffonCMS.Infrastructure.Command.Abouts;
using GriffonCMS.Infrastructure.Command.Interests;
using GriffonCMS.Infrastructure.DTOS.Interests;
using GriffonCMS.Infrastructure.Queries.Interests;

namespace GriffonCMS.Infrastructure.Maps.Interests;
public class InterestMap : Profile
{
    public InterestMap()
    {
        CreateMap<InterestEntity, CreateInterestCommand>().ReverseMap();
        CreateMap<InterestEntity, DeleteInterestByIdCommand>().ReverseMap();
        CreateMap<InterestEntity, UpdateInterestCommand>().ReverseMap();

        CreateMap<InterestEntity, GetInterestQuery>().ReverseMap();
        CreateMap<InterestEntity, GetInterestDto>().ReverseMap();
    }
}
