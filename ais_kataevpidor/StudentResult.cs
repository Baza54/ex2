namespace ais_kataevpidor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentResult")]
    public partial class StudentResult
    {
        [Key]
        public int IdStudentResult { get; set; }

        public int IdStudent { get; set; }

        public int IdCriteria { get; set; }

        [Required]
        [StringLength(6)]
        public string NumberOfPointsForCriteria { get; set; }

        public virtual Criteria Criteria { get; set; }

        public virtual Student Student { get; set; }
    }
}
