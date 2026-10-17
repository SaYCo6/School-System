using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Data
{
    public class Seeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SchoolEntity>().HasData(
                new SchoolEntity { SchoolId = 1, Name = "Cairo School", Capacity = 500, Location = "Cairo" },
                new SchoolEntity { SchoolId = 2, Name = "Alex School", Capacity = 400, Location = "Alexandria" },
                new SchoolEntity { SchoolId = 3, Name = "Giza School", Capacity = 300, Location = "Giza" }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student { StudentId = 1, FirstName = "Ahmed", LastName = "Ali", Email = "ahmed@mail.com", SchoolId = 1 },
                new Student { StudentId = 2, FirstName = "Sara", LastName = "Hassan", Email = "sara@mail.com", SchoolId = 2 },
                new Student { StudentId = 3, FirstName = "Omar", LastName = "Khaled", Email = "omar@mail.com", SchoolId = 3 }
            );

            modelBuilder.Entity<Teacher>().HasData(
                new Teacher { TeacherId = 1, FirstName = "Mona", LastName = "Said", Salary = 8000, SchoolId = 1 },
                new Teacher { TeacherId = 2, FirstName = "Hany", LastName = "Fawzy", Salary = 9000, SchoolId = 2 },
                new Teacher { TeacherId = 3, FirstName = "Laila", LastName = "Nabil", Salary = 10000, SchoolId = 3 }
            );

            modelBuilder.Entity<Subject>().HasData(
                new Subject { SubjectId = 1, Name = "Math", GradeLevel = 1, Description = "Basic Math" },
                new Subject { SubjectId = 2, Name = "Science", GradeLevel = 2, Description = "General Science" },
                new Subject { SubjectId = 3, Name = "English", GradeLevel = 3, Description = "English Language" }
            );
        }
    }
}