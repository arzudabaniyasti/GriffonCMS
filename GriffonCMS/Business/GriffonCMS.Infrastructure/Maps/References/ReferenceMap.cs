using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Domain.Entities.Project;
using GriffonCMS.Domain.Entities.Reference;
using GriffonCMS.Infrastructure.Command.Abouts;
using GriffonCMS.Infrastructure.Command.References;
using GriffonCMS.Infrastructure.DTOS.References;
using GriffonCMS.Infrastructure.Queries.References;

namespace GriffonCMS.Infrastructure.Maps.References;
public class ReferenceMap : Profile
{
    public ReferenceMap()
    {
        CreateMap<ReferenceEntity, CreateReferenceCommand>().ReverseMap();
        CreateMap<ReferenceEntity, DeleteReferenceByIdCommand>().ReverseMap();
        CreateMap<ReferenceEntity, UpdateReferenceCommand>().ReverseMap();

        CreateMap<ReferenceEntity, GetReferenceQuery>().ReverseMap();
        CreateMap<ReferenceEntity, GetReferenceDto>().ReverseMap();
    }
}