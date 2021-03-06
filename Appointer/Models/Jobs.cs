//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Appointer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Jobs
    {
        public Jobs()
        {
            this.Appointments = new HashSet<Appointments>();
            this.JobOwners = new HashSet<JobOwners>();
            this.Services = new HashSet<Services>();
            this.Users1 = new HashSet<Users>();
            this.WorkingTimes = new HashSet<WorkingTimes>();
        }
    
        public int Id { get; set; }
        public string Title { get; set; }
        public string JobPhone { get; set; }
        public string About { get; set; }
        public string Address { get; set; }
        public int JobTypeId { get; set; }
        public int FirstJobOwner { get; set; }
    
        public virtual ICollection<Appointments> Appointments { get; set; }
        public virtual ICollection<JobOwners> JobOwners { get; set; }
        public virtual ICollection<Services> Services { get; set; }
        public virtual JobTypes JobTypes { get; set; }
        public virtual Users Users { get; set; }
        public virtual ICollection<Users> Users1 { get; set; }
        public virtual ICollection<WorkingTimes> WorkingTimes { get; set; }
    }
}
