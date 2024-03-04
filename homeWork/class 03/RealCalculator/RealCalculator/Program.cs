namespace RealCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum;
            int secondNum;

            while (true)
            {
                Console.WriteLine("Enter two numbers");
                string firstInput = Console.ReadLine();
                string secondInput = Console.ReadLine();
                if (int.TryParse(firstInput, out firstNum) && int.TryParse(secondInput, out secondNum))
                {
                    break;
                }
                Console.WriteLine("The numbers are invalid, please try again!");
            }

                string sumOperator;
                while (true)
            {
                Console.WriteLine("Enter an operator: (+, -, *, /)");
                sumOperator = Console.ReadLine();

                int sum = 0;
                switch (sumOperator)
                {
                    case "+":
                        sum = firstNum + secondNum;
                        break;

                    case "-":
                        sum = firstNum - secondNum;
                        break;

                    case "*":
                        sum = firstNum * secondNum;
                        break;

                    case "/":
                        sum = firstNum / secondNum;
                        break;

                    default:
                        continue;
                }
                Console.WriteLine($"{firstNum} {sumOperator} {secondNum} = {sum}");
                break;
            }
        }
    }
}
