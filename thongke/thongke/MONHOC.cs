//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace thongke
{
    using System;
    using System.Collections.Generic;
    
    public partial class MONHOC
    {
        public MONHOC()
        {
            this.KETQUAs = new HashSet<KETQUA>();
        }
    
        public string MAMH { get; set; }
        public string TENMH { get; set; }
    
        public virtual ICollection<KETQUA> KETQUAs { get; set; }
    }
}