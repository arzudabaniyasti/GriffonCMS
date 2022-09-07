using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Project;
using GriffonCMS.Domain.Entities.Reference;
using GriffonCMS.Infrastructure.Command;

namespace GriffonCMS.Infrastructure.Maps.References;
public class ReferenceMap : Profile
{
    public ReferenceMap()
    {
        CreateMap<ReferenceEntity, CreateReferenceCommand>().ReverseMap();
    }
}