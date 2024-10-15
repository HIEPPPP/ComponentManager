using ComponentManager.Models;
using ComponentManager.Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Services
{
    public class UserLoginServices
    {
        private readonly UserLoginRepository loginRepository;

        public UserLoginServices(UserLoginRepository loginRepository)
        {
            this.loginRepository = loginRepository;
        }

        public List<UserLogin> GetListUserLogin()
        {
            return loginRepository.GetList();
        }

        public UserLogin GetUserLogin(string id)
        {
            return loginRepository.Get(id);
        }

        public bool Login(string userCode, string password)
        {
            return loginRepository.Login(userCode, password);
        }

        public UserLogin UpdatePassword(string userCode, UserLogin userLogin)
        {
            return loginRepository.Update(userCode, userLogin);
        } 
    }
}
    