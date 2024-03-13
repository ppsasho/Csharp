namespace class06Recap
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }

        public Student(string firstName, string lastName, string academy, string group)
        {
            FirstName = firstName;
            LastName = lastName;
            Academy = academy;
            Group = group;
        }
        public Student() { }

        public string GetStudentData()
        {
            return $"{FirstName} {LastName} - [{Academy} {Group}]";
        }
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

    }
}
