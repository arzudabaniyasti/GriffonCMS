using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Entities.Reference;
using GriffonCMS.Domain.Entities.Skill;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Skills;
using MediatR;

namespace GriffonCMS.Application.Command.Skills;
public class CreateSkillCommandHandler : IRequestHandler<CreateSkillCommand, Guid>
{
    ISkillRepository _skillRepository;
    private readonly IMapper _mapper;

    public CreateSkillCommandHandler(ISkillRepository skillRepository, IMapper mapper)
    {
        _skillRepository = skillRepository;
        _mapper = mapper;
    }
    public async Task<Guid> Handle(CreateSkillCommand request, CancellationToken cancellationToken)
    {
        var skill = _mapper.Map<SkillEntity>(request);
        await _skillRepository.AddAsync(skill);
        return skill.Id;
    }
}
