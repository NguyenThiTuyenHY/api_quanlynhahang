using api_quanlynhahang.Entities;
using Data.EF;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL.Interfaces
{
    public interface IManagerbophanRespo
    {
        Task<int> Create_Bophan(bophan bp);
        Task<int> Delete_Bophan(int id);
        Task<int> Update_Bophan(int id, bophan bp);
        Task<bophan> Get_Bophan_Get_ID(int id);
        List<bophan> Get_All_Bophan();
        List<bophan> Get_All_Bophan_keywork(int pageIndex, int pageSize, string keywork);
    }
}
