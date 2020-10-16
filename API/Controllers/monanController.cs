using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_quanlynhahang.Entities;
using App.BLL;
using App.BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class monanController : ControllerBase
    {
        private readonly IManagermonanRespo _Respo;
        public monanController(IManagermonanRespo respo)
        {
            _Respo = respo;
        }
        //[Route("get_detail_mon_an")]
        [HttpGet("{id}")]
        public monan get_detail_mon_an(int id)
        {
            return _Respo.Get_mon_an(id);
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
        [Route("get_mon_an_new")]
        [HttpGet]
        public List<monan> get_mon_an_new()
        {
            return _Respo.Get_Mon_An_New();
        }
        [Route("get_mon_an_rate")]
        [HttpGet]
        public List<monan> get_mon_an_rate()
        {
            return _Respo.Get_Mon_An_Rate();
        }
        [Route("get_mon_an_by_idlm")]
        [HttpGet]
        public monantotal get_mon_an_by_idlm(int id,int pageSize,int pageIndex,int order)
        {
            return _Respo.Get_Mon_An_Loai(id, pageSize, pageIndex, order);
        }      
    }
}
