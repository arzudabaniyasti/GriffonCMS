using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Abouts;
using GriffonCMS.Infrastructure.Exceptions;
using MediatR;

namespace GriffonCMS.Application.Command.Abouts;

public class DeleteAboutByIdCommandHandler : IRequestHandler<DeleteAboutByIdCommand, Guid>
{

    private readonly IAboutRepository _aboutRepository;
    public DeleteAboutByIdCommandHandler(IAboutRepository aboutRepository)
    {
        _aboutRepository = aboutRepository;
    }
    public async Task<Guid> Handle(DeleteAboutByIdCommand command, CancellationToken cancellationToken)
    {
        var about = await _aboutRepository.GetByIdAsync(command.Id);
        if (about == null) throw new ApiException($":About Not Found.");
        await _aboutRepository.DeleteByIdAsync(about.Id);
        return about.Id;
    }
}