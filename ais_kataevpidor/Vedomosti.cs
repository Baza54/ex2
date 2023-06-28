namespace ais_kataevpidor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vedomosti")]
    public partial class Vedomosti
    {
        [Key]
        public int IdVedomosti { get; set; }

        public int IdAttestation { get; set; }

        public int IdStudent { get; set; }

        [Required]
        [StringLength(6)]
        public string TheNumberOfPointsForTheExam { get; set; }

        [Required]
        [StringLength(1)]
        public string FinalGrade { get; set; }

        [Column(TypeName = "date")]
        public DateTime? RecordingDate { get; set; }

        public virtual Attestation Attestation { get; set; }

        public virtual Student Student { get; set; }
    }
}
