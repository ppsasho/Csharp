namespace Models
{
    public class Admin : Person
    {
        public List<Trainer> Trainers {  get; set; }
        public List<Student> Students { get; set; }
        public List<Admin> Admins { get; set; }
        public List<Subject> Subjects { get; set; }
        public Admin(string firstName, string username, string password, List<Trainer> trainers, List<Student> students, List<Admin> admins, List<Subject> subjects) : base(firstName, username, password)
        {
            Trainers = trainers;
            Students = students;
            Admins = admins;
            Subjects = subjects;
        }
    }
}
