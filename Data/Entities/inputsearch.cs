using System;
using System.Collections.Generic;
using System.Text;

namespace api_quanlynhahang.Entities
{
    public class inputsearch
    {
        public int id { get; set; }
        public int pageSize { get; set; }
        public int pageIndex { get; set; }
        public int order { get; set; }
    }
}
