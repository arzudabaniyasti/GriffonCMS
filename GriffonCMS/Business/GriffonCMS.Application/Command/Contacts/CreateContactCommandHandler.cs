using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Blog;
using GriffonCMS.Domain.Entities.Contact;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Contacts;
using MediatR;

namespace GriffonCMS.Application.Command.Contacts;
public class CreateContactCommandHandler : IRequestHandler<CreateContactCommand, Guid>
{
    IContactRepository _contactRepository;
    private readonly IMapper _mapper;

    public CreateContactCommandHandler(IContactRepository contactRepository, IMapper mapper)
    {
        _contactRepository = contactRepository;
        _mapper = mapper;
    }
    public async Task<Guid> Handle(CreateContactCommand request, CancellationToken cancellationToken)
    {
        var contact = _mapper.Map<ContactEntity>(request);
        await _contactRepository.AddAsync(contact);
        return contact.Id;
    }
}