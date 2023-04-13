using System.ComponentModel.DataAnnotations;

namespace StudentRegistration.Models
{
    public class Course
    {
        [Key]
        public string? Code { get; set; }
        public string? Name { get; set; }
        public int NQFLevel { get; set; }
        public double Cost { get; set; }
        public ICollection<Student>? Students { get; set; }


    }
}
