using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Categories;
using GriffonCMS.Infrastructure.DTOS.Contacts;
using MediatR;

namespace GriffonCMS.Infrastructure.Queries.Contacts;
public class GetContactQuery : IRequest<List<GetContactDto>>
{
}
