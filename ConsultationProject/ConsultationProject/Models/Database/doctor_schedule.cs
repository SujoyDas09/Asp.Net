//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsultationProject.Models.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class doctor_schedule
    {
        public int schedule_id { get; set; }
        public string day { get; set; }
        public Nullable<System.TimeSpan> starting_time { get; set; }
        public Nullable<System.TimeSpan> ending_time { get; set; }
        public Nullable<int> d_id { get; set; }
    
        public virtual doctor_info doctor_info { get; set; }
    }
}
