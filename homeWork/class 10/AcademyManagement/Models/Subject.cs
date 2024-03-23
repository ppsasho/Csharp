namespace Models
{
    public class Subject
    {
        public string Name { get; set; }
        public List<Student> StudentsAttending { get; set; }
        public Subject(string name, List<Student> studentsAttending) 
        {
            Name = name;
            StudentsAttending = studentsAttending;
        }

    }
}
