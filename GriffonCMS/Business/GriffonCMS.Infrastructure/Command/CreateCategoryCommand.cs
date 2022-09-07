﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GriffonCMS.Infrastructure.Command;
public class CreateCategoryCommand:IRequest<Guid>
{
    //public Guid BlogId { get; set; }
    public String CategoryName { get; set; }
} 