//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace api_quanlynhahang.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class donhang
    {
        public int id { get; set; }
        public int? idkhach { get; set; }
        public int tinhtrang { get; set; }
        public string sdtgiao { get; set; }
        public string diachigiao { get; set; }
        public int tongtien { get; set; }
        public List<chitietdonhang> chitietdonhangs { get; set; }
    
    }
}
