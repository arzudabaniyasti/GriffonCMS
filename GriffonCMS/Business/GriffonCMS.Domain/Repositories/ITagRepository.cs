﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Tag;
using GriffonCMS.Domain.Repositories.Base;

namespace GriffonCMS.Domain.Repositories;
public interface ITagRepository : IBaseRepository<Tag, Guid>
{
}
