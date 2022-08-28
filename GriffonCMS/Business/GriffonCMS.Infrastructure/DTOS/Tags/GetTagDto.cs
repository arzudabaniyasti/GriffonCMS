﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Infrastructure.DTOS.Base;

namespace GriffonCMS.Infrastructure.DTOS.Tags;
public class GetTagDto : BaseDto<Guid>
{
    public string TagValue { get; set; }
}
