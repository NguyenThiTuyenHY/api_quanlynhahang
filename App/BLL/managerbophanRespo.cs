using api_quanlynhahang.Entities;
using App.BLL.Interfaces;
using Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL
{
    public class managerbophanRespo:IManagerbophanRespo
    {
        private readonly CommonContext _context;
        public managerbophanRespo(CommonContext context)
        {
            _context = context;
        }

        public async Task<int> Create_Bophan(bophan bp)
        {
            _context.bophans.Add(bp);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete_Bophan(int id)
        {
            bophan dp = _context.bophans.SingleOrDefault(x => x.id == id);
            if (dp != null)
                _context.bophans.Remove(dp);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<bophan>> Get_All_Bophan()
        {
            List<bophan> ds = _context.bophans.ToList();
            return ds;
        }

        public Task<List<bophan>> Get_All_Bophan_keywork(int pageIndex, int pageSize, string keywork)
        {
            throw new NotImplementedException();
        }

        public async Task<bophan> Get_Bophan_Get_ID(int id)
        {
            bophan bp = _context.bophans.SingleOrDefault(x => x.id == id);
            return bp;
        }

        public async Task<int> Update_Bophan(int id, bophan bp)
        {
            bophan a = _context.bophans.SingleOrDefault(x => x.id == id);
            if (a != null)
            {
                a.tenbp = bp.tenbp;
            }
            return await _context.SaveChangesAsync();
        }
    }
}
