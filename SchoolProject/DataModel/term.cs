//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SchoolProject.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class term
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public term()
        {
            this.studentdegrees = new HashSet<studentdegree>();
            this.TermPlans = new HashSet<TermPlan>();
            this.LectureWeeks = new HashSet<LectureWeek>();
            this.LevelCourses = new HashSet<LevelCourse>();
            this.RoomStudentInExams = new HashSet<RoomStudentInExam>();
            this.TableExams = new HashSet<TableExam>();
        }
    
        public int termid { get; set; }
        public string termname { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<studentdegree> studentdegrees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TermPlan> TermPlans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LectureWeek> LectureWeeks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LevelCourse> LevelCourses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoomStudentInExam> RoomStudentInExams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TableExam> TableExams { get; set; }
    }
}
