using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_quanlynhahang.Entities;
using App.BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private IManageruserRespo _Respo;
        public userController(IManageruserRespo respo)
        {
            _Respo = respo;
        }
        [Route("get_user")]
        [HttpGet]
        public user get_user(string txtemail, string txtpass)
        {
            return _Respo.getUser(txtemail, txtpass);
        }
    }
}
