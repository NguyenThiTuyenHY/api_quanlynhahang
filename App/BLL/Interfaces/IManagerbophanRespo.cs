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
        bool Create_Bophan(bophan bp);
        bool Delete_Bophan(int id);
        bool Update_Bophan(int id, bophan bp);
        bophan Get_Bophan_Get_ID(int id);
        List<bophan> Get_All_Bophan();
        List<bophan> Get_All_Bophan_keywork(int pageIndex, int pageSize, string keywork);
    }
}
