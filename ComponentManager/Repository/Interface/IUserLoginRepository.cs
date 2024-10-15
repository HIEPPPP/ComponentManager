using ComponentManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Repository.Interface
{
    public interface IUserLoginRepository
    {
        List<UserLogin> GetList();
        UserLogin Get(string id);

        bool Login(string userCode, string password);

        UserLogin Update(string userCode, UserLogin userLogin);
    }
}
