using Models;
namespace AcademyManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region data
            Subject subject1 = new("JS_Basic", new List<Student>());
            Subject subject2 = new("JS_Advaced", new List<Student>());
            Subject subject3 = new("C#_Basic", new List<Student>());
            Subject subject4 = new("C#_Advanced", new List<Student>());
            List<Subject> subjects = new(){ subject1, subject2, subject3, subject4 };

            Student student1 = new("Bob", "bob", "bobskyBob1234", subject3, new List<int>() { 4, 2, 5, 3, 4 });
            Student student2 = new("Alice", "alice", "alice1234", subject2, new List<int>() { 5, 3, 4, 2, 4 });
            Student student3 = new("John", "john", "johnsmith1234", subject4, new List<int>() { 3, 4, 5, 2, 4 });
            Student student4 = new("Emily", "emily", "emilybrown1234", subject1, new List<int>() { 2, 4, 3, 5, 4 });
            Student student5 = new("Michael", "michael", "michaelgreen1234", subject2, new List<int>() { 4, 2, 5, 3, 4 });
            Student student6 = new("Sophia", "sophia", "sophiawang1234", subject3, new List<int>() { 3, 4, 2, 5, 4 });
            Student student7 = new("David", "david", "davidlee1234", subject4, new List<int>() { 5, 3, 4, 2, 4 });
            Student student8 = new("Emma", "emma", "emmadavis1234", subject1, new List<int>() { 4, 5, 3, 2, 4 });
            Student student9 = new("James", "james", "jameswilson1234", subject2, new List<int>() { 3, 5, 4, 2, 4 });
            Student student10 = new("Olivia", "olivia", "oliviasanchez1234", subject3, new List<int>() { 2, 4, 5, 3, 4 });
            List<Student> students = new(){ student1, student2, student3, student4, student5, student6, student7, student8, student9, student10 };

            foreach (Student student in students) foreach (Subject subject in subjects)
                    if (student.CurrentSubject.Name == subject.Name) subject.StudentsAttending.Add(student);
                    
            Trainer trainer1 = new("John", "trainerJohn", "passJohn", students, subjects);
            Trainer trainer2 = new("Alice", "trainerAlice", "passAlice", students, subjects);
            Trainer trainer3 = new("David", "trainerDavid", "passDavid", students, subjects);
            Trainer trainer4 = new("Emily", "trainerEmily", "passEmily", students, subjects);
            List<Trainer> trainers = new() { trainer1, trainer2, trainer3, trainer4 };

            Admin admin1 = new("Robert", "adminRobert", "adminpass", trainers, students, new List<Admin>(), subjects);
            Admin admin2 = new("Natalie", "adminNatalie", "adminpass", trainers, students, new List<Admin>(), subjects);
            Admin admin3 = new("Matthew", "adminMatthew", "adminpass", trainers, students, new List<Admin>(), subjects);
            Admin admin4 = new("Sophie", "adminSophie", "adminpass", trainers, students, new List<Admin>(), subjects);
            List<Admin> admins = new() { admin1, admin2, admin3, admin4 };
            foreach (Admin admin in admins) admin.Admins = admins;
            #endregion
            while (!UI(admins)) ;
        }
        #region UI
        static bool UI(List<Admin> admins)
        {
            while (true)
            {
                switch (CMD.GetInput("Welcome to the Academy page! choose your user type:\n1)Admin\n2)Trainer\n3)Student\n")) 
                {
                    case "1":
                        return CMD.AdminSignIn(admins);

                    case "2":
                        return CMD.TrainerSignIn(admins);

                    case "3":
                        return CMD.StudentSignIn(admins);

                    default:
                        Console.Clear();
                        continue;
                }
            }
        }
        #endregion

    }
}
