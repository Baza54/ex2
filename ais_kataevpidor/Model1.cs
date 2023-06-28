using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ais_kataevpidor
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Attestation> Attestation { get; set; }
        public virtual DbSet<Criteria> Criteria { get; set; }
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<DisciplineTeachers> DisciplineTeachers { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<ProcedureForTransferringPoints> ProcedureForTransferringPoints { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<StatusStudent> StatusStudent { get; set; }
        public virtual DbSet<StatusTeacher> StatusTeacher { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentResult> StudentResult { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TypeAttestation> TypeAttestation { get; set; }
        public virtual DbSet<Vedomosti> Vedomosti { get; set; }

        private static Model1 context;

        public static Model1 GetContext()
        {
            if (context == null)
                context = new Model1();
            return context;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attestation>()
                .HasMany(e => e.Criteria)
                .WithRequired(e => e.Attestation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Attestation>()
                .HasMany(e => e.Vedomosti)
                .WithRequired(e => e.Attestation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Criteria>()
                .HasMany(e => e.StudentResult)
                .WithRequired(e => e.Criteria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Discipline>()
                .HasMany(e => e.Attestation)
                .WithRequired(e => e.Discipline)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Discipline>()
                .HasMany(e => e.DisciplineTeachers)
                .WithRequired(e => e.Discipline)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employees>()
                .HasMany(e => e.Attestation)
                .WithRequired(e => e.Employees)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employees>()
                .HasMany(e => e.DisciplineTeachers)
                .WithRequired(e => e.Employees)
                .HasForeignKey(e => e.IdTeacher)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.Attestation)
                .WithRequired(e => e.Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Group>()
                .HasMany(e => e.Student)
                .WithRequired(e => e.Group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Employees)
                .WithMany(e => e.Role)
                .Map(m => m.ToTable("UserRole").MapLeftKey("IdRole").MapRightKey("IdUser"));

            modelBuilder.Entity<Speciality>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.Speciality)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Speciality>()
                .HasMany(e => e.Group)
                .WithRequired(e => e.Speciality)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusStudent>()
                .HasMany(e => e.Student)
                .WithRequired(e => e.StatusStudent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatusTeacher>()
                .HasMany(e => e.Employees)
                .WithRequired(e => e.StatusTeacher)
                .HasForeignKey(e => e.IdStatusTeachers)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.StudentResult)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Vedomosti)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeAttestation>()
                .HasMany(e => e.Attestation)
                .WithRequired(e => e.TypeAttestation)
                .WillCascadeOnDelete(false);
        }
    }
}
