using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Categories;
using GriffonCMS.Infrastructure.DTOS.Users;
using MediatR;

namespace GriffonCMS.Infrastructure.Queries.Users;
public class GetUserQuery : IRequest<List<GetUserDto>>
{
}
