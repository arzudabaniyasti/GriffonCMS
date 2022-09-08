using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Categories;
using GriffonCMS.Infrastructure.DTOS.Projects;
using MediatR;

namespace GriffonCMS.Infrastructure.Queries.Projects;
public class GetProjectQuery : IRequest<List<GetProjectDto>>
{
}
