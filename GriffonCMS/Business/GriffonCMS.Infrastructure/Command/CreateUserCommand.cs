﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GriffonCMS.Infrastructure.Command;
public class CreateUserCommand : IRequest<Guid>
{
    public Guid AdminId;
}
