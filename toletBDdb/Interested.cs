//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace toletBDdb
{
    using System;
    using System.Collections.Generic;
    
    public partial class Interested
    {
        public string users_id { get; set; }
        public string msg { get; set; }
        public int I_id { get; set; }
        public string msg1 { get; set; }
        public string ad_id { get; set; }
    
        public virtual Ad Ad { get; set; }
        public virtual User User { get; set; }
    }
}