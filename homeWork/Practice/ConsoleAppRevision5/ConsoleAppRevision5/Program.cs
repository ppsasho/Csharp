using Classes;

namespace ConsoleAppRevision5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name");
            string lastName = Console.ReadLine();

            int age = GetNumber("Enter your age!");

            Human person = new()
            {
                FirstName = firstName,
                LastName = lastName,
                Age = age
            };
            Dog dog = new() { Name = "Bailey", Description = "Very cute dog" };

            Console.WriteLine(person.GetPersonStats());
            Console.WriteLine($"{dog.Name}, {dog.Description}");

        }
        public static int GetNumber(string input)
        {
            while (true)
            {
                Console.WriteLine(input);
                bool isNumber = int.TryParse(Console.ReadLine(), out int number);
                if (isNumber) return number;
                else
                {
                    Console.Clear();
                    continue;
                }

            }
        }
    }
}
