using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Domain.Entities.Skill;
using GriffonCMS.Infrastructure.Command.Abouts;
using GriffonCMS.Infrastructure.Command.Skills;

namespace GriffonCMS.Infrastructure.Maps.Skills;
public class SkillMap : Profile
{
    public SkillMap()
    {
        CreateMap<SkillEntity, CreateSkillCommand>().ReverseMap();
        CreateMap<SkillEntity, DeleteSkillByIdCommand>().ReverseMap();
    }
}