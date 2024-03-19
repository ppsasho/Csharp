using System.Collections;
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new();
            while (!UI(numbers)) ;
        }
        static int GetNumber(string msg)
        {
            while (true)
            {
                if (int.TryParse(GetInput(msg), out int number)) return number;
                Console.WriteLine("Invalid input for number!");
                continue;
            }
        }
        static string GetInput(string msg)
        {
            while (true)
            {
                Console.Write(msg);
                string input = Console.ReadLine();
                if (input.Length < 1)
                {
                    Console.WriteLine("There was no input!");
                    continue;
                }
                return input;
            }
        }
        static bool UI(Queue<int> numbers)
        {
            int number = GetNumber("Enter a number:\t");
            numbers.Enqueue(number);

            switch (GetInput("Would you like to enter another number? (Y N):").ToUpper())
            {
                case "Y":
                    return false;
                case "N":
                default:
                    break;
            }

            Console.WriteLine("Printing numbers:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            } return true;
        }
    }
}
