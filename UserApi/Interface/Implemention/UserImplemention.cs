using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserApi.Model;

namespace UserApi.Interface.Implemention
{
    public class UserImplemention : IUser
    {
        List<User> Users = new List<User>
        {
            new User{userId=1, firstName="David", lastName="Smith", address="Kansas City" },
            new User{userId=2, firstName="Adam", lastName="Smith", address="Kansas City" },
            new User{userId=3, firstName="Tyler", lastName="Smith", address="Kansas City" },
        };
        public List<User> GetAllUser()
        {
            return Users;
        }

        public User GetUser(int id)
        {
            return Users.FirstOrDefault(dst => dst.userId == id);
        }

        
    }
}
