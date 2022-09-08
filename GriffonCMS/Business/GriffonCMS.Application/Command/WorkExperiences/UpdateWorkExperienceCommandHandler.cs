using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Entities.Skill;
using GriffonCMS.Domain.Entities.WorkExperience;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Skills;
using GriffonCMS.Infrastructure.Command.WorkExperiences;
using GriffonCMS.Infrastructure.Exceptions;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Application.Command.WorkExperiences;
public class UpdateWorkExperienceCommandHandler : IRequestHandler<UpdateWorkExperienceCommand, Response<Guid>>
{
    private readonly IWorkExperienceRepository _workExperienceRepository;
    private readonly IMapper _mapper;
    public UpdateWorkExperienceCommandHandler(IWorkExperienceRepository workExperienceRepository, IMapper mapper)
    {
        _workExperienceRepository = workExperienceRepository;
        _mapper = mapper;
    }
    public async Task<Response<Guid>> Handle(UpdateWorkExperienceCommand command, CancellationToken cancellationToken)
    {
        var workExperience = await _workExperienceRepository.GetByIdAsync(command.Id);

        if (workExperience == null)
        {
            throw new ApiException($"Work Experience Not Found.");
        }
        else
        {
            workExperience = _mapper.Map<WorkExperienceEntity>(workExperience);
            _workExperienceRepository.Update(workExperience);
            return new Response<Guid>(workExperience.Id);
        }
    }
}