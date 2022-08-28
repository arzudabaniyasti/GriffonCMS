using GriffonCMS.Infrastructure.DTOS.Tags;
using MediatR;

namespace GriffonCMS.Infrastructure.Queries.Tags
{
    public class GetTagQuery : IRequest<List<GetTagDto>>
    {
    }
}
