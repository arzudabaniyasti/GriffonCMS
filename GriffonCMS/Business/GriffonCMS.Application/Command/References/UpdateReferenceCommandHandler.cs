using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Entities.Project;
using GriffonCMS.Domain.Entities.Reference;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Projects;
using GriffonCMS.Infrastructure.Command.References;
using GriffonCMS.Infrastructure.Exceptions;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GriffonCMS.Application.Command.References;
public class UpdateReferenceCommandHandler : IRequestHandler<UpdateReferenceCommand, Response<Guid>>
{
    private readonly IReferenceRepository _referenceRepository;
    private readonly IMapper _mapper;
    public UpdateReferenceCommandHandler(IReferenceRepository referenceRepository, IMapper mapper)
    {
        _referenceRepository = referenceRepository;
        _mapper = mapper;
    }
    public async Task<Response<Guid>> Handle(UpdateReferenceCommand command, CancellationToken cancellationToken)
    {
        var reference = await _referenceRepository.GetByIdAsync(command.Id);

        if (reference == null)
        {
            throw new ApiException($"Reference Not Found.");
        }
        else
        {
            reference = _mapper.Map<ReferenceEntity>(reference);
            _referenceRepository.Update(reference);
            return new Response<Guid>(reference.Id);
        }
    }
}