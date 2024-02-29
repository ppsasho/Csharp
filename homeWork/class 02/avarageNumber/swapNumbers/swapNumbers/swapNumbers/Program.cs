using System.Transactions;

namespace swapNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Enter your second number:");
            string input2 = Console.ReadLine();

            int secondNum = 0;

            Console.WriteLine("Attempting to swap numbers...");
            bool goodInput = int.TryParse(input1, out int firstNum) && int.TryParse(input2, out secondNum);
            if(!goodInput)
            {
                Console.WriteLine("You didn't enter two numbers!");
                return;
            }

            int firstTemp = firstNum;
            int secondTemp = secondNum;

            firstNum = secondTemp;
            secondNum = firstTemp;
            Console.WriteLine($"Now your first number is {firstNum}, and your second number is {secondNum}");

        }
    }
}
