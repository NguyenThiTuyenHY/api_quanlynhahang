using System;
using System.Collections.Generic;
using System.Text;
using api_quanlynhahang.Entities;
using Data.Entities;

namespace App.BLL.Interfaces
{
    public interface IManagermonanRespo
    {
        List<monan> Get_All_Mon_An();
        monan Get_mon_an(int id);

        bool Create_mon_an(monan mn);

        bool Edit_mon_an(int id, monan mn);

        bool Delete_mon_an(int id);
    }
}
