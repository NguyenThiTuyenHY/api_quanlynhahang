using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using App.BLL;
using App.BLL.Interfaces;
using api_quanlynhahang.Entities;
using System.Net.Http;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class bananController : ControllerBase
    {
        private readonly IManagerbananRespo _banan;
        public bananController(IManagerbananRespo banan)
        {
            _banan = banan;
        }
        [Route("get_all_banan")]
        [HttpGet]
        public ActionResult GET_ALL_Banan()
        {
            return Ok(_banan.Get_All_banan());
        }
        [Route("get_banan_by_id/{id}")]
        [HttpGet]
        public ActionResult GET_Banan_by_ID(int id)
        {
            return Ok(_banan.Get_banan_By_ID(id));
        }
        [Route("create")]
        [HttpPost]
        public bool Create_Banan([FromBody] banan ba)
        {
            try
            {
                _banan.Create_banan(ba);
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
        [Route("Delete_Banan")]
        [HttpDelete]
        public bool Delete_Banan(int id)
        {
            try
            {
                _banan.Delete_banan(id);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //[Route("Put_banan_state")]
        [HttpPost("Put_banan_state/{id}")]
        public bool Put_Banan_State(int id,[FromBody]banan bn)
        {
            try
            {
                _banan.Edit_banan_state(id);
                return true;
            }
            catch
            {
                return false;
            }
        }
        [Route("Put_Banan_Makh")]
        [HttpGet]
        public bool Put_Banan_Makh(int id, int makh)
        {
            try
            {
                _banan.Edit_banan_makh(id, makh);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
