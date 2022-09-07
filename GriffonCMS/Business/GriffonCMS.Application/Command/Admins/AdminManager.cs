using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GriffonCMS.Application.Interfaces.Repositories;
using GriffonCMS.Domain.Entities.Admin;
using GriffonCMS.Domain.Repositories;

namespace GriffonCMS.Application.Command.Admins;
public class AdminManager : IAdminService
{
    IAdminRepository _adminRepository;
    public AdminManager(IAdminRepository adminRepository)
    {
        _adminRepository = adminRepository;
    }

    public void AddAsync(Admin entity)
    {
       _adminRepository.AddAsync(entity);
    }

    public Admin GetByMail(string email)
    {
        return _adminRepository.Get(u => u.EMail == email);
    }

    public void UpdateAsync(Admin entity)
    {
        _adminRepository.Update(entity);
    }
}
