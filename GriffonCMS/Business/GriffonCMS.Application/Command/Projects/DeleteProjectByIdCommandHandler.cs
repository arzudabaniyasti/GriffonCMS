using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Projects;
using GriffonCMS.Infrastructure.Exceptions;
using MediatR;

namespace GriffonCMS.Application.Command.Projects;

public class DeleteProjectByIdCommandHandler : IRequestHandler<DeleteProjectByIdCommand, Guid>
{

    private readonly IProjectRepository _projectRepository;
    public DeleteProjectByIdCommandHandler(IProjectRepository projectRepository)
    {
        _projectRepository = projectRepository;
    }
    public async Task<Guid> Handle(DeleteProjectByIdCommand command, CancellationToken cancellationToken)
    {
        var project = await _projectRepository.GetByIdAsync(command.Id);
        if (project == null) throw new ApiException($"Project Not Found.");
        await _projectRepository.DeleteByIdAsync(project.Id);
        return project.Id;
    }
}