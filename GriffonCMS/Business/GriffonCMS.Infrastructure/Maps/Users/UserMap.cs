using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Domain.Entities.Tag;
using GriffonCMS.Infrastructure.Command;
using GriffonCMS.Infrastructure.DTOS.Tags;

namespace GriffonCMS.Infrastructure.Maps.Users;
public class UserMap : Profile
{
    public UserMap()
    {
       // CreateMap<CategoryEntity, CreateCategoryCommand>().ReverseMap();
    }
}
