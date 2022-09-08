using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Categories;
using GriffonCMS.Infrastructure.DTOS.Interests;
using MediatR;

namespace GriffonCMS.Infrastructure.Queries.Interests;
public class GetInterestQuery : IRequest<List<GetInterestDto>>
{
}
