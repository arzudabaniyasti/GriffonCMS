using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Skills;
using GriffonCMS.Infrastructure.Exceptions;
using MediatR;

namespace GriffonCMS.Application.Command.Skills;

public class DeleteSkillByIdCommandHandler : IRequestHandler<DeleteSkillByIdCommand, Guid>
{

    private readonly ISkillRepository _skillRepository;
    public DeleteSkillByIdCommandHandler(ISkillRepository skillRepository)
    {
        _skillRepository = skillRepository;
    }
    public async Task<Guid> Handle(DeleteSkillByIdCommand command, CancellationToken cancellationToken)
    {
        var skill = await _skillRepository.GetByIdAsync(command.Id);
        if (skill == null) throw new ApiException($"Skill Not Found.");
        await _skillRepository.DeleteByIdAsync(skill.Id);
        return skill.Id;
    }
}