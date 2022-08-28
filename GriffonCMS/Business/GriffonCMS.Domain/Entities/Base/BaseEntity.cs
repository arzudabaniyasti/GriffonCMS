using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Base.Abstraction;

namespace GriffonCMS.Domain.Entities.Base;
public class BaseEntity<TPK> : IBaseEnitity<TPK>
    where TPK : notnull
{
    public TPK Id { get; set; }
}
