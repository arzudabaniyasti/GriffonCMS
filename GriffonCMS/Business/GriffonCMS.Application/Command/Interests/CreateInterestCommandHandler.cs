using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Entities.Interest;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Interests;
using MediatR;

namespace GriffonCMS.Application.Command.Interests
{
    public class CreateInterestCommandHandler : IRequestHandler<CreateInterestCommand, Guid>
    {
        IInterestRepository _interestRepository;
        private readonly IMapper _mapper;

        public CreateInterestCommandHandler(IInterestRepository interestRepository, IMapper mapper)
        {
            _interestRepository = interestRepository;
            _mapper = mapper;
        }
        public async Task<Guid> Handle(CreateInterestCommand request, CancellationToken cancellationToken)
        {
            var interest = _mapper.Map<InterestEntity>(request);
            await _interestRepository.AddAsync(interest);
            return interest.Id;
        }
    }
}