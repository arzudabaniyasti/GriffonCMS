using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Project;
using GriffonCMS.Domain.Entities.WorkExperience;
using GriffonCMS.Infrastructure.Command;

namespace GriffonCMS.Infrastructure.Maps.WorkExperience;
public class WorkExperienceMap : Profile
{
    public WorkExperienceMap()
    {
        CreateMap<WorkExperienceEntity, CreateWorkExperienceCommand>().ReverseMap();
    }
}