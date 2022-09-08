using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.DTOS.Abouts;
using GriffonCMS.Infrastructure.Queries.Abouts;
using MediatR;
using Microsoft.Extensions.Logging;

namespace GriffonCMS.Application.Queries.Abouts;
public class GetAboutHandler : IRequestHandler<GetAboutQuery, List<GetAboutDto>>
{

    private readonly IAboutRepository _aboutRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetAboutHandler> _logger;

    public GetAboutHandler(IAboutRepository aboutRepository, IMapper mapper, ILogger<GetAboutHandler> logger)
    {
        _aboutRepository = aboutRepository ?? throw new ArgumentNullException(nameof(aboutRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<List<GetAboutDto>> Handle(GetAboutQuery request, CancellationToken cancellationToken)
    {
        var response = await _aboutRepository.GetAllAsync(cancellationToken);
        var mapped = _mapper.Map<List<GetAboutDto>>(response);
        return mapped;
    }
}