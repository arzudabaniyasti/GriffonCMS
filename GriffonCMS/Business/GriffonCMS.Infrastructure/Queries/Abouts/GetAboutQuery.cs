using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Abouts;
using GriffonCMS.Infrastructure.DTOS.Categories;
using MediatR;

namespace GriffonCMS.Infrastructure.Queries.Abouts;
public class GetAboutQuery : IRequest<List<GetAboutDto>>
{
}

