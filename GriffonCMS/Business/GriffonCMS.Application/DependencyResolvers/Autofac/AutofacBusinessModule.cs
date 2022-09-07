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
        builder.RegisterType<CategoryRepository>().As<ICategoryRepository>();
        //birisi constructorında ıproduct gibi bir şey isterse biz ona product manager vericez
        builder.RegisterType<AuthManager>().As<IAuthService>();
        builder.RegisterType<JwtHelper>().As<ITokenHelper>();
       


    }
}

