using api_quanlynhahang.Entities;
using App.BLL.Interfaces;
using App.Common;
using Data.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace App.BLL
{
    public class managerbananRespo : IManagerbananRespo
    {
        private readonly CommonContext _context;
        public managerbananRespo(CommonContext context)
        {
            _context = context;
        }

        public async Task<int> Create_banan(banan ba)
        {
            _context.banans.Add(ba);
            return await _context.SaveChangesAsync();
        }

        public Task<HttpResponseMessage> Delete_banan(int id)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> Edit_banan(int id, banan ba)
        {
            throw new NotImplementedException();
        }

        public Task<List<banan>> Get_All_banan()
        {
            throw new NotImplementedException();
        }

        public Task<PageViewModel<banan>> Get_All_banan_keywork(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<banan> Get_banan_By_ID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
