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
        services.AddTransient(typeof(IUserRepository), typeof(UserRepository));
        services.AddTransient(typeof(IAboutRepository), typeof(AboutRepository));
        services.AddTransient(typeof(IBlogRepository), typeof(BlogRepository));
        services.AddTransient(typeof(ICommentRepository), typeof(CommentRepository));
        services.AddTransient(typeof(IContactRepository), typeof(ContactRepository));
        services.AddTransient(typeof(IInterestRepository), typeof(InterestRepository));
        services.AddTransient(typeof(IProjectRepository), typeof(ProjectRepository));
        services.AddTransient(typeof(IReferenceRepository), typeof(ReferenceRepository));
        services.AddTransient(typeof(ISkillRepository), typeof(SkillRepository));
        services.AddTransient(typeof(IWorkExperienceRepository), typeof(WorkExperienceRepository));
     
    }
}
