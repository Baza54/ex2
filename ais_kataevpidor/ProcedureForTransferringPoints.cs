namespace ais_kataevpidor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProcedureForTransferringPoints
    {
        [Key]
        [StringLength(1)]
        public string FinalGrade { get; set; }

        [Required]
        [StringLength(3)]
        public string MinPercents { get; set; }

        [Required]
        [StringLength(3)]
        public string MaxPersents { get; set; }
    }
}
