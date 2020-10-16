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
    public class LoaimonController : ControllerBase
    {
        private readonly IManagerloaimonanRespo _IMloaimonan;
        public LoaimonController(IManagerloaimonanRespo _IM)
        {
            _IMloaimonan = _IM;
        }
        [Route("Get_ALL_Loai_Mon")]
        [HttpGet]
        public List<loaimon> Get_ALL_Loai_Mon()
        {
            return _IMloaimonan.Get_All_Loai_Mon();
        }
        [HttpGet("{id}")]
        public loaimon Get_loai_mon_by_id(int id)
        {
            return _IMloaimonan.Get_Loai_Mon_By_ID(id);
        }
    }
}
