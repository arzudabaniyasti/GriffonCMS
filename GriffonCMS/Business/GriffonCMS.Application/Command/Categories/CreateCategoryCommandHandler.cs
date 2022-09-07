using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Application.Interfaces.Repositories;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Command.Categories;
using MediatR;

namespace GriffonCMS.Application.Command.Categories;
public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, Guid>
{
    ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CreateCategoryCommandHandler(ICategoryRepository categoryRepository,IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }
    public async Task<Guid> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
    {
            var category = _mapper.Map<CategoryEntity>(request);
            await _categoryRepository.AddAsync(category);
            return category.Id;
        }
    }