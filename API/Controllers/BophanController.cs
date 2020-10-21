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
        [Route("get_bo_phan_by_id/{id}")]
        [HttpGet]
        public bophan Get_bo_phan_by_id(int id)
        {
            return _Respo.Get_Bophan_Get_ID(id);
        }
        [Route("create_bo_phan")]
        [HttpGet]
        public bool create_bo_phan(string tenbp)
        {
            bophan bp = new bophan();
            bp.tenbp = tenbp;
            return _Respo.Create_Bophan(bp);
        }
        [Route("update_bo_phan")]
        [HttpGet]
        public bool update_bo_phan(int id,string tenbp)
        {
            bophan bp = new bophan();
            bp.tenbp = tenbp;
            return _Respo.Update_Bophan(id, bp);
        }
        [Route("delete_bo_phan")]
        [HttpGet]
        public bool delete_bo_phan(int id)
        {
            return _Respo.Delete_Bophan(id);
        }
    }
}
