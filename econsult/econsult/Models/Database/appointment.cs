//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace econsult.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class appointment
    {
        public int ap_id { get; set; }
        public Nullable<System.DateTime> ap_date { get; set; }
        public Nullable<double> ap_fee { get; set; }
        public Nullable<int> u_id { get; set; }
    
        public virtual user user { get; set; }
    }
}