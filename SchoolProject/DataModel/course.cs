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
    
    public partial class course
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public course()
        {
            this.LectureWeeks = new HashSet<LectureWeek>();
            this.LevelCourses = new HashSet<LevelCourse>();
            this.TableExams = new HashSet<TableExam>();
        }
    
        public int courseid { get; set; }
        public string coursename { get; set; }
        public Nullable<int> sortshowInReport { get; set; }
        public Nullable<int> CourseLevelType { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LectureWeek> LectureWeeks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LevelCourse> LevelCourses { get; set; }
        public virtual TypeLevel TypeLevel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TableExam> TableExams { get; set; }
    }
}
