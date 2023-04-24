namespace StudentService.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }

        public Student(){}
        public Student(int studentID, string firstname, string lastname, int age, char gender)
        {
            StudentID = studentID;
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Gender = gender;
        }
    }
}
