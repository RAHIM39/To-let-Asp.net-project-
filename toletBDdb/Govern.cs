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
    
    public partial class Govern
    {
        public int G_id { get; set; }
        public string users_id { get; set; }
        public string request { get; set; }
    
        public virtual User User { get; set; }
    }
}