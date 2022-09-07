using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Entities.User;
using GriffonCMS.Domain.Entities.WorkExperience;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.WorkExperiences;
using MediatR;

namespace GriffonCMS.Application.Command.WorkExperiences;

public class CreateWorkExperienceCommandHandler : IRequestHandler<CreateWorkExperienceCommand, Guid>
{
    IWorkExperienceRepository _workExperienceRepository;
    private readonly IMapper _mapper;

    public CreateWorkExperienceCommandHandler(IWorkExperienceRepository workExperienceRepository, IMapper mapper)
    {
        _workExperienceRepository = workExperienceRepository;
        _mapper = mapper;
    }
    public async Task<Guid> Handle(CreateWorkExperienceCommand request, CancellationToken cancellationToken)
    {
        var workExperience = _mapper.Map<WorkExperienceEntity>(request);
        await _workExperienceRepository.AddAsync(workExperience);
        return workExperience.Id;
    }
}
