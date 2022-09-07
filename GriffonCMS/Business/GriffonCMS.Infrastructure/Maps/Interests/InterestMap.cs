using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Interest;
using GriffonCMS.Infrastructure.Command;

namespace GriffonCMS.Infrastructure.Maps.Interests;
public class InterestMap : Profile
{
    public InterestMap()
    {
        CreateMap<InterestEntity, CreateInterestCommand>().ReverseMap();
    }
}
