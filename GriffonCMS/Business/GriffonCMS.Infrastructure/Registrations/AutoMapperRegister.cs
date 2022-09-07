using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Infrastructure.Maps.Categories;
using GriffonCMS.Infrastructure.Maps.Tags;
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
        });

        var mapper = config.CreateMapper();
        services.AddSingleton(mapper);
        var assm = Assembly.GetExecutingAssembly();
        services.AddAutoMapper(assm);
        services.AddMediatR(assm);
    }
}
