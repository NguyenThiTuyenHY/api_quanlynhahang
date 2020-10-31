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
    public class binhluanController : ControllerBase
    {
        private readonly IManagerbinhluanRespo _Respo;
        public binhluanController(IManagerbinhluanRespo respo)
        {
            _Respo = respo;
        }
        [Route("create_binh_luan")]
        [HttpPost]
        public bool create_binh_luan(binhluan bl)
        {
            return _Respo.create_binh_luan(bl);
        }
    }
}
