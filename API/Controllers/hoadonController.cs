using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.BLL;
using App.BLL.Interfaces;
using Data.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class hoadonController : ControllerBase
    {
        private IManagerhoadonRespo _Respo;
        public hoadonController(IManagerhoadonRespo respo)
        {
            _Respo = respo;
        }
        [Route("create_hoa_don")]
        [HttpPost]
        public bool create_hoa_don([FromBody] donhangkemct donhang)
        {
            return _Respo.create_hoa_don(donhang);
        }
    }
}
