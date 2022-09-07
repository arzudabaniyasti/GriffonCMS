using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace GriffonCMS.Infrastructure.Command.Users;
public class DeleteUserByIdCommand : IRequest<Guid>
{
    public Guid Id { get; set; }
}