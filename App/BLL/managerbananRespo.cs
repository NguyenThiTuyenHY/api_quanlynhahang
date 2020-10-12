using api_quanlynhahang.Entities;
using App.BLL.Interfaces;
using App.Common;
using Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL
{
    public class ManagerbananRespo : IManagerbananRespo
    {
        private readonly CommonContext _context;
        public ManagerbananRespo(CommonContext context)
        {
            _context = context;
        }

        public async Task<int> Create_banan(banan ba)
        {
            _context.banans.Add(ba);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete_banan(int id)
        {
            banan ba = _context.banans.SingleOrDefault(x => x.id == id);
            if (ba != null)
                _context.banans.Remove(ba);
            return await _context.SaveChangesAsync();
        }

        public List<banan> Get_All_banan()
        {
            List<banan> ds = _context.banans.ToList();
            return ds;
        }

        public Task<PageResult<banan>> Get_All_banan_keywork(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public banan Get_banan_By_ID(int id)
        {
            banan ba = _context.banans.SingleOrDefault(x => x.id == id);
            return ba;
        }

        public async Task<int> Edit_banan_state(int id)
        {
            banan ba = _context.banans.SingleOrDefault(x => x.id == id);
            if(ba != null)
            {
                if (ba.tinhtrang == 1)
                {
                    ba.tinhtrang = 0;
                }
                else
                {
                    ba.tinhtrang = 1;
                }
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Edit_banan_makh(int id, int makh)
        {
            banan ba = _context.banans.SingleOrDefault(x => x.id == id);
            if (ba != null)
            {
                ba.makh = makh;
            }
            return await _context.SaveChangesAsync();
        }

    }
}
