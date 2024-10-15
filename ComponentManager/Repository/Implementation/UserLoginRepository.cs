using ComponentManager.Data;
using ComponentManager.Models;
using ComponentManager.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentManager.Repository.Implementation
{
    public class UserLoginRepository : IUserLoginRepository
    {
        private readonly ComponentContext context;

        public UserLoginRepository(ComponentContext context)
        {
            this.context = context;
        }

        public List<UserLogin> GetList()
        {
            return context.UserLogin.ToList();
        }

        public UserLogin Get(string id) 
        {
            var code = Convert.ToString(id);
            var existUser = context.UserLogin.FirstOrDefault(x => x.UserCode.Contains(code));
            if (existUser == null)
            {
                return null;
            }
            return existUser;
        }

        public bool Login(string userCode, string password)
        {
            var query = $"Select * From UserLogin Where UserCode = {userCode} and Password = {password}";
            var result = context.Database.SqlQuery<UserLogin>(query);
            return result.Count() > 0;
        }

        public UserLogin Update(string userCode, UserLogin userLogin)
        {
            var existUser = context.UserLogin.FirstOrDefault(x => x.UserCode.Contains(userCode));
            if (existUser == null) return null;
            existUser.Password = userLogin.Password;
            context.SaveChanges();
            return existUser;
        }
    }
}
