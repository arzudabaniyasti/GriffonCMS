using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using GriffonCMS.Domain.Entities.About;
using GriffonCMS.Domain.Entities.Category;
using GriffonCMS.Domain.Entities.Comments;
using GriffonCMS.Infrastructure.Command.Abouts;
using GriffonCMS.Infrastructure.Command.Comments;
using GriffonCMS.Infrastructure.DTOS.Comments;
using GriffonCMS.Infrastructure.Queries.Comments;

namespace GriffonCMS.Infrastructure.Maps.Comments;
public class CommentMap : Profile
{
    public CommentMap()
    {
        CreateMap<CommentEntity, CreateCommentCommand>().ReverseMap();
        CreateMap<CommentEntity, DeleteCommentByIdCommand>().ReverseMap();
        CreateMap<CommentEntity, UpdateCommentCommand>().ReverseMap();

        CreateMap<CommentEntity, GetCommentQuery>().ReverseMap();
        CreateMap<CommentEntity, GetCommentDto>().ReverseMap();
    }
}
