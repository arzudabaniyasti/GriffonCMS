using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Comments;
using GriffonCMS.Domain.Entities.Project;
using GriffonCMS.Infrastructure.Command;

namespace GriffonCMS.Infrastructure.Maps.Projects;
public class ProjectMap : Profile
{
    public ProjectMap()
    {
        CreateMap<ProjectEntity, CreateProjectCommand>().ReverseMap();
    }
}
