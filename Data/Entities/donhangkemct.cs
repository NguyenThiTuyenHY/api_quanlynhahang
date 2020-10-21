using api_quanlynhahang.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class donhangkemct
    {
        public donhang dh { get; set; }
        public List<chitietdonhang> ctdhs { get; set; }
    }
}
