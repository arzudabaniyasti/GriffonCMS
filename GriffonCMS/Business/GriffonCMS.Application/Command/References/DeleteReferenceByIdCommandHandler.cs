using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.References;
using GriffonCMS.Infrastructure.Exceptions;
using MediatR;

namespace GriffonCMS.Application.Command.References;

public class DeleteReferenceByIdCommandHandler : IRequestHandler<DeleteReferenceByIdCommand, Guid>
{

    private readonly IReferenceRepository _referenceRepository;
    public DeleteReferenceByIdCommandHandler(IReferenceRepository referenceRepository)
    {
        _referenceRepository = referenceRepository;
    }
    public async Task<Guid> Handle(DeleteReferenceByIdCommand command, CancellationToken cancellationToken)
    {
        var reference = await _referenceRepository.GetByIdAsync(command.Id);
        if (reference == null) throw new ApiException($"Reference Not Found.");
        await _referenceRepository.DeleteByIdAsync(reference.Id);
        return reference.Id;
    }
}