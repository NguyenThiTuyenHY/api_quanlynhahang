using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entities
{
    public class tintuc
    {
        public int id { get; set; }
        public string tieude { get; set; }
        public string hinhanh { get; set; }
        public string tomtat { get; set; }
        public string noidung { get; set; }
        public int luotxem { get; set; }

        public DateTime ngaydang { get; set; }
    }
}
