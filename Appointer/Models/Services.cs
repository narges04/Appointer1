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
    
    public partial class Services
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public byte Duration { get; set; }
        public string Description { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual Jobs Jobs { get; set; }
        public virtual Users Users { get; set; }
    }
}
