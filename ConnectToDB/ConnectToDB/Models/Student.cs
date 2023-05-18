namespace ConnectToDB.Models
{
    public class Student : IUser
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get ; set ; }
        public string Password { get ; set ; }

        public Student()
        {
            this.StudentID = "";
            this.Name = "No name";
            this.Surname = "No surname";
        }

        public Student(string studentID, string name, string surname, string email, string password)
        {
            StudentID = studentID;
            Name = name;
            Surname = surname;
            Email = email;
            Password = password;
        }
        public Student WithID(string studentID)
        {
            StudentID = studentID;
            return this;
        }
        public Student WithName(string firstname, string lastname)
        {
            this.Name = firstname;
            this.Surname = lastname;
            return this;
        }
        public Student WithEmail(string email)
        {
            this.Email = email;
            return this;
        }
        public Student WithCredentials(string email, string pass)
        {
            this.Email = email;
            this.Password = pass;
            return this;
        }
        public Student Build() => this;
    }
}
