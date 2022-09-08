using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.DTOS.Users;
using GriffonCMS.Infrastructure.Queries.Users;
using MediatR;
using Microsoft.Extensions.Logging;

namespace GriffonCMS.Application.Queries.Users;
public class GetUserHandler : IRequestHandler<GetUserQuery, List<GetUserDto>>
{

    private readonly IUserRepository _userRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetUserHandler> _logger;

    public GetUserHandler(IUserRepository userRepository, IMapper mapper, ILogger<GetUserHandler> logger)
    {
        _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<List<GetUserDto>> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        var response = await _userRepository.GetAllAsync(cancellationToken);
        var mapped = _mapper.Map<List<GetUserDto>>(response);
        return mapped;
    }
}
