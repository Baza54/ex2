namespace ais_kataevpidor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attestation")]
    public partial class Attestation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Attestation()
        {
            Criteria = new HashSet<Criteria>();
            Vedomosti = new HashSet<Vedomosti>();
        }

        [Key]
        public int IdAttestation { get; set; }

        public int IdDiscipline { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        public int IdTeachers { get; set; }

        public int IdGroup { get; set; }

        public int IdTypeAttestation { get; set; }

        public bool? Сompleted { get; set; }

        public bool? Deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Criteria> Criteria { get; set; }

        public virtual Group Group { get; set; }

        public virtual Discipline Discipline { get; set; }

        public virtual Employees Employees { get; set; }

        public virtual TypeAttestation TypeAttestation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vedomosti> Vedomosti { get; set; }
    }
}
