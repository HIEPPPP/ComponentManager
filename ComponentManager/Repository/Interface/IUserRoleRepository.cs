using ComponentManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Repository.Implementation
{
    public interface IUserRoleRepository
    {
        List<UserRole> GetListByUserCode(string userCode);
    }
}
