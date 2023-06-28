namespace ais_kataevpidor
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DisciplineTeachers
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDiscipline { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTeacher { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdDisciplineTeachers { get; set; }

        public virtual Discipline Discipline { get; set; }

        public virtual Employees Employees { get; set; }
    }
}
