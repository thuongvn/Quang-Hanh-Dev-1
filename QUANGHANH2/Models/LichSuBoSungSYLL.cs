//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QUANGHANH2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class LichSuBoSungSYLL
    {
        public string NamBoSung { get; set; }
        public string DotBoSung { get; set; }
        public string MaNV { get; set; }
    
        public virtual HoSo HoSo { get; set; }
    }
}