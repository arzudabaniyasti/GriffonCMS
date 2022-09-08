using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command.Categories;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Application.Command.Blogs;

public class AddCategoryToBlogCommandHandler : IRequestHandler<AddCategoryToBlogCommand, Response<Guid>>
{
    private readonly IBlogRepository _blogRepository;
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public AddCategoryToBlogCommandHandler(IBlogRepository blogRepository, ICategoryRepository categoryRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<Response<Guid>> Handle(AddCategoryToBlogCommand request, CancellationToken cancellationToken)
    {

        var blog = await _blogRepository.GetByIdAsync(request.BlogId);
        if (blog == null) return null;

        var category = await _categoryRepository.GetByIdAsync(request.CategoryId);
        if (category == null) return null;

        blog.CategoryId = category.Id;
        
        _blogRepository.Update(blog);

        return new Response<Guid>(blog.Id); ;
    }

}