using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using api_quanlynhahang.Entities;
using App.Common;

namespace App.BLL.Interfaces
{
    public interface IManagerbananRespo
    {
        Task<List<banan>> Get_All_banan();
        Task<banan> Get_banan_By_ID(int id);
        Task<int> Create_banan(banan ba);
        Task<HttpResponseMessage> Delete_banan(int id);
        Task<HttpResponseMessage> Edit_banan(int id, banan ba);

        Task<PageViewModel<banan>> Get_All_banan_keywork(string keyword, int pageIndex, int pageSize);
    }
}
