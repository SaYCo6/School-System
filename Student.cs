namespace School.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public int SchoolId { get; set; }
        public SchoolEntity? School { get; set; }

        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}