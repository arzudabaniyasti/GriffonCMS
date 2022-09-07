using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Exceptions;
using MediatR;

namespace GriffonCMS.Application.Command.WorkExperiences;
public class DeleteWorkExperienceByIdCommandHandler : IRequestHandler<DeleteWorkExperienceByIdCommand, Guid>
{

    private readonly IWorkExperienceRepository _workExperienceRepository;
    public DeleteWorkExperienceByIdCommandHandler(IWorkExperienceRepository workExperienceRepository)
    {
        _workExperienceRepository = workExperienceRepository;
    }
    public async Task<Guid> Handle(DeleteWorkExperienceByIdCommand command, CancellationToken cancellationToken)
    {
        var workExperience = await _workExperienceRepository.GetByIdAsync(command.Id);
        if (workExperience == null) throw new ApiException($"Work Experience Not Found.");
        await _workExperienceRepository.DeleteByIdAsync(workExperience.Id);
        return workExperience.Id;
    }
}