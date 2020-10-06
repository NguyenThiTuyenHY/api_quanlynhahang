using System;
using System.Collections.Generic;
using System.Text;

namespace App.Common
{
    public class PageViewModel<T>
    {
        List<T> items { get; set; }
        public int TotalRecord { get; set; }

    }
}
