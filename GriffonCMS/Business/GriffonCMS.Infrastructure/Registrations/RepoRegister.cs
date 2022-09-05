using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Core.Repositories.Base;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Domain.Repositories.Base.Abstract;
using Microsoft.Extensions.DependencyInjection;

namespace GriffonCMS.Infrastructure.Registrations;
public static class RepoRegister
{
    public static void RegisterRepositories(this IServiceCollection services)
    {
        services.AddTransient(typeof(IBaseRepository<,>), typeof(BaseRepository<,>));
        services.AddTransient(typeof(ITagRepository), typeof(TagRepository));
        services.AddTransient(typeof(IAdminRepository), typeof(AdminRepository));
        services.AddTransient(typeof(ICategoryRepository), typeof(CategoryRepository));
    }
}
