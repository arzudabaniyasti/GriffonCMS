using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Domain.Entities.Project;
using GriffonCMS.Domain.Entities.WorkExperience;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Abouts;
using GriffonCMS.Infrastructure.Command.WorkExperiences;
using GriffonCMS.Infrastructure.DTOS.WorkExperiences;
using GriffonCMS.Infrastructure.Queries.WorkExperiences;

namespace GriffonCMS.Infrastructure.Maps.WorkExperience;
public class WorkExperienceMap : Profile
{
    public WorkExperienceMap()
    {
        CreateMap<WorkExperienceEntity, CreateWorkExperienceCommand>().ReverseMap();
        CreateMap<WorkExperienceEntity, DeleteWorkExperienceByIdCommand>().ReverseMap();
        CreateMap<WorkExperienceEntity, UpdateWorkExperienceCommand>().ReverseMap();

        CreateMap<WorkExperienceEntity, GetWorkExperienceQuery>().ReverseMap();
        CreateMap<WorkExperienceEntity, GetWorkExperienceDto>().ReverseMap();
    }
}