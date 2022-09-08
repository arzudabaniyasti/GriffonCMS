using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.DTOS.WorkExperiences;
using GriffonCMS.Infrastructure.Queries.WorkExperiences;
using MediatR;
using Microsoft.Extensions.Logging;

namespace GriffonCMS.Application.Queries.WorkExperiences;
public class GetWorkExperienceHandler : IRequestHandler<GetWorkExperienceQuery, List<GetWorkExperienceDto>>
{

    private readonly IWorkExperienceRepository _workExperienceRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetWorkExperienceHandler> _logger;

    public GetWorkExperienceHandler(IWorkExperienceRepository workExperienceRepository, IMapper mapper, ILogger<GetWorkExperienceHandler> logger)
    {
        _workExperienceRepository = workExperienceRepository ?? throw new ArgumentNullException(nameof(workExperienceRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<List<GetWorkExperienceDto>> Handle(GetWorkExperienceQuery request, CancellationToken cancellationToken)
    {
        var response = await _workExperienceRepository.GetAllAsync(cancellationToken);
        var mapped = _mapper.Map<List<GetWorkExperienceDto>>(response);
        return mapped;
    }
}
