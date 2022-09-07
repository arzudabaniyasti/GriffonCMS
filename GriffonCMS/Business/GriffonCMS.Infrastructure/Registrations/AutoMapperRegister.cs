using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Infrastructure.Maps.Abouts;
using GriffonCMS.Infrastructure.Maps.Blogs;
using GriffonCMS.Infrastructure.Maps.Categories;
using GriffonCMS.Infrastructure.Maps.Comments;
using GriffonCMS.Infrastructure.Maps.Contacts;
using GriffonCMS.Infrastructure.Maps.Interests;
using GriffonCMS.Infrastructure.Maps.Projects;
using GriffonCMS.Infrastructure.Maps.References;
using GriffonCMS.Infrastructure.Maps.Skills;
using GriffonCMS.Infrastructure.Maps.Tags;
using GriffonCMS.Infrastructure.Maps.Users;
using GriffonCMS.Infrastructure.Maps.WorkExperience;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace GriffonCMS.Infrastructure.Registrations;
public static class AutoMapperRegister
{
    public static void RegisterAutoMapper(this IServiceCollection services)
    {
        var config = new MapperConfiguration(cfg =>
        {
            //startupda da eklicez buraya da eklicez.
            cfg.AddProfile(new TagMap());
            cfg.AddProfile(new CategoryMap());
            cfg.AddProfile(new UserMap());
            cfg.AddProfile(new ContactMap());
            cfg.AddProfile(new BlogMap());
            cfg.AddProfile(new CommentMap());
            cfg.AddProfile(new InterestMap());
            cfg.AddProfile(new ProjectMap());
            cfg.AddProfile(new ReferenceMap());
            cfg.AddProfile(new SkillMap());
            cfg.AddProfile(new WorkExperienceMap());
            cfg.AddProfile(new AboutMap());
        });

        var mapper = config.CreateMapper();
        services.AddSingleton(mapper);
        var assm = Assembly.GetExecutingAssembly();
        services.AddAutoMapper(assm);
        services.AddMediatR(assm);
    }
}
