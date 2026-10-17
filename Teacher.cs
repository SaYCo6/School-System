namespace School.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public double Salary { get; set; }

        public int SchoolId { get; set; }
        public SchoolEntity? School { get; set; }

        public List<Student> Students { get; set; } = new List<Student>();
        public List<Subject> Subjects { get; set; } = new List<Subject>();
    }
}