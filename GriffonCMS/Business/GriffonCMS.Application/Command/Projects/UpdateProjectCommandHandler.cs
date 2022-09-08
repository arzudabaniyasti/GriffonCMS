using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Entities.Interest;
using GriffonCMS.Domain.Entities.Project;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Interests;
using GriffonCMS.Infrastructure.Command.Projects;
using GriffonCMS.Infrastructure.Exceptions;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Application.Command.Projects;
public class UpdateProjectCommandHandler : IRequestHandler<UpdateProjectCommand, Response<Guid>>
{
    private readonly IProjectRepository _projectRepository;
    private readonly IMapper _mapper;
    public UpdateProjectCommandHandler(IProjectRepository projectRepository, IMapper mapper)
    {
        _projectRepository = projectRepository;
        _mapper = mapper;
    }
    public async Task<Response<Guid>> Handle(UpdateProjectCommand command, CancellationToken cancellationToken)
    {
        var project = await _projectRepository.GetByIdAsync(command.Id);

        if (project == null)
        {
            throw new ApiException($"Project Not Found.");
        }
        else
        {
            project = _mapper.Map<ProjectEntity>(project);
            _projectRepository.Update(project);
            return new Response<Guid>(project.Id);
        }
    }
}