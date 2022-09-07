using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Interests;
using GriffonCMS.Infrastructure.Exceptions;
using MediatR;

namespace GriffonCMS.Application.Command.Interests;
public class DeleteInterestByIdCommandHandler : IRequestHandler<DeleteInterestByIdCommand, Guid>
{

    private readonly IInterestRepository _interestRepository;
    public DeleteInterestByIdCommandHandler(IInterestRepository interestRepository)
    {
        _interestRepository = interestRepository;
    }
    public async Task<Guid> Handle(DeleteInterestByIdCommand command, CancellationToken cancellationToken)
    {
        var interest = await _interestRepository.GetByIdAsync(command.Id);
        if (interest == null) throw new ApiException($"Interest Not Found.");
        await _interestRepository.DeleteByIdAsync(interest.Id);
        return interest.Id;
    }
}