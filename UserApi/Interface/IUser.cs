using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserApi.Model;

namespace UserApi.Interface
{
   public interface IUser
    {
        List<User> GetAllUser();
        User GetUser(int id);
    }
}
