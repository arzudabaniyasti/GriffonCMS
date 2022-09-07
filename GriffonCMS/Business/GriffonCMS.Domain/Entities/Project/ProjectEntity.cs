using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Base;
using GriffonCMS.Domain.Entities.Category;

namespace GriffonCMS.Domain.Entities.Project;
public class ProjectEntity:BaseEntity<Guid>
{
    public Guid UserId { get; set; }
    public DateTime Date { get; set; }
    //Technologies
    public ICollection<CategoryEntity> Categories { get; set; }
    public string Description { get; set; }
    public Guid ImageId { get; set; }

}
