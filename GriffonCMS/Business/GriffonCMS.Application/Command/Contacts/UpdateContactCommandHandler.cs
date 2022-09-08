using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Comments;
using GriffonCMS.Domain.Entities.Contact;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Comments;
using GriffonCMS.Infrastructure.Command.Contacts;
using GriffonCMS.Infrastructure.Exceptions;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Application.Command.Contacts;
public class UpdateContactCommandHandler : IRequestHandler<UpdateContactCommand, Response<Guid>>
{
    private readonly IContactRepository _contactRepository;
    private readonly IMapper _mapper;
    public UpdateContactCommandHandler(IContactRepository contactRepository, IMapper mapper)
    {
        _contactRepository = contactRepository;
        _mapper = mapper;
    }
    public async Task<Response<Guid>> Handle(UpdateContactCommand command, CancellationToken cancellationToken)
    {
        var contact = await _contactRepository.GetByIdAsync(command.Id);

        if (contact == null)
        {
            throw new ApiException($"Contact Not Found.");
        }
        else
        {
            contact = _mapper.Map<ContactEntity>(contact);
            _contactRepository.Update(contact);
            return new Response<Guid>(contact.Id);
        }
    }
}