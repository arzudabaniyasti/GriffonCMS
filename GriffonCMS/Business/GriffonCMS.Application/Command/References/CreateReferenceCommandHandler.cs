using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Reference;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.References;
using MediatR;

namespace GriffonCMS.Application.Command.References;
public class CreateReferenceCommandHandler : IRequestHandler<CreateReferenceCommand, Guid>
{
    IReferenceRepository _referenceRepository;
    private readonly IMapper _mapper;

    public CreateReferenceCommandHandler(IReferenceRepository referenceRepository, IMapper mapper)
    {
        _referenceRepository = referenceRepository;
        _mapper = mapper;
    }
    public async Task<Guid> Handle(CreateReferenceCommand request, CancellationToken cancellationToken)
    {
        var reference = _mapper.Map<ReferenceEntity>(request);
        await _referenceRepository.AddAsync(reference);
        return reference.Id;
    }
}
