namespace Models
{
    public class Student : Person
    {
        public Subject CurrentSubject { get; set; }
        public List<int> Grades { get; set; }
        public Student(string firstName, string username, string password, Subject currentSubject, List<int> grades) : base(firstName, username, password)
        {
            CurrentSubject = currentSubject;
            Grades = grades;
        }
    }
}
