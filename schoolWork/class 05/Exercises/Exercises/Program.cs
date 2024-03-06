namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;
            string mathOperator;
            int sum = 0;

            while (true)
            {
                Console.WriteLine("Enter your first number:");
                string input = Console.ReadLine();

                if(!int.TryParse(input, out firstNum))
                {
                    Console.WriteLine("Wrong input, try again.");
                    continue;
                }

                break;
            }

            while (true)
            {
                Console.WriteLine("Enter your second number:");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out secondNum))
                {
                    Console.WriteLine("Wrong input, try again.");
                    continue;
                }
                break;
            }

            while(true)
            {
                Console.WriteLine("Please enter an operator: (+ -)");
                mathOperator = Console.ReadLine();
                if (mathOperator != "+" && mathOperator != "-")
                {
                    Console.WriteLine("You didn't enter a valid operator, please try again.");
                    continue;
                }
                break;
            }

            switch(mathOperator)
            {
                case "+":
                    sum = Sum(firstNum, secondNum);
                    break;

                case "-":
                    sum = Subtract(firstNum, secondNum);
                    break;

                default:
                    break;
            }

            Console.WriteLine(value: $"The result is {sum}");

        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
    }
}
