namespace Class3HomeworkAppRevisionPart2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = GetNumber("Please enter a number!");
            
            Console.WriteLine("Counting up..");

            for(int i = 1; i <= firstNumber; i++)
            {
                    Console.WriteLine(i);
            }

            Console.WriteLine("Press Enter to continue!");
            Console.ReadLine();

            int secondNumber = GetNumber("Please enter a number again!");
            Console.WriteLine("Counting down...");

            for (int i = secondNumber; i >= 1; i--) {
                Console.WriteLine(i);
            }
            
        }
        static int GetNumber(string input)
        { 
            while (true)
            {
                Console.WriteLine(input);
                bool goodNumber = int.TryParse(Console.ReadLine(), out int result);
                if (goodNumber) return result;
                else {
                    Console.Clear();
                    continue;
                };
            }
        }
    }
}
