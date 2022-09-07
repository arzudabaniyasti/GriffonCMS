using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Domain.Entities.Blog;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Infrastructure.Command.Abouts;
using GriffonCMS.Infrastructure.Command.Blogs;

namespace GriffonCMS.Infrastructure.Maps.Blogs;
public class BlogMap : Profile
{
    public BlogMap()
    {
        CreateMap<BlogEntity, CreateBlogCommand>().ReverseMap();
        CreateMap<BlogEntity, DeleteBlogByIdCommand>().ReverseMap();
    }
}
