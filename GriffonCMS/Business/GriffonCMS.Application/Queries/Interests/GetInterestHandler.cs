using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.DTOS.Interests;
using GriffonCMS.Infrastructure.Queries.Interests;
using MediatR;
using Microsoft.Extensions.Logging;

namespace GriffonCMS.Application.Queries.Interests;
public class GetInterestHandler : IRequestHandler<GetInterestQuery, List<GetInterestDto>>
{

    private readonly IInterestRepository _interestRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetInterestHandler> _logger;

    public GetInterestHandler(IInterestRepository interestRepository, IMapper mapper, ILogger<GetInterestHandler> logger)
    {
        _interestRepository = interestRepository ?? throw new ArgumentNullException(nameof(interestRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<List<GetInterestDto>> Handle(GetInterestQuery request, CancellationToken cancellationToken)
    {
        var response = await _interestRepository.GetAllAsync(cancellationToken);
        var mapped = _mapper.Map<List<GetInterestDto>>(response);
        return mapped;
    }
}