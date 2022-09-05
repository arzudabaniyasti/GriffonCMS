using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.DTOS.Categories;
using GriffonCMS.Infrastructure.Queries.Categories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace GriffonCMS.Application.Queries.Categories;
public class GetCategoryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoryDto>>
{

    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    private readonly ILogger<GetCategoryHandler> _logger;
   
    public GetCategoryHandler(ICategoryRepository categoryRepository, IMapper mapper, ILogger<GetCategoryHandler> logger)
    {
        _categoryRepository = categoryRepository ?? throw new ArgumentNullException(nameof(categoryRepository));
        _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<List<GetCategoryDto>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
    {
        var response = await _categoryRepository.GetAllAsync(cancellationToken);
        var mapped = _mapper.Map<List<GetCategoryDto>>(response);
        return mapped;
    }
}
