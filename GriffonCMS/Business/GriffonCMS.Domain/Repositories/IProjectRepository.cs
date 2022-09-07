using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Admin;
using GriffonCMS.Domain.Entities.Project;
using GriffonCMS.Domain.Repositories.Base.Abstract;

namespace GriffonCMS.Domain.Repositories;
public interface IProjectRepository : IBaseRepository<ProjectEntity, Guid>
{
}
