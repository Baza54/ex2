namespace ais_kataevpidor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            StudentResult = new HashSet<StudentResult>();
            Vedomosti = new HashSet<Vedomosti>();
        }

        [Key]
        public int IdStudent { get; set; }

        [Required]
        [StringLength(20)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20)]
        public string LastName { get; set; }

        [StringLength(20)]
        public string Patronymic { get; set; }

        [StringLength(80)]
        public string Email { get; set; }

        [StringLength(22)]
        public string Telephone { get; set; }

        public int IdGroup { get; set; }

        public int IdSpeciality { get; set; }

        public int IdStatusStudent { get; set; }

        public virtual Group Group { get; set; }

        public virtual StatusStudent StatusStudent { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentResult> StudentResult { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vedomosti> Vedomosti { get; set; }
    }
}
