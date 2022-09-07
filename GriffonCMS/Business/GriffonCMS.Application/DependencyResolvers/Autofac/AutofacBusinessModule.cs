using Autofac;
using GriffonCMS.Application.Interfaces;
using GriffonCMS.Application.Interfaces.Repositories;
using GriffonCMS.Application.Command;
using GriffonCMS.Application.Command.Admins;
using GriffonCMS.Core.Repositories;
using GriffonCMS.Domain.Repositories;
using GriffonCMS.Infrastructure.Utils.Security.Jwt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac;

public class AutofacBusinessModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<AdminRepository>().As<IAdminRepository>();
        builder.RegisterType<AdminManager>().As<IAdminService>();
        builder.RegisterType<AboutRepository>().As<IAboutRepository>();
        builder.RegisterType<BlogRepository>().As<IBlogRepository>();
        builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
        builder.RegisterType<CommentRepository>().As<ICommentRepository>();
        builder.RegisterType<ContactRepository>().As<IContactRepository>();
        builder.RegisterType<InterestRepository>().As<IInterestRepository>();
        builder.RegisterType<ProjectRepository>().As<IProjectRepository>();
        builder.RegisterType<ReferenceRepository>().As<IReferenceRepository>();
        builder.RegisterType<SkillRepository>().As<ISkillRepository>();
        builder.RegisterType<TagRepository>().As<ITagRepository>();
        builder.RegisterType<UserRepository>().As<IUserRepository>();
        builder.RegisterType<WorkExperienceRepository>().As<IWorkExperienceRepository>();
        //birisi constructorında ıproduct gibi bir şey isterse biz ona product manager vericez
        builder.RegisterType<AuthManager>().As<IAuthService>();
        builder.RegisterType<JwtHelper>().As<ITokenHelper>();



    }
}

