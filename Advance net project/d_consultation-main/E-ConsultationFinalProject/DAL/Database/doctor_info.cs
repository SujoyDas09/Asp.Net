//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class doctor_info
    {
        public doctor_info()
        {
            this.doctor_schedule = new HashSet<doctor_schedule>();
        }
    
        public int did { get; set; }
        public Nullable<int> d_govid { get; set; }
        public string d_degree { get; set; }
        public string d_speciality { get; set; }
        public Nullable<int> u_id { get; set; }
        public Nullable<int> isdeleted { get; set; }
    
        public virtual user user { get; set; }
        public virtual ICollection<doctor_schedule> doctor_schedule { get; set; }
    }
}
