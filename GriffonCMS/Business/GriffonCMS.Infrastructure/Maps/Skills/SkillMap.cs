using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Skill;
using GriffonCMS.Infrastructure.Command;

namespace GriffonCMS.Infrastructure.Maps.Skills;
public class SkillMap : Profile
{
    public SkillMap()
    {
        CreateMap<SkillEntity, CreateSkillCommand>().ReverseMap();
    }
}