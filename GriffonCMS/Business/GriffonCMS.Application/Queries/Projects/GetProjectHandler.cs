using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.DTOS.Projects;
using GriffonCMS.Infrastructure.Queries.Projects;
using MediatR;
using Microsoft.Extensions.Logging;

namespace GriffonCMS.Application.Queries.Projects;
public class GetProjectHandler : IRequestHandler<GetProjectQuery, List<GetProjectDto>>
{

    private readonly IProjectRepository _projectRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetProjectHandler> _logger;

    public GetProjectHandler(IProjectRepository projectRepository, IMapper mapper, ILogger<GetProjectHandler> logger)
    {
        _projectRepository = projectRepository ?? throw new ArgumentNullException(nameof(projectRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<List<GetProjectDto>> Handle(GetProjectQuery request, CancellationToken cancellationToken)
    {
        var response = await _projectRepository.GetAllAsync(cancellationToken);
        var mapped = _mapper.Map<List<GetProjectDto>>(response);
        return mapped;
    }
}
