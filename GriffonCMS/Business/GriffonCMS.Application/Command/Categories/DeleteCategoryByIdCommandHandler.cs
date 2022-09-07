using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.Exceptions;
using MediatR;

namespace GriffonCMS.Application.Command.Categories;
public class DeleteCategoryByIdCommandHandler : IRequestHandler<DeleteCategoryByIdCommand, Guid>
{

    private readonly ICategoryRepository _categoryRepository;
    public DeleteCategoryByIdCommandHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    public async Task<Guid> Handle(DeleteCategoryByIdCommand command, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetByIdAsync(command.Id);
        if (category == null) throw new ApiException($"Category Not Found.");
        await _categoryRepository.DeleteByIdAsync(category.Id);
        return category.Id;
    }
}