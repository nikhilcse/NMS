//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NMS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GroupMember
    {
        public int GroupID { get; set; }
        public string USN { get; set; }
        public string username { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual Student Student { get; set; }
    }
}
