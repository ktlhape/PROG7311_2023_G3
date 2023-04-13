namespace StudentWebApp.Models
{
    public class Student
    {
        public string? StNumber { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public double TestMark { get; set; }

        public Student(string? stNumber, string? firstName, string? lastName, double testMark)
        {
            StNumber = stNumber;
            FirstName = firstName;
            LastName = lastName;
            TestMark = testMark;
        }
    }
}
