namespace enterNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Array.Empty<string>();
            do
            {
                Console.WriteLine("Enter a name:");
                string name = Console.ReadLine();
                if(name.Length < 2)
                {
                    Console.WriteLine("The name is too short!");
                    continue;
                }

                Array.Resize(ref names, names.Length + 1);
                names[names.Length - 1] = name;

                Console.WriteLine("Do you want to add another name?(Y/N)");
                string input = Console.ReadLine();
                string choice = input.ToUpper();
                switch (choice)
                {
                    case "Y":
                        continue;

                    case "N":
                    default:
                        break;
                }
                break;
            } while(true);

            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
