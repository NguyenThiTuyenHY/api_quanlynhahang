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

        public bool Create_Bophan(bophan bp)
        {
            try
            {
                _context.bophans.Add(bp);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete_Bophan(int id)
        {
            try
            {
                bophan dp = _context.bophans.SingleOrDefault(x => x.id == id);
                if (dp != null)
                    _context.bophans.Remove(dp);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<bophan> Get_All_Bophan()
        {
            List<bophan> ds = _context.bophans.ToList();
            return ds;
        }

        public List<bophan> Get_All_Bophan_keywork(int pageIndex, int pageSize, string keywork)
        {
            int index = pageSize * (pageIndex - 1);
            List<bophan> ds = _context.bophans.Where(x => x.tenbp.IndexOf(keywork)>=0).Skip(index).Take(pageSize).ToList();
            return ds;
        }

        public bophan Get_Bophan_Get_ID(int id)
        {
            bophan bp = _context.bophans.SingleOrDefault(x => x.id == id);
            return bp;
        }

        public bool Update_Bophan(int id, bophan bp)
        {
            try
            {
                bophan a = _context.bophans.SingleOrDefault(x => x.id == id);
                if (a != null)
                {
                    a.tenbp = bp.tenbp;
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
