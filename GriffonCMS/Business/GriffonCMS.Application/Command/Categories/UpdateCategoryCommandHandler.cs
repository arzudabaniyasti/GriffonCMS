using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Blog;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Blogs;
using GriffonCMS.Infrastructure.Command.Categories;
using GriffonCMS.Infrastructure.Exceptions;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Application.Command.Categories;
public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, Response<Guid>>
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;
    public UpdateCategoryCommandHandler(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }
    public async Task<Response<Guid>> Handle(UpdateCategoryCommand command, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetByIdAsync(command.Id);

        if (category == null)
        {
            throw new ApiException($"Category Not Found.");
        }
        else
        {
            category = _mapper.Map<CategoryEntity>(command);
            _categoryRepository.Update(category);
            return new Response<Guid>(category.Id);
        }
    }
}