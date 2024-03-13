using inheritance.Models;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("G3", "Sasho", "Popovski", "exampleMail", "3246346");

            Console.WriteLine(student.GetInfo());

            Trainer t1 = new Trainer()
            {
                FirstName = "David",
                LastName = "Davidkovski",
                EmailAddress = "emailExample",
                PhoneNumber = "1234567890",
                YearsOfExperience = 7
            };

            Console.WriteLine(t1.GetInfo());
        }
    }
}
