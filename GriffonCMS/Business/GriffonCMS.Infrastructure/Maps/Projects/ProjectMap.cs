﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Domain.Entities.Comments;
using GriffonCMS.Domain.Entities.Project;
using GriffonCMS.Infrastructure.Command.Abouts;
using GriffonCMS.Infrastructure.Command.Projects;

namespace GriffonCMS.Infrastructure.Maps.Projects;
public class ProjectMap : Profile
{
    public ProjectMap()
    {
        CreateMap<ProjectEntity, CreateProjectCommand>().ReverseMap();
        CreateMap<ProjectEntity, DeleteProjectByIdCommand>().ReverseMap();
    }
}
