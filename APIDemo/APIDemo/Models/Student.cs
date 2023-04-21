namespace APIDemo.Models
{
    public class Student
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Student(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
    }
}
