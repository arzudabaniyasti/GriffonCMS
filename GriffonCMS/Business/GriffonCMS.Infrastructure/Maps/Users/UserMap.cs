using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Domain.Entities.Tag;
using GriffonCMS.Domain.Entities.User;
using GriffonCMS.Infrastructure.Command.Users;
using GriffonCMS.Infrastructure.DTOS.Users;
using GriffonCMS.Infrastructure.Queries.Users;

namespace GriffonCMS.Infrastructure.Maps.Users;
public class UserMap : Profile
{
    public UserMap()
    {
        //CreateMap<CategoryEntity, CreateCategoryCommand>().ReverseMap();
        CreateMap<UserEntity, DeleteUserByIdCommand>().ReverseMap();
        CreateMap<UserEntity, UpdateUserCommand>().ReverseMap();
        CreateMap<UserEntity, GetUserQuery>().ReverseMap();
        CreateMap<UserEntity, GetUserDto>().ReverseMap();
    }
}
