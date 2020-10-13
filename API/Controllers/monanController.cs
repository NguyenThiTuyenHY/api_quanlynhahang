using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_quanlynhahang.Entities;
using App.BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class monanController : ControllerBase
    {
        private readonly ManagermonanRespo _Respo;
        public monanController(ManagermonanRespo respo)
        {
            _Respo = respo;
        }
        [Route("get_all_mon_an")]
        [HttpGet]
        public List<monan> Get_All_Mon_An()
        {
            return _Respo.Get_All_Mon_An();
        }
        [Route("create_mon_an")]
        [HttpPost]
        public bool Create_mon_an([FromBody] monan mn)
        {
            var a = mn;
            return true;
            //return _Respo.Create_mon_an(mn);
        }
    }
}
