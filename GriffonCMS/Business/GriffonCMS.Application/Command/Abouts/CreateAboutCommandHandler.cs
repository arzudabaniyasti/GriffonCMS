using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Abouts;
using MediatR;

namespace GriffonCMS.Application.Command.Abouts;
public class CreateAboutCommandHandler : IRequestHandler<CreateAboutCommand, Guid>
{
    IAboutRepository _aboutRepository;
    private readonly IMapper _mapper;

    public CreateAboutCommandHandler(IAboutRepository aboutRepository, IMapper mapper)
    {
        _aboutRepository = aboutRepository;
        _mapper = mapper;
    }
    public async Task<Guid> Handle(CreateAboutCommand request, CancellationToken cancellationToken)
    {
        var about = _mapper.Map<AboutEntity>(request);
        await _aboutRepository.AddAsync(about);
        return about.Id;
    }
}