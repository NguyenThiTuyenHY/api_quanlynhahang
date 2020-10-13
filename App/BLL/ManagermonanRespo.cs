using api_quanlynhahang.Entities;
using App.BLL.Interfaces;
using Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BLL
{
    public class ManagermonanRespo : IManagermonanRespo
    {
        private readonly CommonContext _context;
        public ManagermonanRespo(CommonContext context)
        {
            _context = context;
        }

        public bool Create_mon_an(monan mn)
        {
            try
            {
                _context.Add(mn);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Delete_mon_an(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit_mon_an(int id, monan mn)
        {
            throw new NotImplementedException();
        }

        public List<monan> Get_All_Mon_An()
        {
            return _context.monans.ToList();
        }

        public monan Get_mon_an(int id)
        {
            throw new NotImplementedException();
        }
    }
}
