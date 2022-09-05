using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Base;

namespace GriffonCMS.Infrastructure.DTOS.Categories;
public class GetCategoryDto : BaseDto<Guid>
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }    
}
