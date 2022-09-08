using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.DTOS.References;
using GriffonCMS.Infrastructure.Queries.References;
using MediatR;
using Microsoft.Extensions.Logging;

namespace GriffonCMS.Application.Queries.References;
public class GetReferenceHandler: IRequestHandler<GetReferenceQuery, List<GetReferenceDto>>
{

    private readonly IReferenceRepository _referenceRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetReferenceHandler> _logger;

    public GetReferenceHandler(IReferenceRepository referenceRepository, IMapper mapper, ILogger<GetReferenceHandler> logger)
    {
        _referenceRepository = referenceRepository ?? throw new ArgumentNullException(nameof(referenceRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<List<GetReferenceDto>> Handle(GetReferenceQuery request, CancellationToken cancellationToken)
    {
        var response = await _referenceRepository.GetAllAsync(cancellationToken);
        var mapped = _mapper.Map<List<GetReferenceDto>>(response);
        return mapped;
    }
}