using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Application.Interfaces.Repositories;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Domain.Repositories;

namespace GriffonCMS.Application.Manager.Categories;
public class CreateCategory : ICategoryService
{
    ICategoryRepository _categoryRepository;
    public CreateCategory(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public void AddAsync(Category entity)
    {
        _categoryRepository.AddAsync(entity);
    }

    public void UpdateAsync(Category entity)
    {
        _categoryRepository.Update(entity);
    }
}
