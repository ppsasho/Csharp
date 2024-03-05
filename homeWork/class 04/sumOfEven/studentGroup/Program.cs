namespace studentGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = new string[5] { "Emily", "Jamal", "Sophia", "Diego", "Olivia" };
            string[] studentsG2 = new string[5] { "Lucas", "Isabella", "Ethan", "Mia", "Liam" };
            int choice = 0;
            while (choice == 0)
            {
                Console.WriteLine("There are 2 student groups, pick between 1 or 2");
                string input = Console.ReadLine();
                int.TryParse(input, out choice);
                switch(choice)
                {
                    case 1:
                        foreach(string student in studentsG1)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    case 2:
                        foreach (string student in studentsG2)
                        {
                            Console.WriteLine(student);
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong input, try again.");
                        continue;
                }
            }
        }
    }
}
