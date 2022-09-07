using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Contacts;
using GriffonCMS.Infrastructure.Exceptions;
using MediatR;

namespace GriffonCMS.Application.Command.Contacts;

public class DeleteContactByIdCommandHandler : IRequestHandler<DeleteContactByIdCommand, Guid>
{

    private readonly IContactRepository _contactRepository;
    public DeleteContactByIdCommandHandler(IContactRepository contactRepository)
    {
        _contactRepository = contactRepository;
    }
    public async Task<Guid> Handle(DeleteContactByIdCommand command, CancellationToken cancellationToken)
    {
        var contact = await _contactRepository.GetByIdAsync(command.Id);
        if (contact == null) throw new ApiException($"Contact Not Found.");
        await _contactRepository.DeleteByIdAsync(contact.Id);
        return contact.Id;
    }
}