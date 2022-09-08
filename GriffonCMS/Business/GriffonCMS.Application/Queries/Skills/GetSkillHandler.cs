using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.DTOS.Skills;
using GriffonCMS.Infrastructure.Queries.Skills;
using MediatR;
using Microsoft.Extensions.Logging;

namespace GriffonCMS.Application.Queries.Skills;
public class GetSkillHandler : IRequestHandler<GetSkillQuery, List<GetSkillDto>>
{

    private readonly ISkillRepository _skillRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetSkillHandler> _logger;

    public GetSkillHandler(ISkillRepository skillRepository, IMapper mapper, ILogger<GetSkillHandler> logger)
    {
        _skillRepository = skillRepository ?? throw new ArgumentNullException(nameof(skillRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<List<GetSkillDto>> Handle(GetSkillQuery request, CancellationToken cancellationToken)
    {
        var response = await _skillRepository.GetAllAsync(cancellationToken);
        var mapped = _mapper.Map<List<GetSkillDto>>(response);
        return mapped;
    }
}