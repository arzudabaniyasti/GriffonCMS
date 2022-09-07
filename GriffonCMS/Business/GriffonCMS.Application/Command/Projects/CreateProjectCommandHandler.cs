using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Entities.Project;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Projects;
using MediatR;

namespace GriffonCMS.Application.Command.Projects;
public class CreateProjectCommandHandler : IRequestHandler<CreateProjectCommand, Guid>
{
    IProjectRepository _projectRepository;
    private readonly IMapper _mapper;

    public CreateProjectCommandHandler(IProjectRepository projectRepository, IMapper mapper)
    {
        _projectRepository = projectRepository;
        _mapper = mapper;
    }
    public async Task<Guid> Handle(CreateProjectCommand request, CancellationToken cancellationToken)
    {
        var project = _mapper.Map<ProjectEntity>(request);
        await _projectRepository.AddAsync(project);
        return project.Id;
    }
}
   