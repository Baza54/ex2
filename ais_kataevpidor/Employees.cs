namespace ais_kataevpidor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employees
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employees()
        {
            Attestation = new HashSet<Attestation>();
            DisciplineTeachers = new HashSet<DisciplineTeachers>();
            Role = new HashSet<Role>();
        }

        [Key]
        public int IdTeachers { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string Patronymic { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        public int IdStatusTeachers { get; set; }

        public int IdSpeciality { get; set; }

        [StringLength(50)]
        public string Login { get; set; }

        

        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attestation> Attestation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DisciplineTeachers> DisciplineTeachers { get; set; }

        public virtual Speciality Speciality { get; set; }

        public virtual StatusTeacher StatusTeacher { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Role> Role { get; set; }
    }
}
