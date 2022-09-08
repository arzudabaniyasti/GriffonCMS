using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Domain.Entities.User;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Abouts;
using GriffonCMS.Infrastructure.Command.Users;
using GriffonCMS.Infrastructure.Exceptions;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Application.Command.Abouts;
public class UpdateAboutCommandHandler : IRequestHandler<UpdateAboutCommand, Response<Guid>>
{
    private readonly IAboutRepository _aboutRepository;
    private readonly IMapper _mapper;
    public UpdateAboutCommandHandler(IAboutRepository aboutRepository, IMapper mapper)
    {
        _aboutRepository = aboutRepository;
        _mapper = mapper;
    }
    public async Task<Response<Guid>> Handle(UpdateAboutCommand command, CancellationToken cancellationToken)
    {
        var about = await _aboutRepository.GetByIdAsync(command.Id);

        if (about == null)
        {
            throw new ApiException($"About Not Found.");
        }
        else
        {

            about = _mapper.Map<AboutEntity>(command);
            _aboutRepository.Update(about);
            return new Response<Guid>(about.Id);
        }
    }
}