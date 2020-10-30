using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Configuration;
using api_quanlynhahang.Entities;
using App.BLL.Interfaces;
using Data.Entities;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UseradminController : ControllerBase
    {
        private IManageruserRespo _Respo;
        private string _path;
        public UseradminController(IManageruserRespo respo, IConfiguration configuration)
        {
            _Respo = respo;
            _path = configuration["AppSettings:PATH"];
        }
        [Route("authenticate")]
        [HttpGet]
        public user Authenticate(string email, string pass)
        {
            user result = _Respo.getUser(email,pass);
            if (result == null)
                return null;
            else
            {
                if(result.id == 3)
                {
                    return null;
                }
                return result;
            }
        }
    }
}
