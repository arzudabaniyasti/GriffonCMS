using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Categories;
public  class AddCategoryToBlogCommand : IRequest<Response<Guid>>
{
    public Guid BlogId { get; set; }
    public Guid CategoryId { get; set; }
}