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
    public class BophanController : ControllerBase
    {
        private readonly IManagerbophanRespo _Respo;
        public BophanController(IManagerbophanRespo respo)
        {
            _Respo = respo;
        }
        [Route("get_all_bo_phan")]
        [HttpGet]
        public List<bophan> Get_ALL_Bo_Phan()
        {
            return _Respo.Get_All_Bophan();
        }
    }
}
