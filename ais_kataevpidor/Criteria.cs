namespace ais_kataevpidor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Criteria
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Criteria()
        {
            StudentResult = new HashSet<StudentResult>();
        }

        [Key]
        public int IdCriteria { get; set; }

        public int IdAttestation { get; set; }

        [Required]
        [StringLength(300)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [StringLength(6)]
        public string NumberOfPionts { get; set; }

        [StringLength(6)]
        public string WithdrawPercent { get; set; }

        [StringLength(6)]
        public string RemoveAPoint { get; set; }

        public bool? Deleted { get; set; }

        public virtual Attestation Attestation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentResult> StudentResult { get; set; }
    }
}
