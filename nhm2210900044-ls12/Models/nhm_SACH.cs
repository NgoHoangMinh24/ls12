//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class nhm_SACH
    {
        public int nhm_MaSach { get; set; }
        public string nhm_TenSach { get; set; }
        public Nullable<int> nhm_SoTrang { get; set; }
        public Nullable<int> nhm_NamXB { get; set; }
        public Nullable<int> nhm_MaTG { get; set; }
        public Nullable<bool> nhm_TrangThai { get; set; }
    
        public virtual nhm_TACGIA nhm_TACGIA { get; set; }
    }
}
