using ComponentManager.Models;
using ComponentManager.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Services
{
    public class UserRoleServices
    {
        private readonly IUserRoleRepository userRoleRepository;

        public UserRoleServices(IUserRoleRepository userRoleRepository)
        {
            this.userRoleRepository = userRoleRepository;
        }

        public List<UserRole> GetListUserRoleByUserCode(string userCode)
        {
            return userRoleRepository.GetListByUserCode(userCode);
        } 
    }
}
