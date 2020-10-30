using App.BLL.Interfaces;
using Data.EF;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App.BLL
{
    public class ManagertintucRespo : IManagertintucRespo
    {
        public readonly CommonContext _context;
        public ManagertintucRespo(CommonContext context)
        {
            _context = context;
        }
        public List<tintuc> get_tin_tuc_noi_bat()
        {
            return _context.tintucs.OrderByDescending(x=>x.id).Skip(0).Take(4).ToList();
        }
    }
}
