using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using api_quanlynhahang.Entities;
using App.BLL;
using App.BLL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class monanController : ControllerBase
    {
        private readonly IManagermonanRespo _Respo;
        private string _path;
        public monanController(IManagermonanRespo respo, IConfiguration configuration)
        {
            _Respo = respo;
            _path = configuration["AppSettings:PATH"];
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
        public string SaveFileFromBase64String(string RelativePathFileName, string dataFromBase64String)
        {
            if (dataFromBase64String.Contains("base64,"))
            {
                dataFromBase64String = dataFromBase64String.Substring(dataFromBase64String.IndexOf("base64,", 0) + 7);
            }
            return WriteFileToAuthAccessFolder(RelativePathFileName, dataFromBase64String);
        }
        public string WriteFileToAuthAccessFolder(string RelativePathFileName, string base64StringData)
        {
            try
            {
                string result = "";
                string serverRootPathFolder = _path;
                string fullPathFile = $@"{serverRootPathFolder}\{RelativePathFileName}";
                string fullPathFolder = System.IO.Path.GetDirectoryName(fullPathFile);
                if (!Directory.Exists(fullPathFolder))
                    Directory.CreateDirectory(fullPathFolder);
                System.IO.File.WriteAllBytes(fullPathFile, Convert.FromBase64String(base64StringData));
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        [Route("create_mon_an")]
        [HttpPost]
        public bool Create_mon_an([FromBody] monan mn)
        {
            mn.ngaynhap = DateTime.Now;
            var a = mn;
            if (mn.hinhanh != null)
            {
                var arrData = mn.hinhanh.Split(';');
                if (arrData.Length == 3)
                {
                    var savePath = $@"assets/images/product/{arrData[0]}";
                    mn.hinhanh = arrData[0];
                    SaveFileFromBase64String(savePath, arrData[2]);
                }
            }
            return _Respo.Create_mon_an(mn);
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
        [Route("get_mon_an_by_search")]
        [HttpGet]
        public monantotal get_mon_an_by_search(int? id, int pageSize, int pageIndex, int order,string search)
        {
            return _Respo.Get_Mon_An_Loai_Search(id, pageSize, pageIndex, order, search);
        }
        [Route("get_mon_an_lien_he")]
        [HttpGet]
        public List<monan> get_mon_an_lien_he(int id, int idloai)
        {
            return _Respo.Get_Mon_An_Lien_Quan(id, idloai);
        }
    }
}
