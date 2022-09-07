using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Admin;
using GriffonCMS.Domain.Entities.WorkExperience;
using GriffonCMS.Domain.Repositories.Base.Abstract;

namespace GriffonCMS.Domain.Repositories;
public interface IWorkExperienceRepository : IBaseRepository<WorkExperienceEntity, Guid>
{
}
