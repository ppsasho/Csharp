using System.Globalization;

namespace sumOfEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            int counter = 0;
            while(counter < 5)
            {
                Console.WriteLine("Enter a number:");
                string input = Console.ReadLine();
                if(int.TryParse(input, out numbers[counter]))
                {
                    counter++;
                    continue;
                }

                Console.WriteLine("You entered an invalid number, please try again!");
            }
            int sum = numbers.Sum();
            Console.WriteLine($"The result is: {sum}");
            
        }
    }
}
