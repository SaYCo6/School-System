namespace School.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int GradeLevel { get; set; }
        public string Description { get; set; } = string.Empty;

        public List<Student> Students { get; set; } = new List<Student>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}