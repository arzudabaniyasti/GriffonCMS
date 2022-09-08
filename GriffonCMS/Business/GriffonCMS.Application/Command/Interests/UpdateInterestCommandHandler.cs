using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Entities.Contact;
using GriffonCMS.Domain.Entities.Interest;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Contacts;
using GriffonCMS.Infrastructure.Command.Interests;
using GriffonCMS.Infrastructure.Exceptions;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Application.Command.Interests;

public class UpdateInterestCommandHandler : IRequestHandler<UpdateInterestCommand, Response<Guid>>
{
    private readonly IInterestRepository _interestRepository;
    private readonly IMapper _mapper;
    public UpdateInterestCommandHandler(IInterestRepository interestRepository, IMapper mapper)
    {
        _interestRepository = interestRepository;
        _mapper = mapper;
    }
    public async Task<Response<Guid>> Handle(UpdateInterestCommand command, CancellationToken cancellationToken)
    {
        var interest = await _interestRepository.GetByIdAsync(command.Id);

        if (interest == null)
        {
            throw new ApiException($"Interest Not Found.");
        }
        else
        {
            interest = _mapper.Map<InterestEntity>(interest);
            _interestRepository.Update(interest);
            return new Response<Guid>(interest.Id);
        }
    }
}