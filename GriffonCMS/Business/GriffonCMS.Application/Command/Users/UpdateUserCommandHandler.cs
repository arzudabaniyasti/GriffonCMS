using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Users;
using GriffonCMS.Infrastructure.Exceptions;
using GriffonCMS.Infrastructure.Utils.Results;
using GriffonCMS.Domain.Entities.User;
using MediatR;

namespace GriffonCMS.Application.Command.Users;
public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Response<Guid>>
{
    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    public UpdateUserCommandHandler(IUserRepository userRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _mapper = mapper;
    }
    public async Task<Response<Guid>> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(command.Id);

        if (user == null)
        {
            throw new ApiException($"User Not Found.");
        }
        else
        {
            //address.Name = command.Name;
            //address.Street = command.Street;
            //address.City = command.City;
            //address.Town = command.Town;

            user = _mapper.Map<UserEntity>(command);
            _userRepository.Update(user);
            return new Response<Guid>(user.Id);
        }
    }
}

