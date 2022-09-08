using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.References;
using MediatR;

namespace GriffonCMS.Infrastructure.Queries.References;
public class GetReferenceQuery : IRequest<List<GetReferenceDto>>
{
}
