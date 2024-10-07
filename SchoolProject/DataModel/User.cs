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
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.students = new HashSet<student>();
            this.students1 = new HashSet<student>();
            this.students2 = new HashSet<student>();
        }
    
        public int ID { get; set; }
        public string UserName { get; set; }
        public string LoginName { get; set; }
        public string Pwd { get; set; }
        public Nullable<int> IsActive { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
        public Nullable<int> RoleID { get; set; }
        public Nullable<int> SchoolID { get; set; }
        public Nullable<int> branchID { get; set; }
        public Nullable<bool> TempStop { get; set; }
        public Nullable<long> BoxAccountID { get; set; }
        public string Note { get; set; }
        public Nullable<int> UserID { get; set; }
        public Nullable<System.DateTime> AddingDate { get; set; }
        public Nullable<int> EditUserID { get; set; }
        public Nullable<System.DateTime> EditDate { get; set; }
        public Nullable<bool> IsDeleted { get; set; }
        public Nullable<int> DeletingUserID { get; set; }
        public Nullable<System.DateTime> DeletingDate { get; set; }
    
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student> students { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student> students1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student> students2 { get; set; }
        public virtual schoolData schoolData { get; set; }
    }
}
