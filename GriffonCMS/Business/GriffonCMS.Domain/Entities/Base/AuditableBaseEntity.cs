using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Base.Abstraction;
using GriffonCMS.Domain.Entities.Category;

namespace GriffonCMS.Domain.Entities.Base;
public class AuditableBaseEntity<TPK> : IBaseEnitity<TPK>
    where TPK : notnull
{ 
    public virtual TPK Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime? LastModified { get; set; }
}