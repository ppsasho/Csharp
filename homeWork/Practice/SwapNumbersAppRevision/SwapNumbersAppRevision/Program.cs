namespace SwapNumbersAppRevision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");

            bool success = int.TryParse(Console.ReadLine(), out int firstNumber);
            if (success){
                Console.WriteLine("Enter the second number");
                bool secondSuccess = int.TryParse(Console.ReadLine(), out int secondNumber);
                if (secondSuccess) {
                    Console.WriteLine($"The Swapped numbers are: {secondNumber} & {firstNumber}");
                }
                else {
                    Console.WriteLine("You didn't enter a number!");
                }
            } else
            {
                Console.WriteLine("You didn't enter a number!");
                Console.ReadLine();
            }
        }
    }
}
