using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Categories;
public class CreateCategoryCommand : IRequest<Guid>
{
    //public Guid BlogId { get; set; }
    public string CategoryName { get; set; }
}