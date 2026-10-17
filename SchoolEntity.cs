using System.ComponentModel.DataAnnotations;

namespace School.Models
{
    public class SchoolEntity
    {
        [Key]
        public int SchoolId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public string Location { get; set; } = string.Empty;

        public List<Student> Students { get; set; } = new List<Student>();
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}