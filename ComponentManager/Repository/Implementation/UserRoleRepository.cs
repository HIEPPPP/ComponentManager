using ComponentManager.Data;
using ComponentManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Repository.Implementation
{
    public class UserRoleRepository : IUserRoleRepository
    {
        private readonly ComponentContext context;

        public UserRoleRepository(ComponentContext context)
        {
            this.context = context;
        }
        public List<UserRole> GetListByUserCode(string userCode)
        {
            var existUserRole = context.UserRoles.Where(x => x.UserCode.Contains(userCode));
            if (existUserRole == null) 
            {
                return null;
            }
            return existUserRole.ToList();
        }
    }
}
