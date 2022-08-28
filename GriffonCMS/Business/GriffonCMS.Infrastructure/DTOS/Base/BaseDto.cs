using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonCMS.Infrastructure.DTOS.Base;
public class BaseDto<TPK>
{
    public TPK Id { get; set; }
}
