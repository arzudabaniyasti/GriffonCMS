using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Domain.Entities.Admin;

namespace GriffonCMS.Application.Interfaces.Repositories;
public interface IAdminService
{
    AdminEntity GetByMail(string email);
    void AddAsync(AdminEntity entity);
    void UpdateAsync(AdminEntity entity);
}
