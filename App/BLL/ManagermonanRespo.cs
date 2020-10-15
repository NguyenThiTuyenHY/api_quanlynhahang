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

        public List<monan> Get_Mon_An_New()
        {
            return _context.monans.OrderByDescending(x => x.id).Take(4).Skip(0).ToList();
        }

        public List<monan> Get_Mon_An_Rate()
        {
            return _context.monans.OrderBy(x => x.id).Take(4).Skip(0).ToList();
        }
        public monantotal Get_Mon_An_Loai(int id, int pageSize, int pageIndex, int order)
        {
            var ds = _context.monans.Where(x => x.idloaimon == id);
            switch (order)
            {
                case 1: //mac dinh
                    ds = ds.OrderBy(x => x.tenmon); 
                    break;
                case 2: // theo ten
                    ds = ds.OrderBy(x => x.tenmon);
                    break;
                case 3: // danh gia
                    ds = ds.OrderByDescending(x => x.id);
                    break;
                case 4: // moi nhat
                    ds = ds.OrderByDescending(x => x.id);
                    break;
                case 5: // thap cao
                    ds = ds.OrderBy(x => x.gia);
                    break;
                case 6: // cao thap
                    ds = ds.OrderByDescending(x => x.gia);
                    break;
            }
            int count = ds.Count();
            int index = (pageSize * (pageIndex - 1));
            ds = ds.Skip(index).Take(pageSize);
            monantotal result = new monantotal();
            result.monans = ds.ToList();
            result.total = count;
            return result;
        }
    }
}
