using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Categories;
using GriffonCMS.Infrastructure.DTOS.Tags;
using MediatR;

namespace GriffonCMS.Infrastructure.Queries.Categories;
public class GetCategoryQuery : IRequest<List<GetCategoryDto>>
{
}
