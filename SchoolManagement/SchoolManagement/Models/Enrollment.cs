//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enrollment
    {
        public int enrollmentID { get; set; }
        public Nullable<decimal> grade { get; set; }
        public int courseID { get; set; }
        public int studentID { get; set; }
        public Nullable<int> teacherID { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
