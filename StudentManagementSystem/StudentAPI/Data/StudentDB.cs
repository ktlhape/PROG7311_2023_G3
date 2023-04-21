using StudentAPI.Models;

namespace StudentAPI.Data

{
    public static class StudentDB
    {
        public static List<Student> Students { get; set; }
            = new List<Student>() { 
            new Student(1, "Thabo","Zulu",18,'M'),
            new Student(2, "Carol","Smith",19,'F'),
            new Student(3, "Jessica","Jones",18,'F'),
            new Student(4, "Lawrance","Zulu",21,'M'),
            new Student(5, "Kelvin","Van Eck",20,'M'),
            new Student(6, "Lerato","Zulu",17,'F'),
            };
    }
}
