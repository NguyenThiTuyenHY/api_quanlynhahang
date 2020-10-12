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
        List<banan> Get_All_banan();
        banan Get_banan_By_ID(int id);
        Task<int> Create_banan(banan ba);
        Task<int> Delete_banan(int id);
        Task<int> Edit_banan_state(int id);
        Task<int> Edit_banan_makh(int id, int makh);
        Task<PageResult<banan>> Get_All_banan_keywork(string keyword, int pageIndex, int pageSize);
    }
}
