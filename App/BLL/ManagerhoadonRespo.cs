using api_quanlynhahang.Entities;
using App.BLL.Interfaces;
using Data.EF;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BLL
{
    public class ManagerhoadonRespo : IManagerhoadonRespo
    {
        private readonly CommonContext _context;
        public ManagerhoadonRespo(CommonContext context)
        {
            _context = context;
        }
        public bool create(donhang dh)
        {
            try
            {
                _context.donhangs.Add(dh);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool create_hoa_don(donhangkemct donhang)
        {
            try
            {
                int s = 0;
                for (int i = 0; i < donhang.ctdhs.Count(); i++)
                {
                    s = donhang.ctdhs[i].soluong * donhang.ctdhs[i].gia;
                }
                donhang.dh.tinhtrang = 0;
                donhang.dh.tongtien = s;
                if (this.create(donhang.dh))
                {
                    List<donhang> ds = _context.donhangs.ToList();
                    int id = ds[ds.Count() - 1].id;
                    for (int i = 0; i < donhang.ctdhs.Count(); i++)
                    {
                        chitietdonhang ct = new chitietdonhang();
                        ct.iddh = ct.iddh;
                        ct.idmon = ct.idmon;
                        ct.soluong = ct.soluong;
                        ct.gia = ct.gia;
                    }
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
