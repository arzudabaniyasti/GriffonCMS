using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Users;
using GriffonCMS.Infrastructure.Exceptions;
using MediatR;

namespace GriffonCMS.Application.Command.Users;

public class DeleteUserByIdCommandHandler : IRequestHandler<DeleteUserByIdCommand, Guid>
{

    private readonly IUserRepository _userRepository;
    public DeleteUserByIdCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    public async Task<Guid> Handle(DeleteUserByIdCommand command, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByIdAsync(command.Id);
        if (user == null) throw new ApiException($"User Not Found.");
        await _userRepository.DeleteByIdAsync(user.Id);
        return user.Id;
    }
}