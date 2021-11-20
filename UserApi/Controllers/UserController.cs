using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserApi.Interface;
using UserApi.Interface.Implemention;
using UserApi.Model;

namespace UserApi.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUser _iUser;
       

        public UserController(IUser iUser)
        {
            _iUser = iUser;
        }


        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllMembers()
        {
            return _iUser.GetAllUser();

        }
        [HttpGet("{id}")]
        public ActionResult<User> GetMemberById(int id)
        {
                return _iUser.GetUser(id);
        }
    }

}
