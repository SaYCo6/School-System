using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<SchoolEntity> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SchoolEntity>()
                .HasMany(s => s.Students)
                .WithOne(st => st.School)
                .HasForeignKey(st => st.SchoolId);

            modelBuilder.Entity<SchoolEntity>()
                .HasMany(s => s.Teachers)
                .WithOne(t => t.School)
                .HasForeignKey(t => t.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Subjects)
                .WithMany(sub => sub.Students)
                .UsingEntity(j => j.HasData(
                    new { StudentsStudentId = 1, SubjectsSubjectId = 1 },
                    new { StudentsStudentId = 2, SubjectsSubjectId = 2 },
                    new { StudentsStudentId = 3, SubjectsSubjectId = 3 }
                ));

            modelBuilder.Entity<Student>()
                .HasMany(s => s.Teachers)
                .WithMany(t => t.Students)
                .UsingEntity(j => j.HasData(
                    new { StudentsStudentId = 1, TeachersTeacherId = 1 },
                    new { StudentsStudentId = 2, TeachersTeacherId = 2 },
                    new { StudentsStudentId = 3, TeachersTeacherId = 3 }
                ));

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Subjects)
                .WithMany(sub => sub.Teachers)
                .UsingEntity(j => j.HasData(
                    new { TeachersTeacherId = 1, SubjectsSubjectId = 1 },
                    new { TeachersTeacherId = 2, SubjectsSubjectId = 2 },
                    new { TeachersTeacherId = 3, SubjectsSubjectId = 3 }
                ));

            Seeder.Seed(modelBuilder);
        }
    }
}