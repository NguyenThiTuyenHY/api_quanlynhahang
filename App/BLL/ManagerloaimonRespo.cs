using api_quanlynhahang.Entities;
using App.BLL.Interfaces;
using Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BLL
{
    public class ManagerloaimonRespo : IManagerloaimonanRespo
    {
        private readonly CommonContext _context;
        public ManagerloaimonRespo(CommonContext context)
        {
            _context = context;
        }
        public bool Create_Loai_mon(loaimon lm)
        {
            throw new NotImplementedException();
        }

        public bool Delete_Loai_mon(int id)
        {
            throw new NotImplementedException();
        }

        public List<loaimon> Get_All_Loai_Mon()
        {
            try
            {
                return _context.loaimons.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public loaimon Get_Loai_Mon_By_ID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Put_Loai_Mon(int id, loaimon lm)
        {
            throw new NotImplementedException();
        }
    }
}
