using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Infrastructure.Command.Abouts;

namespace GriffonCMS.Infrastructure.Maps.Abouts;
public class AboutMap : Profile
{
    public AboutMap()
    {
        CreateMap<AboutEntity, CreateAboutCommand>().ReverseMap();
        CreateMap<AboutEntity, DeleteAboutByIdCommand>().ReverseMap();
    }
}
