using api_quanlynhahang.Entities;
using App.BLL.Interfaces;
using Data.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.BLL
{
    public class Managerbinhluan : IManagerbinhluanRespo
    {
        private readonly CommonContext _Context;
        public Managerbinhluan(CommonContext context)
        {
            _Context = context;
        }
        public bool create_binh_luan(binhluan bl)
        {
            try
            {
                _Context.binhluans.Add(bl);
                _Context.SaveChanges();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }
    }
}
