using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Base;

namespace GriffonCMS.Domain.Entities.Category;
public class CategoryEntity : BaseEntity<Guid>
{
    public Guid UserId { get; set; }
    public string CategoryName { get; set; }    
}
