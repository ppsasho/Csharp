namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            {
                {"Sasho", "232352342"},
                {"David", "246454544" },
                {"Bob", "235235235" },
                {"Mile", "235235623" },
                {"Sara", "2352352342" }
            };
            while (true)
            {
                Console.Write("Please enter the name for search:");
                string input = Console.ReadLine();

                bool foundPhone = phoneBook.TryGetValue(input, out string number);
                if (foundPhone) Console.WriteLine(number);
                else Console.WriteLine("The name was not found in the phone book.");
                
                Console.Write("Do you want to try again? (Y N)");
                string choice = Console.ReadLine();
                if(!string.Equals(choice, "y", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }
            }

        }
    }
}
