using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.BLL.Interfaces;
using Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tintucController : ControllerBase
    {
        private readonly IManagertintucRespo _Respo;
        public tintucController(IManagertintucRespo respo)
        {
            _Respo = respo;
        }
        [Route("get_tin_tuc_noi_bat")]
        [HttpGet]
        public List<tintuc> get_tin_tuc_noi_bat()
        {
            return _Respo.get_tin_tuc_noi_bat();
        }
    }
}
