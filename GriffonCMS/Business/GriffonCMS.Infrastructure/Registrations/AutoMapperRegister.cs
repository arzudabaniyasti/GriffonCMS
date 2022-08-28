using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Infrastructure.Maps.Tags;
using Microsoft.Extensions.DependencyInjection;

namespace GriffonCMS.Infrastructure.Registrations;
public static class AutoMapperRegister
{
    public static void RegisterAutoMapper(this IServiceCollection services)
    {
        var config = new MapperConfiguration(cfg =>
        {
            cfg.AddProfile(new TagMap());
        });

        var mapper = config.CreateMapper();
        services.AddSingleton(mapper);
    }
}
