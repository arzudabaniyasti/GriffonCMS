using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.DTOS.Contacts;
using GriffonCMS.Infrastructure.Queries.Contacts;
using MediatR;
using Microsoft.Extensions.Logging;

namespace GriffonCMS.Application.Queries.Contacts;
public class GetContactHandler : IRequestHandler<GetContactQuery, List<GetContactDto>>
{

    private readonly IContactRepository _contactRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetContactHandler> _logger;

    public GetContactHandler(IContactRepository contactRepository, IMapper mapper, ILogger<GetContactHandler> logger)
    {
        _contactRepository = contactRepository ?? throw new ArgumentNullException(nameof(contactRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<List<GetContactDto>> Handle(GetContactQuery request, CancellationToken cancellationToken)
    {
        var response = await _contactRepository.GetAllAsync(cancellationToken);
        var mapped = _mapper.Map<List<GetContactDto>>(response);
        return mapped;
    }
}