using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.Utils.Results;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Categories;
public class UpdateCategoryCommand : IRequest<Response<Guid>>
{
    public Guid Id { get; set; }
    public string CategoryName { get; set; }
}
