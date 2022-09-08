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
using GriffonCMS.Infrastructure.Command.References;
using GriffonCMS.Infrastructure.Command.Skills;
using GriffonCMS.Infrastructure.Exceptions;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Application.Command.Skills;

public class UpdateSkillCommandHandler : IRequestHandler<UpdateSkillCommand, Response<Guid>>
{
    private readonly ISkillRepository _skillRepository;
    private readonly IMapper _mapper;
    public UpdateSkillCommandHandler(ISkillRepository skillRepository, IMapper mapper)
    {
        _skillRepository = skillRepository;
        _mapper = mapper;
    }
    public async Task<Response<Guid>> Handle(UpdateSkillCommand command, CancellationToken cancellationToken)
    {
        var skill = await _skillRepository.GetByIdAsync(command.Id);

        if (skill == null)
        {
            throw new ApiException($"Skill Not Found.");
        }
        else
        {
            skill = _mapper.Map<SkillEntity>(skill);
            _skillRepository.Update(skill);
            return new Response<Guid>(skill.Id);
        }
    }
}