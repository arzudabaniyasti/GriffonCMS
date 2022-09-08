using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Comments;
using MediatR;

namespace GriffonCMS.Infrastructure.Queries.Comments;
public class GetCommentQuery : IRequest<List<GetCommentDto>>
{
}
