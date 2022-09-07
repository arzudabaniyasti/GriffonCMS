using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Domain.Entities.Comments;
using GriffonCMS.Infrastructure.Command;

namespace GriffonCMS.Infrastructure.Maps.Comments;
public class CommentMap : Profile
{
    public CommentMap()
    {
        CreateMap<CommentEntity, CreateCommentCommand>().ReverseMap();
    }
}
