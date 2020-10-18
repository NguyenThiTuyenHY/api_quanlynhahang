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
        List<monan> Get_Mon_An_New();

        List<monan> Get_Mon_An_Rate();

        bool Create_mon_an(monan mn);

        bool Edit_mon_an(int id, monan mn);

        bool Delete_mon_an(int id);

        public monantotal Get_Mon_An_Loai(int id, int pageSize, int pageIndex, int order);

        public monantotal Get_Mon_An_Loai_Search(int? id, int pageSize, int pageIndex, int order, string search);
    }
}
