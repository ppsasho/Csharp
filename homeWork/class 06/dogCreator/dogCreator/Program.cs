namespace dogCreator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog; 
            while (true)
            {
                dog = new Dog(GetInput("Enter your dog's name:"), GetInput("Enter your dog's breed:"), GetInput("Enter your dog's color:"));
                Console.WriteLine(dog.Name, dog.Breed, dog.Color);
                if (dog.Name == "" ||
                    dog.Breed == "" ||
                    dog.Color == "")
                {
                    Console.WriteLine("Please make sure you fill in all the fields");
                    continue;
                }

                    break;
            }

            while (true)
            {
                string choice = GetInput("Choose a number from 1 to 3:");
                switch(choice)
                {
                    case "1":
                        Console.WriteLine(dog.Eat());
                        return;

                    case "2":
                        Console.WriteLine(dog.Play());
                        return;

                    case "3":
                        Console.WriteLine(dog.ChaseTail());
                        return;

                    default:
                        Console.WriteLine("Please make sure you enter one number.");
                        continue;
                }
            }
        }
        public static string GetInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            return input;
        }
    }
}
