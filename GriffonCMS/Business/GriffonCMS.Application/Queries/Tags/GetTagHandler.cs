using AutoMapper;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.DTOS.Tags;
using GriffonCMS.Infrastructure.Queries.Tags;
using MediatR;
using Microsoft.Extensions.Logging;

namespace GriffonCMS.Application.Queries.Tags
{
    public class GetTagHandler : IRequestHandler<GetTagQuery, List<GetTagDto>>
    {
        private readonly ITagRepository _tagRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetTagHandler> _logger;

        public GetTagHandler(ITagRepository tagRepository, IMapper mapper, ILogger<GetTagHandler> logger)
        {
            _tagRepository = tagRepository ?? throw new ArgumentNullException(nameof(tagRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<List<GetTagDto>> Handle(GetTagQuery request, CancellationToken cancellationToken)
        {
            var response = await _tagRepository.GetAllAsync(cancellationToken);
            var mapped = _mapper.Map<List<GetTagDto>>(response);
            return mapped;
        }
    }
}
