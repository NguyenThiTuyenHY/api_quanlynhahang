using api_quanlynhahang.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.BLL.Interfaces
{
    public interface IManagerloaimonanRespo
    {
        List<loaimon> Get_All_Loai_Mon();
        loaimon Get_Loai_Mon_By_ID(int id);
        bool Create_Loai_mon(loaimon lm);
        bool Delete_Loai_mon(int id);
        bool Put_Loai_Mon(int id, loaimon lm);
    }
}
