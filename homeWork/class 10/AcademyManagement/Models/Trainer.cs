namespace Models
{
    public class Trainer : Person
    {
        public List<Student> Students { get; set; }
        public List<Subject> Subjects { get; set; }
        public Trainer(string firstName, string username, string password, List<Student> students, List<Subject> subjects) : base(firstName, username, password)
        {
            Students = students;
            Subjects = subjects;
        }
    }
}
