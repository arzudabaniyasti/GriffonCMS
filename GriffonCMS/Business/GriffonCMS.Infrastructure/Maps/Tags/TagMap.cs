using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Tag;
using GriffonCMS.Infrastructure.DTOS.Tags;

namespace GriffonCMS.Infrastructure.Maps.Tags;
public class TagMap : Profile
{
    public TagMap()
    {
        CreateMap<TagEntity, GetTagDto>();
        CreateMap<GetTagDto, TagEntity>();
    }
}
